/// <reference path="~/scripts/common.js" />

var MultiPostConfiguration = function (async, ena) {
	var self = this;

	self.RunAsynchronously = ko.observable(async);
	self.Enabled = ko.observable(ena);
};

var model = new MultiPostConfiguration(runAsync, enabled);
ko.applyBindings(model, document.getElementById("multipost"));
