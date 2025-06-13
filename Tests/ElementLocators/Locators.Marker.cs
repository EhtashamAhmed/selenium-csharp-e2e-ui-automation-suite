using System;
using System.Collections.Generic;
using System.Text;

namespace SquarebookAutomation.Tests.ElementLocators
{
    public partial class Locators : Configurations
    {
        protected const string LOCATOR_MARKERTITLE_FIELD = "//input[@id='markerTitle']";
        protected const string LOCATOR_MARKERIMAGE = "//input[@name='newsItemImageUplaod']";
        protected const string LOCATOR_BACKGROUNDCOLOR_FIELD = "//input[@id='BGColor']";
        protected const string LOCATOR_FONTCOLOR_FIELD = "//input[@id='FontColor']";
        protected const string LOCATOR_MARKERSAVE_BUTTON = "//button[text()='Save']";
        protected const string LOCATOR_MARKERCANCEL_BUTTON = "//button[text()='Cancel']";
    }
}
