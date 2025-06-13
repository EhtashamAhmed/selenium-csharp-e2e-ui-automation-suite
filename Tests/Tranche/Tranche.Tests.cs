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

namespace SquarebookAutomation.Tests.Tranche
{
    [Order(8)]
    public partial class Tranche : TrancheBase, IDisposable
    {
        /// <summary>
        /// Test that open tranche management and verify that the Tranche Management is opened
        /// </summary>
        [Fact]
        public void OpeningTrancheManagement_ShouldOpenTrancheManagement()
        {
            LoginBase.LoginToPlatform(Driver, WebDriverWait, AppURL);
            ClickOnNavBarLink(WebDriverWait, LOCATOR_AUCTIONMANAGEMENT_LINK);
            ClickOnNavBarLink(WebDriverWait, LOCATOR_TRANCHES_SUBLINK);
            var ManagementPageHeading = ReturnIWebElementObject(WebDriverWait, LOCATOR_INDEXPAGE_HEADING);
            Assert.Equal("Tranche management", ManagementPageHeading.Text);
        }
        /// <summary>
        /// Test for creating a tranche with 2 prizes in it and a rule of bidder with requested shares greater than N
        /// </summary>
        [RetryFact(FAIL_TEST_RETRIES)]
        public void CreatingNewTranche_ShouldCreateANewTranche()
        {
            LoginBase.LoginToPlatform(Driver, WebDriverWait, AppURL);

            List<string> prizesList = new List<string>();
            prizesList.Add("Discount");
            prizesList.Add("Preferred bidder");

            List<string> rulesList = new List<string>();
            rulesList.Add(TRANCHE_RULE_2);

            CreateATranche(Driver, WebDriverWait, 
                $"{TRANCHE_TITLE} {Uniqueness}", 
                $"{IPO_OFFER_TITLE} {Uniqueness}", 
                TRANCHE_SHARES, 
                TRANCHE_POINTS_THRESHOLD, 
                prizesList, 
                rulesList);
            IWebElement toastObject = ToastMessageTextObjectReturn(WebDriverWait, LOCATOR_TOAST_MESSAGE);
            Assert.Equal(Tranche_ADD_SUCCESS_MESSAGE, toastObject.Text);
        }
    }
}
