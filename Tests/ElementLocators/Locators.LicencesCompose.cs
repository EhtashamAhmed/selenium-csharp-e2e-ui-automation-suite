namespace SquarebookAutomation.Tests.ElementLocators
{
    public partial class Locators : Configurations
    {
        protected const string LOCATOR_LICENCE_NAME_FIELD = "//input[@placeholder='Enter name']";
        protected const string LOCATOR_LICENCEJURISDICTIONS_DROPDOWN = "//span[text()='Jurisdictions']//following::span[@class='select2-selection select2-selection--multiple'][1]";
        protected const string LOCATOR_LICENCECAPABILITIES_DROPDOWN = "//span[text()='Capabilities']//following::span[@class='select2-selection select2-selection--multiple'][1]";
        protected const string LOCATOR_LICENCE_SAVE_BTN = "//button[text()='Save']";
        protected const string LOCATOR_LICENCE_CANCEL_BTN = "//button[text()='Cancel']";           
    }
}
