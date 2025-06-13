using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquarebookAutomation.Tests.ElementLocators
{
    public partial class Locators : Configurations
    {
        protected const string LOCATOR_SETTINGS_TAB = "//h6[text()='Settings']";
        protected const string LOCATOR_CURRENCIES_SUBTAB = "//a[text()='Currencies']";
        protected const string LOCATOR_KNOWNHOLDINGS_SUBTAB = "//a[text()='Known holdings']";
        protected const string LOCATOR_INVESTMENTSTYLES_SUBTAB = "//a[text()='Investment styles']";
        protected const string LOCATOR_SELLSIDE_SUBTAB = "//a[text()='Sell side counter parties']";
        protected const string LOCATOR_CONITNENTSREGIONCOUNTRY_SUBTAB = "//a[text()='Continents, regions and countries']";
        protected const string LOCATOR_CONITNENTS_SUBTAB = "//a[text()='Continents']";
        protected const string LOCATOR_REGIONS_SUBTAB = "//a[text()='Regions']";
        protected const string LOCATOR_COUNTRY_SUBTAB = "//a[text()='Countries']";
        protected const string LOCATOR_SECTORSANDSUBSECTORS_SUBTAB = "//a[text()='Sectors and sub sectors']";
        protected const string LOCATOR_SECTORS_SUBTAB = "//a[text()='Sectors']";
        protected const string LOCATOR_SUBSECTORS_SUBTAB = "//a[text()='Sub sectors']";
        protected const string LOCATOR_JURISDICTIONS_SUBTAB = "//a[text()='Jurisdictions']";
        protected const string LOCATOR_JURISDICTIONSNAME_FIELD = "//input[@placeholder='Enter the jurisdiction name']";

        protected const string LOCATOR_CAPABILITIES_SUBTAB = "//a[text()='Capabilities']";
        protected const string LOCATOR_CAPABILITIESNAME_FIELD = "//input[@placeholder='Enter the capability name']";
        protected const string LOCATOR_CAPABILITIESTYPE_DROPDOWN = "//span[@id='select2-__capabilityType-container']";

        protected const string LOCATOR_SYSTEMMANAGEMENTSAVE_BTN = "//button[text()='Save']";
    }
}
