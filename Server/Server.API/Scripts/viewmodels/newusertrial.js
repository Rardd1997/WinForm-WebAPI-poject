/// <reference path="~/scripts/common.js" />

var NewUserTrialConfiguration = function (async, ena) {
	var self = this;

	self.RunAsynchronously = ko.observable(async);
	self.Enabled = ko.observable(ena);
};

var model = new NewUserTrialConfiguration(runAsync, enabled);
ko.applyBindings(model, document.getElementById("newusertrial"));
