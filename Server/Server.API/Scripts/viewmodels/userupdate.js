/// <reference path="~/scripts/common.js" />

var UserUpdateModel = function () {
	var self = this;

	self.User = new User(self);
	self.Groups = ko.observableArray([]);
	self.CreateModal = new CreateModal(self);
	self.Roles = ko.observableArray([]);
	self.BannedIP = ko.observable(false);
	self.BanStatusLoaded = ko.observable(false);

	self.GroupsLoaded = ko.observable(false);

	self.NoStatus = ko.observable(true);
	self.Success = ko.observable(false);
	self.Error = ko.observable(false);
	self.StatusHeading = ko.observable("");
	self.StatusBody = ko.observable("");
	self.AddHidden = ko.observable(true);

	self.ButtonText = ko.computed(function () {
		return self.BannedIP() ?
					GetLocalizedText("MVCForum.Web.ViewModels.ForumUser.Unban") :
					GetLocalizedText("MVCForum.Web.ViewModels.ForumUser.Ban");
	});

	self.ShowAdd = function (data, event) {
		self.AddHidden(false);
	};

	self.HideAdd = function (data, event) {
		self.AddHidden(true);
	};

	self.ShowAdd = function (data, event) {
		self.AddHidden(false);
	};

	self.User.LastIP.subscribe(function (newValue) {
		if (newValue && newValue != '') {
			jQuery.ajax({ dataType: "json", type: "POST", url: banStatusUrl, data: { mode: "json", ip: newValue} }).done(self.BanStatusReturned).fail(self.ErrorOccured);
		}
	});

	self.Load = function () {
		self.User.Load();
		self.LoadMemberships();
		self.CreateModal.LoadGroups();
	};

	self.LoadMemberships = function () {
		jQuery.ajax({ url: readMembershipUrl }).done(self.DataReturned).fail(function (request, error) { console.log(error); });
		self.LoadRoles();
	};

	self.DataReturned = function (data) {
		self.Groups.removeAll();
		ko.utils.arrayForEach(data.Groups, function (item) {
			self.Groups.push(new GroupMember(item.Id, item.Name, self));
		});

		self.GroupsLoaded(true);
	};

	self.LoadRoles = function () {
		jQuery.ajax({ url: listRoles }).done(self.RoleDataReturned).fail(function (request, error) { console.log(error); });
	};

	self.RoleDataReturned = function (data) {
		self.Roles.removeAll();
		ko.utils.arrayForEach(data.Roles, function (item) {
			self.Roles.push(item);
		});
	};

	self.HideStatus = function (data, event) {
		self.NoStatus(true);
		self.Success(false);
		self.Error(false);
	};

	self.ShowSuccess = function (heading, body) {
		self.Success(true);
		self.ShowFeedback(heading, body);
	};

	self.ShowFailure = function (heading, body) {
		self.Error(true);
		self.ShowFeedback(heading, body);
	};

	self.ShowFeedback = function (heading, body) {
		self.NoStatus(false);
		self.StatusHeading(heading);
		self.StatusBody(body);
	};

	self.BanStatusReturned = function (data) {
		self.BannedIP(data.Banned);
		self.BanStatusLoaded(true);
	};

	self.BanIP = function (data, event) {
		if (self.BanStatusLoaded()) {
			if (self.BannedIP()) {
				jQuery.ajax({ dataType: "json", type: "POST", url: unbanUrl, data: { mode: "json", ip: self.User.LastIP()} }).done(self.BanStatusChange).fail(self.ErrorOccured);
			}
			else {
				jQuery.ajax({ dataType: "json", type: "POST", url: banUrl, data: { mode: "json", ip: self.User.LastIP()} }).done(self.BanStatusChange).fail(self.ErrorOccured);
			}
			self.BannedIP(!self.BannedIP());
		}
	};

	self.BanStatusChange = function (data) {
	};
};

var User = function (model) {
	var self = this;

	self.ViewModel = model;

	self.Name = ko.observable("");
	//self.Name = ko.observable("").extend({ required: { message: GetLocalizedText("MVCForum.Web.ViewModels.ForumUser.NameRequired") }, minLength: 1 });
	self.EmailAddress = ko.observable(0).extend({ required: { message: GetLocalizedText("MVCForum.Web.ViewModels.ForumUser.EmailAddressRequired")} });
	self.LastIP = ko.observable("");
	self.Deleted = ko.observable(false);
	self.Active = ko.observable(false);
	self.Locked = ko.observable(false);
	self.FirstVisit = ko.observable(new Date());
	self.LatestVisit = ko.observable(new Date());
	self.Roles = ko.observableArray([]);

	self.FirstVisitString = ko.computed(function () {
		return self.FirstVisit().getMonth ? self.FirstVisit().toDateString() : "";
	});

	self.LatestVisitString = ko.computed(function () {
		return self.LatestVisit().getMonth ? self.LatestVisit().toDateString() : "";
	});

	self.Errors = ko.validation.group(self);
	self.Loaded = ko.observable(false);

	self.Unlock = function (data, event) {
		if (self.Locked()) {
			jQuery.ajax({ dataType: "json", type: "POST", url: unlockUrl, data: { mode: "json", Id: userId } }).done(self.Unlocked).fail(self.ErrorOccured);
		}
	};

	self.Unlocked = function (data) {
		self.Locked(false);
	};

	self.Load = function () {
		jQuery.ajax({ url: readUrl }).done(self.DataReturned).fail(function (request, error) { console.log(error); });
		self.LoadRoles();
	};

	self.DataReturned = function (data) {
		self.Name(data.Name);
		self.EmailAddress(data.EmailAddress);
		self.LastIP(data.LastIP);
		self.Deleted(data.Deleted);
		self.Active(data.Active);
		self.Loaded(true);
		self.Locked(data.Locked);
		self.FirstVisit(new Date(data.FirstVisit));
		self.LatestVisit(new Date(data.LastVisit));
	};

	self.LoadRoles = function () {
		jQuery.ajax({ url: readRoles }).done(self.RoleDataReturned).fail(function (request, error) { console.log(error); });
	};

	self.RoleDataReturned = function (data) {
		self.Roles.removeAll();
		ko.utils.arrayForEach(data.Roles, function (item) {
			self.Roles.push(item);
		});
	};

	self.SaveRoles = function () {
		jQuery.ajax({ dataType: "json", type: "POST", url: updateRolesUrl, data: { mode: "json", Id: userId, Roles: self.Roles().join(",")} }).done(self.RoleSubmitDone).fail(self.ErrorOccured);
	};

	self.RoleSubmitDone = function (data) {
	};

	self.Save = function () {
		if (self.Errors().length > 0) {
			// Something failed, let's show all the errors!
			self.Errors.showAllMessages();
		}
		else {
			console.log(self.Active());
			// Everything looks okay, let's submit and let the server handle further validation!
			jQuery.ajax({ dataType: "json", type: "POST", url: updateUrl, data: { mode: "json", Id: userId, Name: self.Name(), Deleted: self.Deleted(), Active: self.Active(), EmailAddress: self.EmailAddress()} }).done(self.SubmitDone).fail(self.ErrorOccured);
		}
	};

	self.SubmitDone = function (data) {
		self.ViewModel.ShowSuccess(GetLocalizedText("MVCForum.ForumAdmin.User.Update.SuccessHeading"), GetLocalizedText("MVCForum.ForumAdmin.User.Update.SuccessBody"));
	};

	self.ErrorOccured = function (response, status, error) {
		self.ViewModel.ShowFailure(GetLocalizedText("MVCForum.ForumAdmin.User.Update.FailureHeading"), GetLocalizedText("MVCForum.ForumAdmin.User.Update.FailureBody").format(response.statusText));
	};
};

var GroupMember = function (id, name, model) {
	var self = this;

	self.Id = id;
	self.Name = name;
	self.ViewModel = model;

	self.Delete = function (data, event) {
		confirmModel.Show(GetLocalizedText("MVCForum.ForumAdmin.User.Update.ConfirmDeleteHeading"), GetLocalizedText("MVCForum.ForumAdmin.User.Update.ConfirmDeleteBody").format(self.Name), self.DeleteSelf);
	};

	self.DeleteSelf = function () {
		jQuery.ajax({ dataType: "json", type: "POST", url: deleteMembershipUrl, data: { mode: "json", Id: self.Id} }).done(self.DeletedGroup).fail(self.ErrorOccured);
	};

	self.DeletedGroup = function (data) {
		self.ViewModel.LoadMemberships();
	};

	self.ErrorOccured = function (response, status, error) {
		self.ViewModel.ShowFailure(GetLocalizedText("MVCForum.ForumAdmin.User.Update.DeleteFailureHeading"), GetLocalizedText("MVCForum.ForumAdmin.User.Update.DeleteFailureBody").format(response.statusText));
	};
};

var Group = function (id, name) {
	var self = this;

	self.Id = id;
	self.Name = name;
};

var CreateModal = function (model) {
	var self = this;

	self.ViewModel = model;

	self.GroupId = ko.observable(0).extend({ required: { message: GetLocalizedText("MVCForum.Web.ViewModels.Group.NameRequired")} });

	self.Errors = ko.validation.group(self);

	self.GroupList = ko.observableArray([]);

	self.LoadGroups = function () {
		jQuery.ajax({ url: listGroupsUrl }).done(self.GroupDataReturned).fail(function (request, error) { console.log(error); });
	};

	self.GroupDataReturned = function (data) {
		self.GroupList.removeAll();
		ko.utils.arrayForEach(data.Groups, function (item) {
			var temp = new Group(item.Id, item.Name);
			self.GroupList.push(temp);
		});
	};

	self.Create = function (data, event) {
		if (self.Errors().length > 0) {
			// Something failed, let's show all the errors!
			self.Errors.showAllMessages();
		}
		else {
			// Everything looks okay, let's submit and let the server handle further validation!
			jQuery.ajax({ dataType: "json", type: "POST", url: createMembershipUrl, data: { mode: "json", userId: userId, groupId: self.GroupId()} }).done(self.SubmitDone).fail(self.ErrorOccured);
		}
	};

	self.SubmitDone = function (data) {
		self.ViewModel.ShowSuccess(GetLocalizedText("MVCForum.ForumAdmin.User.Update.CreateSuccessHeading"), GetLocalizedText("MVCForum.ForumAdmin.User.Update.CreateSuccessBody"));
		self.ViewModel.HideAdd();
		self.ViewModel.LoadMemberships();

		self.GroupId(0);
	};

	self.ErrorOccured = function (response, status, error) {
		self.ViewModel.ShowFailure(GetLocalizedText("MVCForum.ForumAdmin.User.Update.CreateFailureHeading"), GetLocalizedText("MVCForum.ForumAdmin.User.Update.CreateFailureBody").format(response.statusText));
	};
};

var model = new UserUpdateModel();
ko.applyBindings(model, document.getElementById("usersec"));

model.Load();
