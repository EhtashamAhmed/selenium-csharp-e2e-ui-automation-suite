using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SquarebookAutomation.Tests.Organisation
{
    public partial class OrganisationBase : Base
    {
        private static string OrganisationName = "";

        /// <summary>
        /// Generic method for creating an organisation
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="wait"></param>
        /// <param name="OrganisationType">Type of the organisation</param>
        protected static void CreateAnOrganisation(WebDriverWait wait, string OrganisationType)
        {
            if (OrganisationType == "Admin")
            {
                OrganisationName = $"{ADMIN_ORG_NAME} {Uniqueness}";
            }
            else if (OrganisationType == "Advisor")
            {
                OrganisationName = $"{ADVISOR_ORG_NAME} {Uniqueness}";
            }
            else if (OrganisationType == "Advocate")
            {
                OrganisationName = $"{ADVOCATE_ORG_NAME} {Uniqueness}";
            }
            else if (OrganisationType == "Institutional investor")
            {
                OrganisationName = $"{INSTITUTIONAL_INVESTOR_ORG_NAME} {Uniqueness}";
            }
            else if (OrganisationType == "Issuer")
            {
                OrganisationName = $"{ISSUER_ORG_NAME} {Uniqueness}";
            }
            else if (OrganisationType == "Private investor")
            {
                OrganisationName = $"{PRIVATE_INVESTOR_ORG_NAME} {Uniqueness}";
            }
            ClickOnNavBarLink(wait, LOCATOR_COMPANYMANAGEMENT_LINK);
            ClickOnNavBarLink(wait, LOCATOR_ORGANIZATIONS_LINK);
            //SearchInDataGrid(driver,wait, OrganizationName);
            //IWebElement SearchResultObject = ReturnIWebElementObject(driver,wait, Locators.TABLESEARCH_DATA);
            //if(SearchResultObject.Text== "No records to display.")
            //{
            ClickOnAddButton(wait);
            AddDataToField(wait, LOCATOR_NAME_FIELD, OrganisationName);
            ClickOnDropDown(wait, LOCATOR_ORGANISATIONTYPE_DROPDOWN);
            SelectFromDropDown(wait, OrganisationType);
            if (OrganisationType == "Institutional investor" | OrganisationType == "Private investor")
            {
                ClickOnButton(wait, LOCATOR_ORGANISATIONREVIEWANDSAVE_BUTTON);
                ClickOnButton(wait, LOCATOR_ORGANISATIONPROFILE_TAB);
                Thread.Sleep(5000);
                AddDataToField(wait, LOCATOR_INVESTORPROFILE_SUMMARY_FIELD,  COMPANY_SIMPLE_TEXT_DESCRIPTION);
                ClickOnButton(wait, LOCATOR_INVESTORPROFILE_ADDTWELVEMONTHS_LINK);                
            }
            if (OrganisationType == "Advisor")
            {                
                ClickOnButton(wait, LOCATOR_ORGANISATIONPROFILE_TAB);
                ClickOnDropDown(wait, LOCATOR_SELECTLICENCES_DROPDOWN);
                SelectFromDropDown(wait, $"Licence {Uniqueness}");
            }
            ClickOnButton(wait, LOCATOR_ORGANISATIONSAVE_BUTTON);
            Thread.Sleep(3000);
            //}
        }
    }
}
