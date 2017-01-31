/// <reference path="~/scripts/common.js" />

var UpdateAccessMaskModel = function () {
	var self = this;

	self.AccessMask = new AccessMask(accessMaskId, self);
	self.Loaded = ko.observable(false);

	self.NoStatus = ko.observable(true);
	self.Success = ko.observable(false);
	self.Error = ko.observable(false);
	self.StatusHeading = ko.observable("");
	self.StatusBody = ko.observable("");

	self.Load = function () {
		this.AccessMask.Load();
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
		document.getElementById("masksec").scrollIntoView();
	};
};

var AccessMask = function (id, model) {
	var self = this;

	self.Id = id;
	self.Name = ko.observable("").extend({ required: { message: GetLocalizedText("MVCForum.Web.ViewModels.AccessMask.NameRequired") }, minLength: 1 });
	self.AccessFlag = ko.observableArray([]);
	self.ViewModel = model;

	self.Loaded = ko.observable(false);

	self.Errors = ko.validation.group(self);

	self.Load = function () {
		jQuery.ajax({ url: readUrl }).done(self.DataReturned).fail(function (request, error) { console.log(error); });
	};

	self.DataReturned = function (data) {
		self.Id = data.Id;
		self.Name(data.Name);
		var tempArr = data.AccessFlag.split(",");
		self.AccessFlag.removeAll();
		ko.utils.arrayForEach(tempArr, function (item) {
			if (item.trim() != "None") {
				self.AccessFlag.push(item.trim());
			}
		});
		self.Loaded(true);
	};

	self.Save = function () {
		if (self.Errors().length > 0) {
			// Something failed, let's show all the errors!
			self.Errors.showAllMessages();
		}
		else {
			console.log(self.AccessFlag());
			// Everything looks okay, let's submit and let the server handle further validation!
			jQuery.ajax({ dataType: "json", type: "POST", url: updateUrl, data: { mode: "json", Id: self.Id, Name: self.Name(), AccessFlag: self.AccessFlag().length == 0 ? "None" : self.AccessFlag().join(",")} }).done(self.SubmitDone).fail(self.ErrorOccured);
		}
	};

	self.SubmitDone = function (data) {
		self.ViewModel.ShowSuccess(GetLocalizedText("MVCForum.ForumAdmin.AccessMask.Index.SuccessHeading"), GetLocalizedText("MVCForum.ForumAdmin.AccessMask.Index.SuccessBody"));
	};

	self.ErrorOccured = function (response, status, error) {
		self.ViewModel.ShowFailure(GetLocalizedText("MVCForum.ForumAdmin.AccessMask.Index.FailureHeading"), GetLocalizedText("MVCForum.ForumAdmin.AccessMask.Index.FailureBody").format(response.statusText));
	};
};

var model = new UpdateAccessMaskModel();
ko.applyBindings(model, document.getElementById("masksec"));

model.Load();
