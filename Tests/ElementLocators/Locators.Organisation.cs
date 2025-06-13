using System;
using System.Collections.Generic;
using System.Text;

namespace SquarebookAutomation.Tests.ElementLocators
{
    public partial class Locators : Configurations
    {
        protected const string LOCATOR_NAME_FIELD = "//input[@id='name']";
        protected const string LOCATOR_DESCRIPTION_FIELD = "//textarea[@placeholder='Enter description']";
        protected const string LOCATOR_ORGANISATIONTYPE_DROPDOWN = "//span[@class='select2-selection__rendered']";
        protected const string LOCATOR_ORGANISATIONSAVE_BUTTON = "//button[text()='Save']";
        protected const string LOCATOR_ORGANISATIONREVIEWANDSAVE_BUTTON = "//button[contains(text(),'Review')]";
        protected const string LOCATOR_ORGANISATIONCANCEL_BUTTON = "//button[text()='Cancel']";
        protected const string LOCATOR_ORGANISATIONPROFILE_TAB = "//h6[contains(text(),'profile')]";

        //Investor Profile
        protected const string LOCATOR_INVESTORPROFILE_SUMMARY_FIELD = "//textarea[@placeholder='Enter summary']";
        protected const string LOCATOR_INVESTORPROFILE_ADDSIXMONTHS_LINK = "//div[contains(text(),'Add 6 months')]";
        protected const string LOCATOR_INVESTORPROFILE_ADDTWELVEMONTHS_LINK = "//div[contains(text(),'Add 12 months')]";


        //Advisor Profile
        protected const string LOCATOR_SELECTLICENCES_DROPDOWN = "//span[text()='Select licences']//following::ul[@class='select2-selection__rendered']";

    }
}
