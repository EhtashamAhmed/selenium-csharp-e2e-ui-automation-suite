using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using SquarebookAutomation.Tests.Login;
using System;
using System.Collections.Generic;
using System.Text;
using xRetry;
using Xunit;
using Xunit.Extensions.Ordering;

namespace SquarebookAutomation.Tests.Flag
{
    [Order(8)]
    public partial class Flag : FlagBase
    {
        /// <summary>
        /// Test that open Flag management page
        /// </summary>

        [Fact]
        public void OpeningFlagManagement_ShouldOpenFlagManagement()
        {
            LoginBase.LoginToPlatform(Driver, WebDriverWait, AppURL);
            ClickOnNavBarLink(WebDriverWait, LOCATOR_AUCTIONMANAGEMENT_LINK);
            ClickOnNavBarLink(WebDriverWait, LOCATOR_FLAGS_SUBLINK);
            var FlagManagementHeading = ReturnIWebElementObject(WebDriverWait, LOCATOR_INDEXPAGE_HEADING);
            Assert.Equal("Flag management", FlagManagementHeading.Text);
        }

        /// <summary>
        /// Test to create a flag
        /// </summary>
        [RetryFact(FAIL_TEST_RETRIES)]
        public void CreatingAFlag_ShouldCreateANewFlag()
        {
            LoginBase.LoginToPlatform(Driver, WebDriverWait, AppURL);
            List<string> organisationsList = new List<string>();
            organisationsList.Add($"{PRIVATE_INVESTOR_ORG_NAME} {Uniqueness}");
            organisationsList.Add($"{INSTITUTIONAL_INVESTOR_ORG_NAME} {Uniqueness}");

            CreateAFlag(WebDriverWait, 
                $"{FLAG_NAME} {Uniqueness}", 
                $"{IPO_OFFER_TITLE} {Uniqueness}", 
                organisationsList);
            IWebElement toastObject = ToastMessageTextObjectReturn(WebDriverWait, LOCATOR_TOAST_MESSAGE);
            Assert.Equal(Flag_ADD_SUCCESS_MESSAGE, toastObject.Text);
        }
    }
}
