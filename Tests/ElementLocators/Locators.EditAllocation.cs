using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquarebookAutomation.Tests.ElementLocators
{
    public partial class Locators : Configurations
    {
        protected const string LOCATOR_SHARESALLOCATEDOVERRIDE_FIELD = "//input[@id='SharesAllocatedOverride']";
        protected const string LOCATOR_SHARESALLOCATEDOVERRIDEREASON_TEXTAREA = "//span[contains(text(),'override reason')]//following::textarea[1]";
        protected const string LOCATOR_EDITALLOCATIONSAVE_BTN = "//button[text()='Save']";
        protected const string LOCATOR_EDITALLOCATIONCANCEL_BTN = "//button[text()='Cancel']";
    }
}
