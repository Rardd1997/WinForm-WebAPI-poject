/// <reference path="~/scripts/common.js" />

var UpdateForumModel = function () {
	var self = this;

	self.Board = new Board(boardId, self);
	self.CreateCategoryModal = new CreateModal(self);
	self.CreateAccessMaskModal = new CreateAccessMaskModal(self);
	self.Loaded = ko.observable(false);

	self.NoStatus = ko.observable(true);
	self.Success = ko.observable(false);
	self.Error = ko.observable(false);
	self.StatusHeading = ko.observable("");
	self.StatusBody = ko.observable("");
	self.AddHidden = ko.observable(true);
	self.AddMaskHidden = ko.observable(true);

	self.ShowAddMask = function (data, event) {
		self.AddMaskHidden(false);
	};

	self.HideAddMask = function (data, event) {
		self.AddMaskHidden(true);
	};

	self.ShowAdd = function (data, event) {
		self.AddHidden(false);
	};

	self.HideAdd = function (data, event) {
		self.AddHidden(true);
	};

	self.Load = function () {
		self.Board.Load();
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
		document.getElementById("boardsec").scrollIntoView();
	};
};

var Board = function (id, model) {
	var self = this;

	self.ViewModel = model;
	self.Id = id;
	self.Name = ko.observable("").extend({ required: { message: GetLocalizedText("MVCForum.Web.ViewModels.Board.NameRequired") }, minLength: 1 });
	self.Description = ko.observable("");

	self.Categories = ko.observableArray([]);
	self.AccessMasks = ko.observableArray([]);

	self.Loaded = ko.observable(false);
	self.CategoriesLoaded = ko.observable(false);
	self.AccessMasksLoaded = ko.observable(false);

	self.Errors = ko.validation.group(self);

	self.Updating = ko.observable(false);
	self.ButtonText = ko.computed(function () {
		return (self.Updating() ? GetLocalizedText("MVCForum.ForumAdmin.Forum.Index.Updating") : GetLocalizedText("MVCForum.ForumAdmin.Forum.Index.UpdateMasks"));
	});

	self.Load = function () {
		jQuery.ajax({ url: readUrl }).done(self.DataReturned).fail(function (request, error) { console.log(error); });
		self.LoadCategories();
		self.LoadAccessMasks();
	};

	self.LoadCategories = function () {
		jQuery.ajax({ url: categoriesUrl }).done(self.CategoriesReturned).fail(function (request, error) { console.log(error); });
	};

	self.LoadAccessMasks = function () {
		jQuery.ajax({ url: accessMasksUrl }).done(self.AccessMasksReturned).fail(function (request, error) { console.log(error); });
	};

	self.DataReturned = function (data) {
		self.Id = data.Id;
		self.Name(data.Name);
		self.Description(data.Description);
		self.Loaded(true);
	};

	self.CategoriesReturned = function (data) {
		self.Categories.removeAll();
		ko.utils.arrayForEach(data.Categories, function (item) {
			self.Categories.push(new Category(item.Id, item.Name, item.SortOrder, self));
		});
		self.CategoriesLoaded(true);
	};

	self.AccessMasksReturned = function (data) {
		self.AccessMasks.removeAll();
		ko.utils.arrayForEach(data.AccessMasks, function (item) {
			self.AccessMasks.push(new AccessMask(item.Id, item.Name, item.AccessFlag, self));
		});
		self.AccessMasksLoaded(true);
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
				jQuery.ajax({ dataType: "json", type: "POST", url: updateUrl, data: { mode: "json", Id: self.Id, Name: self.Name(), Description: self.Description()} }).done(self.SubmitDone).fail(self.ErrorOccured);
			}
		}
	};

	self.DeleteCategory = function (category) {
		self.Categories.remove(category);
	};

	self.DeleteAccessMask = function (mask) {
		self.AccessMasks.remove(mask);
	};

	self.SubmitDone = function (data) {
		self.ViewModel.ShowSuccess(GetLocalizedText("MVCForum.ForumAdmin.Board.Index.SuccessHeading"), GetLocalizedText("MVCForum.ForumAdmin.Board.Index.SuccessBody"));
		self.Updating(false);
	};

	self.ErrorOccured = function (response, status, error) {
		self.ViewModel.ShowFailure(GetLocalizedText("MVCForum.ForumAdmin.Board.Index.FailureHeading"), GetLocalizedText("MVCForum.ForumAdmin.Board.Index.FailureBody").format(response.statusText));
	};
};

var AccessMask = function (id, name, flag, parent) {
	var self = this;

	self.Id = id;
	self.Name = name;
	self.AccessFlag = flag;
	self.Parent = parent;

	self.Delete = function (data, event) {
		confirmModel.Show(GetLocalizedText("MVCForum.ForumAdmin.Board.Index.ConfirmDeleteMaskHeading"), GetLocalizedText("MVCForum.ForumAdmin.Board.Index.ConfirmDeleteMaskBody").format(self.Name), self.DeleteSelf);
	};

	self.DeleteSelf = function () {
		jQuery.ajax({ dataType: "json", type: "POST", url: deleteMaskUrl, data: { mode: "json", Id: self.Id} }).done(self.Deleted).fail(self.ErrorOccured);
	};

	self.Deleted = function (data) {
		self.Parent.DeleteAccessMask(self);
	};

	self.ErrorOccured = function (response, status, error) {
		self.Parent.ViewModel.ShowFailure(GetLocalizedText("MVCForum.ForumAdmin.Board.Index.DeleteMaskFailureHeading"), GetLocalizedText("MVCForum.ForumAdmin.Board.Index.DeleteMaskFailureBody").format(response.statusText));
	};
};

var Category = function (id, name, sortOrder, parent) {
	var self = this;

	self.Id = id;
	self.Name = name;
	self.SortOrder = sortOrder;
	self.Parent = parent;

	self.Delete = function (data, event) {
		confirmModel.Show(GetLocalizedText("MVCForum.ForumAdmin.Board.Index.ConfirmDeleteHeading"), GetLocalizedText("MVCForum.ForumAdmin.Board.Index.ConfirmDeleteBody").format(self.Name), self.DeleteSelf);
	};

	self.DeleteSelf = function () {
		jQuery.ajax({ dataType: "json", type: "POST", url: deleteUrl, data: { mode: "json", Id: self.Id} }).done(self.Deleted).fail(self.ErrorOccured);
	};

	self.Deleted = function (data) {
		self.Parent.DeleteCategory(self);
	};

	self.ErrorOccured = function (response, status, error) {
		self.Parent.ViewModel.ShowFailure(GetLocalizedText("MVCForum.ForumAdmin.Board.Index.DeleteFailureHeading"), GetLocalizedText("MVCForum.ForumAdmin.Board.Index.DeleteFailureBody").format(response.statusText));
	};
}

var CreateAccessMaskModal = function (model) {
	var self = this;

	self.ViewModel = model;

	self.Name = ko.observable("").extend({ required: { message: GetLocalizedText("MVCForum.Web.ViewModels.AccessMask.NameRequired") }, minLength: 1 });
	self.AccessFlag = ko.observableArray([]);

	self.Errors = ko.validation.group(self);

	self.Create = function (data, event) {
		if (self.Errors().length > 0) {
			// Something failed, let's show all the errors!
			self.Errors.showAllMessages();
		}
		else {
			// Everything looks okay, let's submit and let the server handle further validation!
			jQuery.ajax({ dataType: "json", type: "POST", url: createMaskUrl, data: { mode: "json", BoardId: boardId, Name: self.Name(), AccessFlag: self.AccessFlag().length == 0 ? "None" : self.AccessFlag().join(",")} }).done(self.SubmitDone).fail(self.ErrorOccured);
		}
	};

	self.SubmitDone = function (data) {
		self.ViewModel.ShowSuccess(GetLocalizedText("MVCForum.ForumAdmin.Board.Index.CreateMaskSuccessHeading"), GetLocalizedText("MVCForum.ForumAdmin.Board.Index.CreateMaskSuccessBody"));
		self.ViewModel.HideAddMask();
		self.ViewModel.Board.LoadAccessMasks();

		self.Name("");
	};

	self.ErrorOccured = function (response, status, error) {
		self.ViewModel.ShowFailure(GetLocalizedText("MVCForum.ForumAdmin.Board.Index.MaskFailureHeading"), GetLocalizedText("MVCForum.ForumAdmin.Board.Index.MaskFailureBody").format(response.statusText));
	};
};

var CreateModal = function (model) {
	var self = this;

	self.ViewModel = model;

	self.Name = ko.observable("").extend({ required: { message: GetLocalizedText("MVCForum.Web.ViewModels.Category.NameRequired") }, minLength: 1 });
	self.SortOrder = ko.observable(0).extend({ required: { message: GetLocalizedText("MVCForum.Web.ViewModels.Category.SortOrderRequired") }, integer: { message: GetLocalizedText("MVCForum.Web.ViewModels.Forum.SortOrderInteger")} });

	self.Errors = ko.validation.group(self);

	self.Create = function (data, event) {
		if (self.Errors().length > 0) {
			// Something failed, let's show all the errors!
			self.Errors.showAllMessages();
		}
		else {
			// Everything looks okay, let's submit and let the server handle further validation!
			jQuery.ajax({ dataType: "json", type: "POST", url: createUrl, data: { mode: "json", BoardId: boardId, Name: self.Name(), SortOrder: self.SortOrder() } }).done(self.SubmitDone).fail(self.ErrorOccured);
		}
	};

	self.SubmitDone = function (data) {
		self.ViewModel.ShowSuccess(GetLocalizedText("MVCForum.ForumAdmin.Board.Index.CreateSuccessHeading"), GetLocalizedText("MVCForum.ForumAdmin.Board.Index.CreateSuccessBody"));
		self.ViewModel.HideAdd();
		self.ViewModel.Board.LoadCategories();

		self.Name("");
		self.SortOrder(0);
	};

	self.ErrorOccured = function (response, status, error) {
		self.ViewModel.ShowFailure(GetLocalizedText("MVCForum.ForumAdmin.Board.Index.CategoryFailureHeading"), GetLocalizedText("MVCForum.ForumAdmin.Board.Index.CategoryFailureBody").format(response.statusText));
	};
};

var model = new UpdateForumModel();
ko.applyBindings(model, document.getElementById("boardsec"));

model.Load();
