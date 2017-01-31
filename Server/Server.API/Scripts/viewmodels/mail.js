/// <reference path="~/scripts/common.js" />

var TestMailModel = function () {
	var self = this;

	self.Recipient = ko.observable("");
	self.Status = ko.observable("");
	self.Show = ko.observable(false);

	self.Send = function (data, event) {
		jQuery.ajax({ dataType: "json", type: "POST", url: sendUrl, data: { mode: "json", recipient: self.Recipient() } }).done(self.Done).fail(self.ErrorOccured);
	};

	self.Done = function (data) {
		if (data != null) {

		}
		else {
			self.Status(GetLocalizedText("MVCForum.Web.ViewModels.MailViewModel.Success"));
			self.Show(true);
		}
	};

	self.ErrorOccured = function (response, status, error) {
		self.Status(error);
		self.Show(true);
	};
};

var model = new TestMailModel();
ko.applyBindings(model, document.getElementById("mail"));
