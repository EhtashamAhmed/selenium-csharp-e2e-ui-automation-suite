using System;
using System.Collections.Generic;
using System.Text;

namespace SquarebookAutomation.Tests.ElementLocators
{
    public partial class Locators : Configurations
    {
        //Registration page
        protected const string LOCATOR_REGISTRATIONEMAIL_FIELD = "//input[@placeholder = 'Email']";
        protected const string LOCATOR_REGISTRATIONFIRSTNAME_FIELD = "//input[@placeholder = 'First name']";
        protected const string LOCATOR_REGISTRATIONLASTNAME_FIELD = "//input[@placeholder = 'Last name']";
        protected const string LOCATOR_REGISTRATIONORGANIZATION_FIELD = "//input[@placeholder = 'Email']";
        protected const string LOCATOR_REGISTRATIONMOBILE_FIELD = "//input[@placeholder = 'Mobile']";
        protected const string LOCATOR_REGISTRATIONTELEPHONE_FIELD = "//input[@placeholder = 'Telephone']";
        protected const string LOCATOR_REGISTRATIONINSTINETUSER_CHECKBOX = "//span[text()='Are you an Instinet User?']//following::span[2]";
        protected const string LOCATOR_REGISTRATIONPASSWORD_FIELD = "//input[@placeholder = 'Password']";
        protected const string LOCATOR_REGISTRATIONCONFIRMPASSWORD_FIELD = "//input[@placeholder = 'Confirm password']";
        protected const string LOCATOR_REGISTRATIONNEXT_BUTTON = "//button[text()='Next']";
        //Terms and Conditions page
        protected const string LOCATOR_TERMSANDCONDITIONS_CHECKBOX = "//*[contains(text(),'I have read')]//following::span[1]";
        protected const string LOCATOR_REGISTRATIONGOBACK_BUTTON = "//a[text()='Go Back']";
        protected const string LOCATOR_REGISTRATIONREGISTER_BUTTON = "//button[contains(text(),'Register')]";
        //Interests modal form
        protected const string LOCATOR_REGISTRATIONSAVE_BUTTON = "//button[contains(text(),'Save')]";
        protected const string LOCATOR_REGISTRATIONSKIP_BUTTON = "//button[contains(text(),'Skip')]";
    }
}
