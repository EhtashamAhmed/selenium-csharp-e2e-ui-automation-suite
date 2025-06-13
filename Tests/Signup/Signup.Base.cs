using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SquarebookAutomation.Tests.Signup
{
    public partial class SignupBase : Base
    {
        private static string OrganizationName;
        private static string FirstName;
        private static string LastName;
        private static string Email;
        /// <summary>
        /// Generic method for creating a signup
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="wait"></param>
        /// <param name="OrganizationType">Type of the organisation</param>
        /// <param name="role">Role of the user</param>
        protected static void CreateASignup(IWebDriver driver, WebDriverWait wait, string OrganizationType, string role)
        {
            ClickOnNavBarLink(driver, wait, LOCATOR_USERMANAGEMENT_LINK);
            ClickOnNavBarLink(driver, wait, LOCATOR_SIGNUP_SUBLINK);
            ClickOnAddButton(wait);
            if (OrganizationType == "Admin")
            {
                OrganizationName = $"{ADMIN_ORG_NAME} {Uniqueness}";
                FirstName = ADMIN_FIRST_NAME;
                LastName = ADMIN_LAST_NAME;
                Email = $"{ADMIN_FIRST_NAME}{ADMIN_LAST_NAME}{Uniqueness}@gmail.com";
            }
            else if (OrganizationType == "Advisor")
            {
                OrganizationName = $"{ADVISOR_ORG_NAME} {Uniqueness}";
                FirstName = ADVISOR_FIRST_NAME;
                LastName = ADVISOR_LAST_NAME;
                Email = $"{ADVISOR_FIRST_NAME}{ADVISOR_LAST_NAME}{Uniqueness}@gmail.com";
            }
            else if (OrganizationType == "Advocate")
            {
                OrganizationName = $"{ADVOCATE_ORG_NAME} {Uniqueness}";
                FirstName = ADVOCATE_FIRST_NAME;
                LastName = ADVOCATE_LAST_NAME;
                Email = $"{ADVOCATE_FIRST_NAME}{ADVOCATE_LAST_NAME}{Uniqueness}@gmail.com";
            }
            else if (OrganizationType == "Institutional investor")
            {
                OrganizationName = $"{INSTITUTIONAL_INVESTOR_ORG_NAME} {Uniqueness}";
                FirstName = INST_INVESTOR_FIRST_NAME;
                LastName = INST_INVESTOR_LAST_NAME;
                Email = $"{INST_INVESTOR_FIRST_NAME}{INST_INVESTOR_LAST_NAME}{Uniqueness}@gmail.com";
            }
            else if (OrganizationType == "Issuer")
            {
                OrganizationName = $"{ISSUER_ORG_NAME} {Uniqueness}";
                FirstName = ISSUER_FIRST_NAME;
                LastName = ISSUER_LAST_NAME;
                Email = $"{ISSUER_FIRST_NAME}{ISSUER_LAST_NAME}{Uniqueness}@gmail.com";
            }
            else if (OrganizationType == "Private investor")
            {
                OrganizationName = $"{PRIVATE_INVESTOR_ORG_NAME} {Uniqueness}";
                FirstName = PVT_INVESTOR_FIRST_NAME;
                LastName = PVT_INVESTOR_LAST_NAME;
                Email = $"{PVT_INVESTOR_FIRST_NAME}{PVT_INVESTOR_LAST_NAME}{Uniqueness}@gmail.com";
            }
            AddDataToField(wait, LOCATOR_SIGNUPFIRSTNAME_FIELD, FirstName);
            AddDataToField(wait, LOCATOR_SIGNUPLASTNAME_FIELD, LastName);
            AddDataToField(wait, LOCATOR_SIGNUPEMAIL_FIELD, Email);
            ClickOnDropDown(wait, LOCATOR_SIGNUPORGANIZATION_DROPDOWN);
            SelectFromDropDown(wait, OrganizationName);
            ClickOnDropDown(wait, LOCATOR_SIGNUPROLE_DROPDOWN);
            SelectFromDropDown(wait, role);
            ClickOnButton(wait, LOCATOR_SIGNUPSAVE_BUTTON);
            Thread.Sleep(3000);
        }
    }
}
