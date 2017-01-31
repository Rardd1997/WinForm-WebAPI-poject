/// <reference path="~/scripts/common.js" />

var UserRegistrationModel = function (useController, allowLocal, allowSignUp, emailValidation, allowOpen, subject, body, rulesAccept, rules, forgottenSubject, forgottenBody) {
	var self = this;

	self.UseForumAccountController = ko.observable(useController);
	self.AllowLocalUsers = ko.observable(allowLocal);
	self.AllowSignUp = ko.observable(allowSignUp);
	self.AllowOpenAuthUsers = ko.observable(allowOpen);
	self.RequireEmailValidation = ko.observable(emailValidation);
	self.ValidationSubject = ko.observable(subject);
	self.ValidationBody = ko.observable(body);
	self.ForgottenPasswordSubject = ko.observable(forgottenSubject);
	self.ForgottenPasswordBody = ko.observable(forgottenBody);
	self.RequireRulesAccept = ko.observable(rulesAccept);
	self.SignUpRules = ko.observable(rules);
};

var model = new UserRegistrationModel(useController, local, signup, emailValidation, openAuth, subject, body, rulesAccept, rules, forgottenSubject, forgottenBody);
ko.applyBindings(model, document.getElementById("userreg"));
