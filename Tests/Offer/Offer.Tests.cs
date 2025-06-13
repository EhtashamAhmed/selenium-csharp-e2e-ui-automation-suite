using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using SquarebookAutomation.Tests.Login;
using SquarebookAutomation.Tests.Offer.Round;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using xRetry;
using Xunit;
using Xunit.Extensions.Ordering;

namespace SquarebookAutomation.Tests.Offer
{
    [Order(7)]
    public partial class Offer : OfferBase, IDisposable
    {
        /// <summary>
        /// Test for verifying if the Offer management page is opening
        /// </summary>
        [Fact]
        public void OpeningOfferManagement_ShouldOpenOfferManagement()
        {
            LoginBase.LoginToPlatform(Driver, WebDriverWait, AppURL);
            ClickOnNavBarLink(WebDriverWait, LOCATOR_AUCTIONMANAGEMENT_LINK);
            Thread.Sleep(2000);
            ScrollToElement(Driver, WebDriverWait, path: LOCATOR_OFFERS_SUBLINK);
            ClickOnNavBarLink(WebDriverWait, LOCATOR_OFFERS_SUBLINK);
            var OfferManagementHeading = ReturnIWebElementObject(WebDriverWait, LOCATOR_INDEXPAGE_HEADING);
            Assert.Equal("Offer management", OfferManagementHeading.Text);
        }

        /// <summary>
        /// Test for creating an IPO Offer
        /// </summary>
        [RetryFact(FAIL_TEST_RETRIES)]
        public void CreatingNewIpoOffer_ShouldCreateANewIpoOffer()
        {            
            LoginBase.LoginToPlatform(Driver, WebDriverWait, AppURL);
            CreateAnIpoOffer(Driver, WebDriverWait, $"{IPO_OFFER_TITLE} {Uniqueness}", $"{COMPANY_TITLE} {Uniqueness}");
            IWebElement toastObject = ToastMessageTextObjectReturn(WebDriverWait, LOCATOR_TOAST_MESSAGE);
            Assert.Equal(OFFER_ADD_SUCCESS_MESSAGE, toastObject.Text);
        }
        [RetryFact(FAIL_TEST_RETRIES)]
        public void CreatingNewMultiRoundOffer_ShouldCreateANewMultiRoundOffer()
        {            
            static Dictionary<string, OfferRound> GetRounds()
            {
                var rounds = new Dictionary<string, OfferRound>();
                var theRound = new OfferRound("Round 1", 
                    "Bidding Round",
                    "Visible to all users",
                    "Advisor A",
                    "I Investor A",
                    "I Investor B",
                    "Bidding",
                    "Active");
                rounds.Add("1", theRound);
                theRound = new OfferRound("Round 2",
                    "Bidding Round",
                    "Visible to all users",
                    "Advisor B",
                    "I Investor C",
                    "I Investor B",
                    "Bidding",
                    "Ended");
                rounds.Add("2", theRound);
                return rounds;                
            }
            LoginBase.LoginToPlatform(Driver, WebDriverWait, AppURL);
            CreateMultiRoundOffer(Driver, WebDriverWait, 
                $"MultiRound {Uniqueness}",
                $"COMPANY {Uniqueness}",
                OFFER_WEBSITE_URL,
                OFFER_END_DATE, GetRounds());
            IWebElement toastObject = ToastMessageTextObjectReturn(WebDriverWait, LOCATOR_TOAST_MESSAGE);
            Assert.Equal(OFFER_ADD_SUCCESS_MESSAGE, toastObject.Text);
        }
    }
}
