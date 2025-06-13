using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquarebookAutomation.Tests.ElementLocators
{
    public partial class Locators : Configurations
    {
        protected const string LOCATOR_EDITBIDNUMBEROFSHARES_FIELD = "//input[@id='idNumberofSharesInputField']";
        protected const string LOCATOR_EDITBIDPRICE_FIELD = "//input[contains(@placeholder,'Enter a price between')]";
        protected const string LOCATOR_BIDEDITSETTLEMENTROUTE_DROPDOWN = "//span[@id='select2-__bidSettlementRoute-container']";
        protected const string LOCATOR_BIDEDITSAVE_BTN = "//button[text()='Save']";
        protected const string LOCATOR_BIDEDITCANCEL_BTN = "//button[text()='Cancel']";
    }
}
