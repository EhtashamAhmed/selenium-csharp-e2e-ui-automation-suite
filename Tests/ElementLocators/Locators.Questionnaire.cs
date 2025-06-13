using System;
using System.Collections.Generic;
using System.Text;

namespace SquarebookAutomation.Tests.ElementLocators
{
    public partial class Locators : Configurations
    {
        protected const string LOCATOR_QUESTIONNAIRETITLE_FIELD = "//input[@placeholder = 'Enter questionnaire title']";
        protected const string LOCATOR_FORM_DROPDOWN = "//span[text()='Form']//following::span[@class='select2-selection__rendered'][1]";
        protected const string LOCATOR_FORMTYPE_DROPDOWN = "//span[text()='Type']//following::span[@class='select2-selection__rendered'][1]";
        protected const string LOCATOR_QUESTIONNAIRECOMPANY_DROPDOWN = "//span[text()='Company']//following::span[@class='select2-selection__rendered'][1]";
        protected const string LOCATOR_QUESTIONNAIREOFFER_DROPDOWN = "//span[text()='Offer']//following::span[@class='select2-selection__rendered'][1]";
        protected const string LOCATOR_QUESTIONNAIREROADSHOWS_DROPDOWN = "//span[text()='Roadshows']//following::span[@class='select2-selection__rendered'][1]";
        protected const string LOCATOR_ATTENDEE_MULTISELECT = "(//span[text()='Attendee'])[last()]//following::span[@class='select2-selection select2-selection--multiple'][1]";
        protected const string LOCATOR_QUESTIONNAIRECREATIONDATE_FIELD = "//span[text()='Creation date']//following::input[@title='Select a date'][1]";
        protected const string LOCATOR_QUESTIONNAIRECREATIONTIME_FIELD = "//span[text()='Creation date']//following::input[@title='select a time'][1]";
        protected const string LOCATOR_QUESTIONNAIRESTARTINGDATE_FIELD = "//span[text()='Starting date']//following::input[@title='Select a date'][1]";
        protected const string LOCATOR_QUESTIONNAIRESTARTINGTIME_FIELD = "//span[text()='Starting date']//following::input[@title='select a time'][1]";
        protected const string LOCATOR_QUESTIONNAIREENDINGDATE_FIELD = "//span[text()='Ending date']//following::input[@title='Select a date'][1]";
        protected const string LOCATOR_QUESTIONNAIREENDINGTIME_FIELD = "//span[text()='Ending date']//following::input[@title='select a time'][1]";
        protected const string LOCATOR_QUESTIONNAIRESTATUS_DROPDOWN = "//span[text()='Status']//following::span[@class='select2-selection__rendered'][1]";
        protected const string LOCATOR_QUESTIONNAIRESTATE_DROPDOWN = "//span[text()='State']//following::span[@class='select2-selection__rendered'][1]";
        protected const string LOCATOR_EMAILMESSAGE_DROPDOWN = "//span[text()='Email type']//following::span[@class='select2-selection__rendered'][1]";
        protected const string LOCATOR_EMAILMESSAGE_FIELD = "//textarea[@placeholder='Enter the email message']";
        protected const string LOCATOR_QUESTIONNAIRESAVE_BUTTON = "//button[text()='Save' and @title='Save questionnaire']";
        protected const string LOCATOR_QUESTIONNAIRECANCEL_BUTTON = "//button[text()='Cancel' and @title='Go back']";
    }
}
