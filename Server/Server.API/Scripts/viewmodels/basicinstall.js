/// <reference path="~/scripts/common.js" />

var BasicInstallModel = function (canInstallAdmin, canInstallGroups, canInstallSimpleForum) {
	var self = this;

	self.CanInstallAdmin = canInstallAdmin;
	self.CanInstallGroups = canInstallGroups;
	self.CanInstallSimpleForum = canInstallSimpleForum;

	self.InstallAdmin = ko.observable(false);
	self.InstallGroups = ko.observable(false);
	self.InstallForum = ko.observable(false);
	self.ImportUsers = ko.observable(false);

	self.InstallAdmin.subscribe(function (newValue) {
		if (newValue) {
			self.ImportUsers(false);
		}
	});

	self.ImportUsers.subscribe(function (newValue) {
		if (newValue) {
			self.InstallAdmin(false);
		}
	});
};

var model = new BasicInstallModel(canCreateAdmin, canCreateGroups, canCreateSimpleForum);
ko.applyBindings(model, document.getElementById("install"));
