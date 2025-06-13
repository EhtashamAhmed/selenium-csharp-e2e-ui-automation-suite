using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SquarebookAutomation.Tests.Licence
{
    public class LicenceComposeBase : Base
    {
        /// <summary>
        /// Common method to create a Licence
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="wait"></param>
        protected static void CreateALicence(WebDriverWait wait, string lincenceTitle, string jurisdictionTitle, string capabilityTitle)
        {
            AddDataToField(wait, LOCATOR_LICENCE_NAME_FIELD, lincenceTitle);
            ClickOnDropDown(wait, LOCATOR_LICENCEJURISDICTIONS_DROPDOWN);
            SelectFromDropDown(wait, jurisdictionTitle);
            ClickOnDropDown(wait, LOCATOR_LICENCECAPABILITIES_DROPDOWN);
            SelectFromDropDown(wait, capabilityTitle);
            ClickOnButton(wait, LOCATOR_LICENCE_SAVE_BTN);
        }
        /// <summary>
        /// Common method to navigate to the Licence management
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="wait"></param>
        protected static void NavigateToLicenceManagement(IWebDriver driver, WebDriverWait wait)
        {
            ScrollToElement(driver, wait, LOCATOR_COMPANYMANAGEMENT_LINK);
            ClickOnNavBarLink(wait, LOCATOR_COMPANYMANAGEMENT_LINK);
            Thread.Sleep(5000);
            ScrollToElement(driver, wait, LOCATOR_USERMANAGEMENT_LINK);
            Thread.Sleep(5000);
            ClickOnNavBarLink(wait, LOCATOR_LICENCES_SUBLINK);
        }
    }
}
