using System;
using System.Collections.Generic;
using System.Text;

namespace SquarebookAutomation.Tests.ElementLocators
{
    public partial class Locators : Configurations
    {
        protected const string LOCATOR_REFERRALTYPE_DROPDOWN = "(//span[@class='select2-selection__rendered'])[1]";
        protected const string LOCATOR_SIGNUPFIRSTNAME_FIELD = "//input[@id='first-name']";
        protected const string LOCATOR_SIGNUPLASTNAME_FIELD = "//input[@id='last-name']";
        protected const string LOCATOR_SIGNUPEMAIL_FIELD = "//input[@id='email']";
        protected const string LOCATOR_SIGNUPORGANIZATION_DROPDOWN = "(//span[@class='select2-selection__rendered'])[2]";
        protected const string LOCATOR_SIGNUPMOBILE_FIELD = "//input[@id='mobile']";
        protected const string LOCATOR_SIGNUPTELEPHONE_FIELD = "//input[@id='phone']";
        protected const string LOCATOR_SIGNUPSAVE_BUTTON = "//button[text()='Save']";
        protected const string LOCATOR_SIGNUPCANCEL_BUTTON = "//button[text()='Cancel']";
        protected const string LOCATOR_SIGNUPROLE_DROPDOWN = "(//span[@class='select2-selection__rendered'])[4]";
    }
}
