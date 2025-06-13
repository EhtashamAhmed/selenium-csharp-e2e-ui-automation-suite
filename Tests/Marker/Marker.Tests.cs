using OpenQA.Selenium;
using SquarebookAutomation.Tests.Login;
using System;
using xRetry;
using Xunit;
using Xunit.Extensions.Ordering;

namespace SquarebookAutomation.Tests.Marker
{
    [Order(1)]
    public partial class Marker : MarkerBase, IDisposable
    {
        /// <summary>
        /// Test for verifying navbar item Markers
        /// </summary>
        [Fact]
        public void CheckIfMarkersIsVisibleInNavbar_MarkersShouldBeInTheNavbarUnderCompanyManagement()
        {
            LoginBase.LoginToPlatform(Driver, WebDriverWait, AppURL);
            ClickOnNavBarLink(WebDriverWait, LOCATOR_COMPANYMANAGEMENT_LINK);
            var navbarItemSignups = ReturnIWebElementObject(WebDriverWait, LOCATOR_MARKERS_SUBLINK);
            Assert.Equal("Markers", navbarItemSignups.Text);
        }

        /// <summary>
        /// Test for verifying if the Marker management page is opening
        /// </summary>
        [Fact]
        public void OpeningMarkerManagement_ShouldOpenMarkerManagement()
        {
            LoginBase.LoginToPlatform(Driver, WebDriverWait, AppURL);
            NavigateToMarkerManagement(Driver, WebDriverWait);           
            var MarkerManagementHeading  = ReturnIWebElementObject(WebDriverWait, LOCATOR_INDEXPAGE_HEADING);
            Assert.Equal("Marker management", MarkerManagementHeading.Text);
        }

        /// <summary>
        /// Test for creating a new marker
        /// </summary>
        [RetryFact(FAIL_TEST_RETRIES)]
        public void CreatingMarker_ShouldCreateANewMarker()
        {           
            LoginBase.LoginToPlatform(Driver, WebDriverWait, AppURL);
            CreateAMarker(Driver, WebDriverWait, $"{MARKERTITLE} {Uniqueness}");
            IWebElement toastObject = ToastMessageTextObjectReturn(WebDriverWait, LOCATOR_TOAST_MESSAGE);
            Assert.Equal(MARKER_ADD_SUCCESS_MESSAGE, toastObject.Text);
        }
    }
}
