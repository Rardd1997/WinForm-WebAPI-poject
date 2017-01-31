/// <reference path="~/scripts/common.js" />

var GroupUpdateModel = function () {
	var self = this;

	self.Group = new Group(self);

	self.NoStatus = ko.observable(true);
	self.Success = ko.observable(false);
	self.Error = ko.observable(false);
	self.StatusHeading = ko.observable("");
	self.StatusBody = ko.observable("");

	self.Load = function () {
		self.Group.Load();
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
};

var Group = function (model) {
	var self = this;

	self.ViewModel = model;

	self.Name = ko.observable("").extend({ required: { message: GetLocalizedText("MVCForum.Web.ViewModels.Group.NameRequired") }, minLength: 1 });

	self.Errors = ko.validation.group(self);
	self.Loaded = ko.observable(false);

	self.Load = function () {
		jQuery.ajax({ url: readUrl }).done(self.DataReturned).fail(function (request, error) { console.log(error); });
	};

	self.DataReturned = function (data) {
		self.Name(data.Name);
		self.Loaded(true);
	};

	self.Save = function () {
		if (self.Errors().length > 0) {
			// Something failed, let's show all the errors!
			self.Errors.showAllMessages();
		}
		else {
			// Everything looks okay, let's submit and let the server handle further validation!
			jQuery.ajax({ dataType: "json", type: "POST", url: updateUrl, data: { mode: "json", Id: groupId, Name: self.Name() } }).done(self.SubmitDone).fail(self.ErrorOccured);
		}
	};

	self.SubmitDone = function (data) {
		self.ViewModel.ShowSuccess(GetLocalizedText("MVCForum.ForumAdmin.Group.Update.SuccessHeading"), GetLocalizedText("MVCForum.ForumAdmin.Group.Update.SuccessBody"));
	};

	self.ErrorOccured = function (response, status, error) {
		self.ViewModel.ShowFailure(GetLocalizedText("MVCForum.ForumAdmin.Group.Update.FailureHeading"), GetLocalizedText("MVCForum.ForumAdmin.Group.Update.FailureBody").format(response.statusText));
	};
};

var model = new GroupUpdateModel();
ko.applyBindings(model, document.getElementById("groupsec"));

model.Load();
