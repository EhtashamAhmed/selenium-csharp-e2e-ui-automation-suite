using System;
using System.Collections.Generic;
using System.Text;

namespace SquarebookAutomation.Tests.ElementLocators
{
    public partial class Locators : Configurations
    {
        protected const string LOCATOR_FORGOTPASSWORD_URL = "https://uat.squarebook.co.uk/forgotpassword";
        protected const string LOCATOR_FORGOTPWEMAIL_FIELD = "//input[@id='Email']";
        protected const string LOCATOR_FORGOTPWREQUEST_BUTTON = "//button[@id='submitButton']";
        protected const string LOCATOR_FORGOTPWGOBACK_LINK = "//a[text()='Go back']";
    }
}
