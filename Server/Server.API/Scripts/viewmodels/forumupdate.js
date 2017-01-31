/// <reference path="~/scripts/common.js" />

var UpdateForumModel = function () {
	var self = this;

	self.Forum = new Forum(forumId, self);
	self.CreateSubModal = new CreateModal(self);

	self.AccessMasks = ko.observableArray([]);
	self.Groups = ko.observableArray([]);
	self.ForumAccesses = ko.observableArray([]);

	self.AccessMasksLoaded = ko.observable(false);

	self.NoStatus = ko.observable(true);
	self.Success = ko.observable(false);
	self.Error = ko.observable(false);
	self.StatusHeading = ko.observable("");
	self.StatusBody = ko.observable("");
	self.AddHidden = ko.observable(true);

	self.ShowAdd = function (data, event) {
		self.AddHidden(false);
	};

	self.HideAdd = function (data, event) {
		self.AddHidden(true);
	};

	self.Load = function () {
		self.Forum.Load();
		self.LoadAccessMasks();
	};

	self.LoadAccessMasks = function () {
		jQuery.ajax({ url: readAccessMasksUrl }).done(self.DataReturned).fail(function (request, error) { console.log(error); });
	};

	self.DataReturned = function (data) {
		self.AccessMasks.removeAll();
		ko.utils.arrayForEach(data.AccessMasks, function (item) {
			self.AccessMasks.push(new AccessMask(item.Id, item.Name, item.AccessFlag));
		});

		jQuery.ajax({ url: readGroupsUrl }).done(self.GroupDataReturned).fail(function (request, error) { console.log(error); });
	};

	self.GroupDataReturned = function (data) {
		self.Groups.removeAll();
		ko.utils.arrayForEach(data.Groups, function (item) {
			var group = new Group(item.Id, item.Name);
			self.Groups.push(group);
			self.ForumAccesses.push(new ForumAccess(group));
		});

		jQuery.ajax({ url: readForumAccessUrl }).done(self.AccessDataReturned).fail(function (request, error) { console.log(error); });

	};

	self.AccessDataReturned = function (data) {
		ko.utils.arrayForEach(data.Masks, function (mask) {
			ko.utils.arrayForEach(self.ForumAccesses(), function (access) {
				if (mask.Group == access.Group.Id) {
					access.AccessMask(mask.AccessMask);
					access.Id = mask.Id;
				}
			});
		});

		self.AccessMasksLoaded(true);
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
		// TODO: ScrollTo somehow!
		self.NoStatus(false);
		self.StatusHeading(heading);
		self.StatusBody(body);
	};
};

var Forum = function (id, model) {
	var self = this;

	self.ViewModel = model;

	self.Id = id;
	self.CategoryId = 0;
	self.Name = ko.observable("").extend({ required: { message: GetLocalizedText("MVCForum.Web.ViewModels.Forum.NameRequired") }, minLength: 1 });
	self.SortOrder = ko.observable(0).extend({ required: { message: GetLocalizedText("MVCForum.Web.ViewModels.Forum.SortOrderRequired") }, integer: { message: GetLocalizedText("MVCForum.Web.ViewModels.Forum.SortOrderInteger")} });
	self.Description = ko.observable("");

	self.Errors = ko.validation.group(self);

	self.SubForums = ko.observableArray([]);

	self.Updating = ko.observable(false);
	self.ButtonText = ko.computed(function () {
		return (self.Updating() ? GetLocalizedText("MVCForum.ForumAdmin.Forum.Index.Updating") : GetLocalizedText("MVCForum.ForumAdmin.Forum.Index.UpdateMasks"));
	});

	self.Loaded = ko.observable(false);
	self.SubForumsLoaded = ko.observable(false);

	self.Load = function () {
		jQuery.ajax({ url: readUrl }).done(self.DataReturned).fail(function (request, error) { console.log(error); });
		self.LoadSubForums();
	};

	self.LoadSubForums = function () {
		jQuery.ajax({ url: forumsUrl }).done(self.ForumsReturned).fail(function (request, error) { console.log(error); });
	};

	self.DataReturned = function (data) {
		self.Id = data.Id;
		self.CategoryId = data.CategoryId;

		self.ViewModel.CreateSubModal.Id = data.Id;
		self.ViewModel.CreateSubModal.CategoryId = data.CategoryId;

		self.Name(data.Name);
		self.Description(data.Description);
		self.SortOrder(data.SortOrder);
		self.Loaded(true);
	};

	self.ForumsReturned = function (data) {
		self.SubForums.removeAll();
		ko.utils.arrayForEach(data.Forums, function (item) {
			self.SubForums.push(new SubForum(item.Id, item.Name, item.SortOrder, self));
		});
		self.SubForumsLoaded(true);
	};

	self.Save = function () {
		if (!self.Updating()) {
			if (self.Errors().length > 0) {
				// Something failed, let's show all the errors!
				self.Errors.showAllMessages();
			}
			else {
				self.Updating(true);
				// Everything looks okay, let's submit and let the server handle further validation!
				jQuery.ajax({ dataType: "json", type: "POST", url: updateUrl, data: { mode: "json", Id: self.Id, Name: self.Name(), Description: self.Description(), SortOrder: self.SortOrder()} }).done(self.SubmitDone).fail(self.ErrorOccured);
			}
		}
	};

	self.DeleteSubForum = function (forum) {
		self.SubForums.remove(forum);
	};

	self.SubmitDone = function (data) {
		self.ViewModel.ShowSuccess(GetLocalizedText("MVCForum.ForumAdmin.Forum.Index.SuccessHeading"), GetLocalizedText("MVCForum.ForumAdmin.Forum.Index.SuccessBody"));
		self.Updating(false);
	};

	self.ErrorOccured = function (response, status, error) {
		self.ViewModel.ShowFailure(GetLocalizedText("MVCForum.ForumAdmin.Forum.Index.FailureHeading"), GetLocalizedText("MVCForum.ForumAdmin.Forum.Index.FailureBody").format(response.statusText));
	};
};

var SubForum = function (id, name, sortOrder, parent) {
	var self = this;

	self.Parent = parent;
	self.Id = id;
	self.Name = name;
	self.SortOrder = sortOrder;

	self.Delete = function (data, event) {
		confirmModel.Show(GetLocalizedText("MVCForum.ForumAdmin.Forum.Index.ConfirmDeleteHeading"), GetLocalizedText("MVCForum.ForumAdmin.Forum.Index.ConfirmDeleteBody").format(self.Name), self.DeleteSelf);
	};

	self.DeleteSelf = function () {
		jQuery.ajax({ dataType: "json", type: "POST", url: deleteUrl, data: { mode: "json", Id: self.Id, deleteAll: true } }).done(self.Deleted).fail(self.ErrorOccured);
	};

	self.Deleted = function (data) {
		self.Parent.DeleteSubForum(self);
	};

	self.ErrorOccured = function (response, status, error) {
		self.Parent.ViewModel.ShowFailure(GetLocalizedText("MVCForum.ForumAdmin.Forum.Index.DeleteFailureHeading"), GetLocalizedText("MVCForum.ForumAdmin.Forum.Index.DeleteFailureBody").format(response.statusText));
	};
};

var CreateModal = function (model) {
	var self = this;

	self.ViewModel = model;

	self.Id = 0;
	self.CategoryId = 0;
	self.Name = ko.observable("").extend({ required: { message: GetLocalizedText("MVCForum.Web.ViewModels.Forum.NameRequired") }, minLength: 1 });
	self.SortOrder = ko.observable(0).extend({ required: { message: GetLocalizedText("MVCForum.Web.ViewModels.Forum.SortOrderRequired") }, integer: { message: GetLocalizedText("MVCForum.Web.ViewModels.Forum.SortOrderInteger")} });
	self.Description = ko.observable("");

	self.Errors = ko.validation.group(self);

	self.Create = function (data, event) {
		if (self.Errors().length > 0) {
			// Something failed, let's show all the errors!
			self.Errors.showAllMessages();
		}
		else {
			// Everything looks okay, let's submit and let the server handle further validation!
			jQuery.ajax({ dataType: "json", type: "POST", url: createUrl, data: { mode: "json", ParentForumId: self.Id, Name: self.Name(), Description: self.Description(), SortOrder: self.SortOrder(), CategoryId: self.CategoryId} }).done(self.SubmitDone).fail(self.ErrorOccured);
		}
	};

	self.SubmitDone = function (data) {
		self.ViewModel.ShowSuccess(GetLocalizedText("MVCForum.ForumAdmin.Forum.Index.CreateSuccessHeading"), GetLocalizedText("MVCForum.ForumAdmin.Forum.Index.CreateSuccessBody"));
		self.ViewModel.HideAdd();
		self.ViewModel.Forum.LoadSubForums();

		self.Name("");
		self.SortOrder(0);
		self.Description("");
	};

	self.ErrorOccured = function (response, status, error) {
		self.ViewModel.ShowFailure(GetLocalizedText("MVCForum.ForumAdmin.Forum.Index.SubFailureHeading"), GetLocalizedText("MVCForum.ForumAdmin.Forum.Index.SubFailureBody").format(response.statusText));
	};
};

var AccessMask = function (id, name, flag) {
	var self = this;

	self.Id = id;
	self.Name = name;
	self.Flag = flag;
};

var Group = function (id, name) {
	var self = this;

	self.Id = id;
	self.Name = name;
};

var ForumAccess = function (group) {
	var self = this;

	self.Id = 0;
	self.Group = group;
	self.AccessMask = ko.observable(0);

	self.Loading = ko.observable(false);

	self.ButtonText = ko.computed(function () {
		return (self.Loading() ? GetLocalizedText("MVCForum.ForumAdmin.Forum.Index.Updating") : GetLocalizedText("MVCForum.ForumAdmin.Forum.Index.UpdateMasks"));
	});

	self.Update = function (data, event) {
		self.Loading(true);
		if (typeof self.AccessMask() === "undefined") {
			jQuery.ajax({ dataType: "json", type: "POST", url: deleteAccessUrl, data: { mode: "json", Id: self.Id} }).done(self.UpdateDone).fail(self.ErrorOccured);
		}
		else if (self.Id == 0) {
			jQuery.ajax({ dataType: "json", type: "POST", url: createAccessUrl, data: { mode: "json", ForumId: forumId, GroupId: self.Group.Id, AccessMaskId: self.AccessMask()} }).done(self.UpdateDone).fail(self.ErrorOccured);
		}
		else {
			jQuery.ajax({ dataType: "json", type: "POST", url: updateAccessUrl, data: { mode: "json", Id: self.Id, ForumId: forumId, GroupId: self.Group.Id, AccessMaskId: self.AccessMask()} }).done(self.UpdateDone).fail(self.ErrorOccured);
		}
	};

	self.UpdateDone = function (data) {
		self.Loading(false);
		if (data && data.Id) {
			self.id = data.Id;
		}
	};

	self.ErrorOccured = function (response, status, error) {
		// TODO:
		//self.ViewModel.ShowFailure(GetLocalizedText("MVCForum.ForumAdmin.Group.Index.DeleteFailureHeading"), GetLocalizedText("MVCForum.ForumAdmin.Group.Index.DeleteFailureBody").format(response.statusText));
	};
};

var model = new UpdateForumModel();
ko.applyBindings(model, document.getElementById("forumsec"));

model.Load();
