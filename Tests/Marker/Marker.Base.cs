using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Xunit;

namespace SquarebookAutomation.Tests.Marker
{
    public partial class MarkerBase : Base
    {
        /// <summary>
        /// Common method to create a marker
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="wait"></param>
        /// <param name="markerTitle">Name of the marker</param>

        protected static void CreateAMarker(IWebDriver driver, WebDriverWait wait, string markerTitle)
        {
            NavigateToMarkerManagement(driver, wait);
            NavigateToMarkerCreationComposePage(driver, wait);
            AddDataToField(wait, LOCATOR_MARKERTITLE_FIELD, markerTitle);
            UploadAnImage(driver, LOCATOR_MARKERIMAGE, PrimaryImage);
            ClickOnButton(wait, LOCATOR_MARKERSAVE_BUTTON);
            
        }
        /// <summary>
        /// Common method to navigate to the Markers index page
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="wait"></param>
        protected static void NavigateToMarkerManagement(IWebDriver driver, WebDriverWait wait)
        {
            ClickOnNavBarLink(driver, wait, LOCATOR_COMPANYMANAGEMENT_LINK);
            ClickOnNavBarLink(driver, wait, LOCATOR_MARKERS_SUBLINK);
        }
        /// <summary>
        /// Method to navigate to the Marker compose page from Marker index page
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="wait"></param>
        protected static void NavigateToMarkerCreationComposePage(IWebDriver driver, WebDriverWait wait)
        {
            ClickOnAddButton(wait);
            Thread.Sleep(4000);
        }
    }
}
