/// <reference path="~/scripts/common.js" />

var UpdateCategoryModel = function () {
	var self = this;

	self.Category = new Category(categoryId, self);
	self.CreateForumModal = new CreateModal(self);
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
		self.Category.Load();
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
		document.getElementById("categorysec").scrollIntoView();
	};
};

var Category = function (id, model) {
	var self = this;

	self.ViewModel = model;

	self.Id = id;
	self.Name = ko.observable("").extend({ required: { message: GetLocalizedText("MVCForum.Web.ViewModels.Category.NameRequired") }, minLength: 1 });
	self.SortOrder = ko.observable(0).extend({ required: { message: GetLocalizedText("MVCForum.Web.ViewModels.Category.SortOrderRequired") }, integer: { message: GetLocalizedText("MVCForum.Web.ViewModels.Category.SortOrderInteger")} });

	self.Forums = ko.observableArray([]);

	self.Loaded = ko.observable(false);
	self.ForumsLoaded = ko.observable(false);

	self.Errors = ko.validation.group(self);

	self.Updating = ko.observable(false);
	self.ButtonText = ko.computed(function () {
		return (self.Updating() ? GetLocalizedText("MVCForum.ForumAdmin.Forum.Index.Updating") : GetLocalizedText("MVCForum.ForumAdmin.Forum.Index.UpdateMasks"));
	});

	self.Load = function () {
		jQuery.ajax({ url: readUrl }).done(self.DataReturned).fail(function (request, error) { console.log(error); });
		self.LoadForums();
	};

	self.LoadForums = function () {
		jQuery.ajax({ url: forumsUrl }).done(self.ForumsReturned).fail(function (request, error) { console.log(error); });
	};

	self.DeleteForum = function (forum) {
		self.Forums.remove(forum);
	};

	self.DataReturned = function (data) {
		self.Id = data.Id;
		self.Name(data.Name);
		self.SortOrder(data.SortOrder);
		self.Loaded(true);
	};

	self.ForumsReturned = function (data) {
		self.Forums.removeAll();
		ko.utils.arrayForEach(data.Forums, function (item) {
			self.Forums.push(new Forum(item.Id, item.Name, item.SortOrder, self));
		});
		self.ForumsLoaded(true);
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
				jQuery.ajax({ dataType: "json", type: "POST", url: updateUrl, data: { mode: "json", Id: self.Id, Name: self.Name(), SortOrder: self.SortOrder()} }).done(self.SubmitDone).fail(self.ErrorOccured);
			}
		}
	};

	self.SubmitDone = function (data) {
		self.ViewModel.ShowSuccess(GetLocalizedText("MVCForum.ForumAdmin.Category.Index.SuccessHeading"), GetLocalizedText("MVCForum.ForumAdmin.Category.Index.SuccessBody"));
		self.Updating(false);
	};
};

var Forum = function (id, name, sortOrder, parent) {
	var self = this;

	self.Id = id;
	self.Name = name;
	self.SortOrder = sortOrder;
	self.Parent = parent;

	self.Delete = function (data, event) {
		confirmModel.Show(GetLocalizedText("MVCForum.ForumAdmin.Category.Index.ConfirmDeleteHeading"), GetLocalizedText("MVCForum.ForumAdmin.Category.Index.ConfirmDeleteBody").format(self.Name), self.DeleteSelf);
	};

	self.DeleteSelf = function () {
		jQuery.ajax({ dataType: "json", type: "POST", url: deleteUrl, data: { mode: "json", Id: self.Id, deleteAll: true } }).done(self.Deleted).fail(self.ErrorOccured);
	};

	self.Deleted = function (data) {
		self.Parent.DeleteForum(self);
	};

	self.ErrorOccured = function (response, status, error) {
		self.Parent.ViewModel.ShowFailure(GetLocalizedText("MVCForum.ForumAdmin.Category.Index.DeleteFailureHeading"), GetLocalizedText("MVCForum.ForumAdmin.Category.Index.DeleteFailureBody").format(response.statusText));
	};
}

var CreateModal = function (model) {
	var self = this;

	self.ViewModel = model;

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
			jQuery.ajax({ dataType: "json", type: "POST", url: createUrl, data: { mode: "json", Name: self.Name(), Description: self.Description(), SortOrder: self.SortOrder(), CategoryId: categoryId } }).done(self.SubmitDone).fail(self.ErrorOccured);
		}
	};

	self.SubmitDone = function (data) {
		self.ViewModel.ShowSuccess(GetLocalizedText("MVCForum.ForumAdmin.Category.Index.CreateSuccessHeading"), GetLocalizedText("MVCForum.ForumAdmin.Category.Index.CreateSuccessBody"));
		self.ViewModel.HideAdd();
		self.ViewModel.Category.LoadForums();

		self.Name("");
		self.SortOrder(0);
		self.Description("");
	};

	self.ErrorOccured = function (response, status, error) {
		self.ViewModel.ShowFailure(GetLocalizedText("MVCForum.ForumAdmin.Category.Index.CreateFailureHeading"), GetLocalizedText("MVCForum.ForumAdmin.Category.Index.CreateFailureBody").format(response.statusText));
	};
};

var model = new UpdateCategoryModel();
ko.applyBindings(model, document.getElementById("categorysec"));

model.Load();
