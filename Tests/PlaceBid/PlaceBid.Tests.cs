using OpenQA.Selenium;
using SquarebookAutomation.Tests.Flag;
using SquarebookAutomation.Tests.Login;
using SquarebookAutomation.Tests.OfferDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Extensions.Ordering;

namespace SquarebookAutomation.Tests.PlaceBid
{
    [Order(9)]
    public partial class PlaceBid : PlaceBidBase
    {           
        /// <summary>
        /// Test that open place bid page of an IPO offer and place a bid from institutional investor user
        /// </summary>
        [Fact]
        public void PlacingABidByInstitutionalInvestor_ShouldPlaceABid()
        {
            LoginBase.LoginToPlatform(Driver, WebDriverWait, AppURL, $"{INST_INVESTOR_FIRST_NAME}{INST_INVESTOR_LAST_NAME}{Uniqueness}@gmail.com");
            PlaceABidOnIPO(WebDriverWait, $"OFFER IPO {Uniqueness}", 20, 40000);
            IWebElement toastObject = ToastMessageTextObjectReturn(WebDriverWait, LOCATOR_TOAST_MESSAGE);
            Assert.Equal("Bid was added successfully..", toastObject.Text);
        }
        /// <summary>
        /// Test that open place bid page of an IPO offer and place a bid from private investor user
        /// </summary>
        [Fact]
        public void PlacingABidByPrivateInvestor_ShouldPlaceABid()
        {
            LoginBase.LoginToPlatform(Driver, WebDriverWait, AppURL, 
                $"{PVT_INVESTOR_FIRST_NAME}{PVT_INVESTOR_LAST_NAME}{Uniqueness}@gmail.com");

            PlaceABidOnIPO(WebDriverWait, $"OFFER IPO {Uniqueness}", 20, 40000);
            IWebElement toastObject = ToastMessageTextObjectReturn(WebDriverWait, LOCATOR_TOAST_MESSAGE);
            Assert.Equal("Bid was added successfully..", toastObject.Text);
        }
        /// <summary>
        /// Test that open place bid page of an IPO offer and place a bid from private investor user
        /// </summary>
        [Fact]
        public void PlacingABidByAdvisorOnSomeoneBehalf_ShouldPlaceABid()
        {
            LoginBase.LoginToPlatform(Driver, WebDriverWait, AppURL, 
                $"{ADVISOR_FIRST_NAME}{ADVISOR_LAST_NAME}{Uniqueness}@gmail.com");

            PlaceABidOnIPO(WebDriverWait, 
                $"OFFER IPO {Uniqueness}"
                , 20, 40000, 
                $"{INST_INVESTOR_FIRST_NAME} {INST_INVESTOR_LAST_NAME} - {INSTITUTIONAL_INVESTOR_ORG_NAME} {Uniqueness}");

            IWebElement toastObject = ToastMessageTextObjectReturn(WebDriverWait, LOCATOR_TOAST_MESSAGE);
            Assert.Equal("Bid was added successfully..", toastObject.Text);
        }
    }
}
