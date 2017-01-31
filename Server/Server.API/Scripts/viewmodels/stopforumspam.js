/// <reference path="~/scripts/common.js" />

var StopForumSpamConfiguration = function (async, ena) {
	var self = this;

	self.RunAsynchronously = ko.observable(async);
	self.Enabled = ko.observable(ena);
};

var model = new StopForumSpamConfiguration(runAsync, enabled);
ko.applyBindings(model, document.getElementById("stopforumspam"));
