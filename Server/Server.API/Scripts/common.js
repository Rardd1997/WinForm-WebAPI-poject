/// <reference path="~/scripts/knockout.validation.js" />
/// <reference path="~/scripts/boostrap-collapse.js" />

var guidEmpty = '00000000-0000-0000-0000-000000000000';

Date.prototype.unixTime = function () {
	return Math.round(this.getTime() / 1000);
};

String.prototype.endsWith = function (input) {
	return input.length > 0 && this.length >= input.length && this.substr(this.length - input.length, input.length) == input;
};

String.prototype.format = function (p0, p1, p2, p3, p4, p5) {
	var output = this;
	if (p0) {
		output = output.replace("{0}", p0 + "");
	}
	if (p1) {
		output = output.replace("{1}", p1 + "");
	}
	if (p2) {
		output = output.replace("{2}", p2 + "");
	}
	if (p3) {
		output = output.replace("{3}", p3 + "");
	}
	if (p4) {
		output = output.replace("{4}", p4 + "");
	}
	if (p5) {
		output = output.replace("{5}", p5 + "");
	}

	return output;
};

//$(document).scroll(function () {
//	// If has not activated (has no attribute "data-top"
//	if (!$('.subnav').attr('data-top')) {
//		// If already fixed, then do nothing
//		if ($('.subnav').hasClass('subnav-fixed')) return;
//		// Remember top position
//		var offset = $('.subnav').offset()
//		$('.subnav').attr('data-top', offset.top);
//	}

//	if ($('.subnav').attr('data-top') - $('.subnav').outerHeight() <= $(this).scrollTop())
//		$('.subnav').addClass('subnav-fixed');
//	else
//		$('.subnav').removeClass('subnav-fixed');
//});

ko.validation.configure({
	registerExtenders: true,
	messagesOnModified: false,
	insertMessages: true,
	parseInputAttributes: false,
	messageTemplate: "customMessageTemplate"
});


var ConfirmModal = function () {
	var self = this;

	self.Hidden = ko.observable(true);
	self.Heading = ko.observable("");
	self.Body = ko.observable("");

	self.ConfirmCallback = null;
	self.CancelCallback = null;

	self.Confirm = function (data, event) {
		self.Hidden(true);
		if (self.ConfirmCallback) {
			self.ConfirmCallback();
		}
	};

	self.Cancel = function (data, event) {
		self.Hidden(true);
		if (self.CancelCallback) {
			self.CancelCallback();
		}
	};

	self.Close = function (data, event) {
		self.Hidden(true);
	};

	self.Show = function (heading, body, confirmCallback, cancelCallback) {
		self.Heading(heading);
		self.Body(body);
		self.Hidden(false);

		self.ConfirmCallback = confirmCallback;
		self.CancelCallback = cancelCallback;
	};
};

if (document.getElementById("confirm")) {
	var confirmModel = new ConfirmModal();
	ko.applyBindings(confirmModel, document.getElementById("confirm"));
}