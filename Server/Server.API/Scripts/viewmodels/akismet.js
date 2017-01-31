/// <reference path="~/scripts/common.js" />

var AkismetConfiguration = function (async, ena) {
	var self = this;

	self.RunAsynchronously = ko.observable(async);
	self.Enabled = ko.observable(ena);
};

var model = new AkismetConfiguration(runAsync, enabled);
ko.applyBindings(model, document.getElementById("akismet"));
