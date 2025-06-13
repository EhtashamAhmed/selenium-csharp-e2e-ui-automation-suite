using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SquarebookAutomation.Tests.UserRegistration
{
    public partial class UserRegistrationBase : Base
    {
        protected static string SingupURLpath = "";

        /// <summary>
        /// Method to complete the registration of a user
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="wait"></param>
        /// <param name="organizationType">Type of the user organisation to take and create its registration</param>
        protected static void CompleteRegistration(IWebDriver driver, WebDriverWait wait, string organizationType)
        {
            ClickOnNavBarLink(wait, LOCATOR_AUDIT_MANAGEMENT_LINK);
            ScrollToElement(driver, wait, LOCATOR_EMAILS_LINK);            
            ClickOnNavBarLink(wait, LOCATOR_EMAILS_LINK);

            SingupURLpath = organizationType == "Admin" ? LOCATOR_ADMIN_REFERRAL_URL :
                organizationType == "Advisor" ? LOCATOR_ADVISOR_REFERRAL_URL :
                organizationType == "Advocate" ? LOCATOR_ADVOCATE_REFERRAL_URL :
                organizationType == "Institutional investor" ? LOCATOR_INSTITUTIONALINV_REFERRAL_URL :
                organizationType == "Issuer" ? LOCATOR_ISSUER_REFERRAL_URL :
                LOCATOR_PVTINV_REFERRAL_URL;

            string signupURL = ReturnURL(wait, SingupURLpath);
            ClickOnButton(wait, LOCATOR_USERPROFILE_LINK);
            ClickOnButton(wait, LOCATOR_LOGOUT_LINK);
            Thread.Sleep(3000);
            driver.Url = signupURL;

            AddDataToField(wait, LOCATOR_REGISTRATIONPASSWORD_FIELD, PASSWORD);
            AddDataToField(wait, LOCATOR_REGISTRATIONCONFIRMPASSWORD_FIELD, PASSWORD);
            ClickOnButton(wait, LOCATOR_REGISTRATIONNEXT_BUTTON);
            ClickOnButton(wait, LOCATOR_TERMSANDCONDITIONS_CHECKBOX);
            ClickOnButton(wait, LOCATOR_REGISTRATIONREGISTER_BUTTON);
            bool isSkipExist = CheckIfElementExists(wait, LOCATOR_REGISTRATIONSKIP_BUTTON);
            if (isSkipExist)
            {
                ClickOnButton(wait, LOCATOR_REGISTRATIONSKIP_BUTTON);
            }
        }
    }
}
