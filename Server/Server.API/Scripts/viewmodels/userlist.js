/// <reference path="~/scripts/common.js" />

var UserListModel = function () {
	var self = this;

	self.Users = ko.observableArray([]);
	self.CreateModal = new CreateModal(self);

	self.Loaded = ko.observable(false);

	self.NoStatus = ko.observable(true);
	self.Success = ko.observable(false);
	self.Error = ko.observable(false);
	self.StatusHeading = ko.observable("");
	self.StatusBody = ko.observable("");
	self.AddHidden = ko.observable(true);
	self.Count = ko.observable(0);
	self.PageSize = ko.observable(0);
	self.Index = ko.observable(0);
	self.Query = ko.observable("");
	self.NextUrl = "";
	self.PrevUrl = "";

	self.Search = function () {
		jQuery.ajax({ dataType: "json", type: "POST", url: searchUrl, data: { mode: "json", query: self.Query()} }).done(self.DataReturned).fail(self.ErrorOccured);
	};

	self.ShowAdd = function (data, event) {
		self.AddHidden(false);
	};

	self.HideAdd = function (data, event) {
		self.AddHidden(true);
	};

	self.Load = function (url) {
		jQuery.ajax({ url: url }).done(self.DataReturned).fail(function (request, error) { console.log(error); });
	};

	self.PagingVisible = ko.computed(function () {
		return self.Count() > self.PageSize();
	});

	self.DataReturned = function (data) {
		// TODO: Not good for performance!?
		self.Users.removeAll();
		ko.utils.arrayForEach(data.Users, function (item) {
			self.Users.push(new User(item.Id, item.Name, item.EmailAddress, item.Deleted, item.Active, new Date(item.FirstVisit), self));
		});
		self.Count(data.Count);
		self.PageSize(data.PageSize);
		self.Index((data.Skipped / data.PageSize) + 1);
		self.NextUrl = data.Next;
		self.PrevUrl = data.Previous;
		self.Users.sort(function (left, right) {
			return left.FirstVisit == right.FirstVisit ? 0 : left.FirstVisit < right.FirstVisit ? 1 : -1;
		});

		self.Loaded(true);
	};

	self.Next = function (data, event) {
		if (self.NextUrl != "") {
			self.Load(self.NextUrl);
		}
	};

	self.Prev = function (data, event) {
		if (self.PrevUrl != "") {
			self.Load(self.PrevUrl);
		}
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

		// TODO:
		document.getElementById("users").scrollIntoView();
	};

	self.DeleteUser = function (user) {
		self.Users.remove(user);
	};
};

var User = function (id, name, email, deleted, active, firstVisit, model) {
	var self = this;

	self.Id = id;
	self.Name = name;
	self.EmailAddress = email;
	self.Deleted = deleted ? "Yes" : "No";
	self.Active = active ? "Yes" : "No";
	self.ViewModel = model;
	self.FirstVisit = firstVisit;

	self.Delete = function (data, event) {
		confirmModel.Show(GetLocalizedText("MVCForum.ForumAdmin.User.Index.ConfirmDeleteHeading"), GetLocalizedText("MVCForum.ForumAdmin.User.Index.ConfirmDeleteBody").format(self.Name), self.DeleteSelf);
	};

	self.DeleteSelf = function () {
		jQuery.ajax({ dataType: "json", type: "POST", url: deleteUrl, data: { mode: "json", Id: self.Id} }).done(self.DeletedUser).fail(self.ErrorOccured);
	};

	self.DeletedUser = function (data) {
		self.ViewModel.Load();
	};

	self.ErrorOccured = function (response, status, error) {
		self.ViewModel.ShowFailure(GetLocalizedText("MVCForum.ForumAdmin.User.Index.DeleteFailureHeading"), GetLocalizedText("MVCForum.ForumAdmin.User.Index.DeleteFailureBody").format(response.statusText));
	};
};

var CreateModal = function (model) {
	var self = this;

	self.ViewModel = model;

	self.Name = ko.observable("").extend({ required: { message: GetLocalizedText("MVCForum.Web.ViewModels.ForumUser.NameRequired") }, minLength: 1 });
	self.EmailAddress = ko.observable("").extend({ required: { message: GetLocalizedText("MVCForum.Web.ViewModels.ForumUser.EmailAddressRequired") } });
	self.Password = ko.observable("").extend({ required: { message: GetLocalizedText("MVCForum.Web.ViewModels.ForumUser.PasswordRequired") }, minLength: 1 });
	self.RepeatPassword = ko.observable("").extend({ required: { message: GetLocalizedText("MVCForum.Web.ViewModels.ForumUser.RepeatPasswordRequired") }, minLength: 1 });

	self.Errors = ko.validation.group(self);

	self.Create = function (data, event) {
		if (self.Errors().length > 0) {
			// Something failed, let's show all the errors!
			self.Errors.showAllMessages();
		}
		else {
			// Everything looks okay, let's submit and let the server handle further validation!
			jQuery.ajax({ dataType: "json", type: "POST", url: createUrl, data: { mode: "json", Name: self.Name(), EmailAddress: self.EmailAddress(), Password: self.Password(), RepeatPassword: self.RepeatPassword() } }).done(self.SubmitDone).fail(self.ErrorOccured);
		}
	};

	self.SubmitDone = function (data) {
		self.ViewModel.ShowSuccess(GetLocalizedText("MVCForum.ForumAdmin.User.Index.CreateSuccessHeading"), GetLocalizedText("MVCForum.ForumAdmin.User.Index.CreateSuccessBody"));
		self.ViewModel.HideAdd();
		self.ViewModel.Load();

		self.Name("");
		self.EmailAddress("");
		self.Password("");
		self.RepeatPassword("");
	};

	self.ErrorOccured = function (response, status, error) {
		self.ViewModel.ShowFailure(GetLocalizedText("MVCForum.ForumAdmin.User.Index.CreateFailureHeading"), GetLocalizedText("MVCForum.ForumAdmin.User.Index.CreateFailureBody").format(response.statusText));
	};
};

var model = new UserListModel();
ko.applyBindings(model, document.getElementById("users"));

model.Load(userListUrl);
