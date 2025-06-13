using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquarebookAutomation.Tests.System.Settings
{
    public partial class SettingsBase : Base
    {
        /// <summary>
        /// Common method to create a Jurisdiction
        /// </summary>
        /// <param name="wait"></param>
        protected static void CreateAJurisdiction(WebDriverWait wait, string jurisdictionTitle)
        {
            ClickOnNavBarLink(wait, LOCATOR_USERPROFILE_LINK);
            ClickOnNavBarLink(wait, LOCATOR_SETTINGS_LINK);
            ClickOnNavBarLink(wait, LOCATOR_SETTINGS_TAB);
            ClickOnNavBarLink(wait, LOCATOR_JURISDICTIONS_SUBTAB);
            AddDataToField(wait, LOCATOR_JURISDICTIONSNAME_FIELD, jurisdictionTitle);
            ClickOnButton(wait, LOCATOR_SYSTEMMANAGEMENTSAVE_BTN);
        }
        /// <summary>
        /// Common method to create a Capability
        /// </summary>
        /// <param name="wait"></param>
        protected static void CreateACapability(WebDriverWait wait, string capabilityTitle)
        {
            ClickOnNavBarLink(wait, LOCATOR_USERPROFILE_LINK);
            ClickOnNavBarLink(wait, LOCATOR_SETTINGS_LINK);
            ClickOnNavBarLink(wait, LOCATOR_SETTINGS_TAB);
            ClickOnNavBarLink(wait, LOCATOR_CAPABILITIES_SUBTAB);
            AddDataToField(wait, LOCATOR_CAPABILITIESNAME_FIELD, capabilityTitle);
            ClickOnButton(wait, LOCATOR_SYSTEMMANAGEMENTSAVE_BTN);
        }
    }
}
