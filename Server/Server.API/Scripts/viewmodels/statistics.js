/// <reference path="~/scripts/common.js" />

var StatisticsViewModel = function () {
	var self = this;

	self.Statistics = new Statistics();
	self.Boards = ko.observableArray([]);
	self.CreateBoardModal = new CreateModal(self);
	self.Loaded = ko.observable(false);

	self.Headlines = ko.observableArray([]);
	self.HeadlinesLoaded = ko.observable(false);

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

	self.Load = function () {
		self.Statistics.Load();
		self.LoadBoards();
		self.LoadHeadlines();
	};

	self.LoadHeadlines = function () {
		jQuery.ajax({ url: headlinesUrl }).done(self.HeadlinesReturned).fail(function (request, error) { console.log(error); });
	};

	self.HeadlinesReturned = function (data) {
		self.Headlines.removeAll();
		if (data.Topics) {
			ko.utils.arrayForEach(data.Topics, function (item) {
				self.Headlines.push(new Headline(item.Title, new Date(item.Posted), item.Url, item.Author));
			});
			self.HeadlinesLoaded(true);
		} 
	};

	self.LoadBoards = function () {
		jQuery.ajax({ url: boardListUrl }).done(self.DataReturned).fail(function (request, error) { console.log(error); });
	};

	self.DataReturned = function (data) {
		self.Boards.removeAll();
		ko.utils.arrayForEach(data.Boards, function (item) {
			self.Boards.push(new Board(item.Id, item.Name, self));
		});
		self.Loaded(true);
	};

	self.DeleteBoard = function (board) {
		self.Boards.remove(board);
	};
};

var Headline = function (heading, datestamp, url, author) {
	var self = this;

	self.Heading = heading;
	self.PublishDate = datestamp;
	self.Url = "http://mvcforum.org" + url;
	self.Author = author;

	self.Datestamp = ko.computed(function () {
		return self.PublishDate.toLocaleDateString();
	});
};

var Board = function (id, name, parent) {
	var self = this;

	self.Parent = parent;
	self.Id = id;
	self.Name = ko.observable(name);

	self.Delete = function (data, event) {
		confirmModel.Show(GetLocalizedText("MVCForum.ForumAdmin.Home.Index.ConfirmDeleteHeading"), GetLocalizedText("MVCForum.ForumAdmin.Home.Index.ConfirmDeleteBody").format(self.Name()), self.DeleteSelf);
	};

	self.DeleteSelf = function () {
		jQuery.ajax({ dataType: "json", type: "POST", url: deleteUrl, data: { mode: "json", Id: self.Id} }).done(self.Deleted).fail(self.ErrorOccured);
	};

	self.Deleted = function (data) {
		self.Parent.DeleteBoard(self);
	};

	self.ErrorOccured = function (response, status, error) {
		self.Parent.ShowFailure(GetLocalizedText("MVCForum.ForumAdmin.Home.Index.DeleteFailureHeading"), GetLocalizedText("MVCForum.ForumAdmin.Home.Index.DeleteFailureBody").format(response.statusText));
	};
}

var Statistics = function () {
	var self = this;

	self.NumberOfPosts = ko.observable("");
	self.NumberOfTopics = ko.observable("");
	self.NumberOfUsers = ko.observable("");
	self.NumberOfAttachments = ko.observable("");
	self.InstallDate = ko.observable(new Date());
	self.AttachmentsSize = ko.observable("");
	self.Version = ko.observable("");
	self.Days = ko.observable(1);
	self.Loaded = ko.observable(false);
	self.AttachmentsPerDay = ko.observable(0);
	self.PostsPerDay = ko.observable(0);
	self.TopicsPerDay = ko.observable(0);
	self.UsersPerDay = ko.observable(0);

	self.Calculate = function () {
		self.AttachmentsPerDay(self.NumberOfAttachments() / self.Days());
		self.PostsPerDay(self.NumberOfPosts() / self.Days());
		self.TopicsPerDay(self.NumberOfTopics() / self.Days());
		self.UsersPerDay(self.NumberOfUsers() / self.Days());
	};

	self.BoardStart = ko.computed(function () {
		return self.InstallDate().toDateString()
	});

	self.Load = function () {
		jQuery.ajax({ url: statisticsUrl }).done(self.DataReturned).fail(function (request, error) { console.log(error); });
	};

	self.DataReturned = function (data) {
		self.NumberOfPosts(data.PostCount);
		self.NumberOfTopics(data.TopicCount);
		self.NumberOfAttachments(data.AttachmentCount);
		self.NumberOfUsers(data.UserCount);
		self.InstallDate(new Date(data.InstallDate));
		self.Version(data.Version);
		self.AttachmentsSize(data.AttachmentSize);
		self.Days(data.Days >= 1 ? data.Days : 1);
		self.Calculate();
		self.Loaded(true);
	};
};

var CreateModal = function (model) {
	var self = this;

	self.ViewModel = model;

	self.Id = 0;
	self.CategoryId = 0;
	self.Name = ko.observable("").extend({ required: { message: GetLocalizedText("MVCForum.Web.ViewModels.Board.NameRequired") }, minLength: 1 });
	self.Description = ko.observable("");

	self.Errors = ko.validation.group(self);

	self.Create = function (data, event) {
		if (self.Errors().length > 0) {
			// Something failed, let's show all the errors!
			self.Errors.showAllMessages();
		}
		else {
			// Everything looks okay, let's submit and let the server handle further validation!
			jQuery.ajax({ dataType: "json", type: "POST", url: createUrl, data: { mode: "json", Name: self.Name(), Description: self.Description()} }).done(self.SubmitDone).fail(self.ErrorOccured);
		}
	};

	self.SubmitDone = function (data) {
		self.ViewModel.ShowSuccess(GetLocalizedText("MVCForum.ForumAdmin.Home.Index.CreateSuccessHeading"), GetLocalizedText("MVCForum.ForumAdmin.Home.Index.CreateSuccessBody"));
		self.ViewModel.HideAdd();
		self.ViewModel.LoadBoards();

		self.Name("");
		self.SiteName("");
	};

	self.ErrorOccured = function (response, status, error) {
		self.ViewModel.ShowFailure(GetLocalizedText("MVCForum.ForumAdmin.Home.Index.CreateFailureHeading"), GetLocalizedText("MVCForum.ForumAdmin.Home.Index.CreateFailureBody").format(response.statusText));
	};
};

var model = new StatisticsViewModel();
ko.applyBindings(model, document.getElementById("stats"));

model.Load();
