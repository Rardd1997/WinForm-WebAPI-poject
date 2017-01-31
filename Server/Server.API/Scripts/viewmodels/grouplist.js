/// <reference path="~/scripts/common.js" />

var GroupListModel = function () {
	var self = this;

	self.Groups = ko.observableArray([]);
	self.CreateModal = new CreateModal(self);

	self.Loaded = ko.observable(false);

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
		jQuery.ajax({ url: groupListUrl }).done(self.DataReturned).fail(function (request, error) { console.log(error); });
	};

	self.DataReturned = function (data) {
		// TODO: Not good for performance!?
		self.Groups.removeAll();
		ko.utils.arrayForEach(data.Groups, function (item) {
			self.Groups.push(new Group(item.Id, item.Name, self));
		});

		self.Loaded(true);
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
		document.getElementById("groups").scrollIntoView();
	};

	self.DeleteGroup = function (group) {
		self.groups.remove(group);
	};
};

var Group = function (id, name, model) {
	var self = this;

	self.Id = id;
	self.Name = name;
	self.ViewModel = model;

	self.Delete = function (data, event) {
		confirmModel.Show(GetLocalizedText("MVCForum.ForumAdmin.Group.Index.ConfirmDeleteHeading"), GetLocalizedText("MVCForum.ForumAdmin.Group.Index.ConfirmDeleteBody").format(self.Name), self.DeleteSelf);
	};

	self.DeleteSelf = function () {
		jQuery.ajax({ dataType: "json", type: "POST", url: deleteUrl, data: { mode: "json", Id: self.Id} }).done(self.DeletedGroup).fail(self.ErrorOccured);
	};

	self.DeletedGroup = function (data) {
		self.ViewModel.Load();
	};

	self.ErrorOccured = function (response, status, error) {
		self.ViewModel.ShowFailure(GetLocalizedText("MVCForum.ForumAdmin.Group.Index.DeleteFailureHeading"), GetLocalizedText("MVCForum.ForumAdmin.Group.Index.DeleteFailureBody").format(response.statusText));
	};
};

var CreateModal = function (model) {
	var self = this;

	self.ViewModel = model;

	self.Name = ko.observable("").extend({ required: { message: GetLocalizedText("MVCForum.Web.ViewModels.Group.NameRequired") }, minLength: 1 });

	self.Errors = ko.validation.group(self);

	self.Create = function (data, event) {
		if (self.Errors().length > 0) {
			// Something failed, let's show all the errors!
			self.Errors.showAllMessages();
		}
		else {
			// Everything looks okay, let's submit and let the server handle further validation!
			jQuery.ajax({ dataType: "json", type: "POST", url: createUrl, data: { mode: "json", Name: self.Name() } }).done(self.SubmitDone).fail(self.ErrorOccured);
		}
	};

	self.SubmitDone = function (data) {
		self.ViewModel.ShowSuccess(GetLocalizedText("MVCForum.ForumAdmin.Group.Index.CreateSuccessHeading"), GetLocalizedText("MVCForum.ForumAdmin.Group.Index.CreateSuccessBody"));
		self.ViewModel.HideAdd();
		self.ViewModel.Load();

		self.Name("");
	};

	self.ErrorOccured = function (response, status, error) {
		self.ViewModel.ShowFailure(GetLocalizedText("MVCForum.ForumAdmin.Group.Index.CreateFailureHeading"), GetLocalizedText("MVCForum.ForumAdmin.Group.Index.CreateFailureBody").format(response.statusText));
	};
};

var model = new GroupListModel();
ko.applyBindings(model, document.getElementById("groups"));

model.Load();
