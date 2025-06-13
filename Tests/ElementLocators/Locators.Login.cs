using System;
using System.Collections.Generic;
using System.Text;

namespace SquarebookAutomation.Tests.ElementLocators
{
    public partial class Locators : Configurations
    {
        protected const string LOCATOR_ACCEPTCONSENT_BUTTON = "//button[@id='acceptConsent']";
        protected const string LOCATOR_DENYCONSENT_BUTTON = "//a[text()='I do not accept']";
        protected const string LOCATOR_LOGINEMAIL_FIELD = "//input[@id='Name']";
        protected const string LOCATOR_LOGINPASSWORD_FIELD = "//input[@id='Password']";
        protected const string LOCATOR_LOGIN_BUTTON = "//button[@id='submitButton']";
        protected const string LOCATOR_FORGOTPASSWORD_LINK = "//a[@id='kt_login_forgot']";
        protected const string LOCATOR_ALERTBOX = "//div[@id='alertbox']";
        protected const string LOCATOR_RESETPASSWORD_MESSAGE = "×\r\nIf the provided email address is correct, you will receive an email with instructions to follow. Check your Inbox (or junk/spam) folder for the email.";
        protected const string LOCATOR_REGISTRATIONCOMPLETE_MESSAGE = "×\r\nRegistration completed successfully";
    }
}
