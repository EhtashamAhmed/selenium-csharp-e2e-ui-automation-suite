using System;
using System.Collections.Generic;
using System.Text;

namespace SquarebookAutomation.Tests.ElementLocators
{
    public partial class Locators : Configurations
    {
        protected const string LOCATOR_FLAGNAME_FIELD = "//input[@placeholder = 'Enter flag name']";
        protected const string LOCATOR_OFFER_DROPDOWN = "//span[text()='Offer']//following::span[@class='select2-selection__rendered'][1]";
        protected const string LOCATOR_ORGANISATIONS_MULTISELECT = "(//span[@class='select2-selection select2-selection--multiple'])[1]";
        protected const string LOCATOR_FLAGSAVE_BUTTON = "//button[text()='Save' and @title='Save flag']";
        protected const string LOCATOR_FLAGCANCEL_BUTTON = "//button[text()='Cancel' and @title='Cancel and go back']";
    }
}
