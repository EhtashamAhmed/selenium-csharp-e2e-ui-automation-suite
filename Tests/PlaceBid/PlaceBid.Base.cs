using SquarebookAutomation.Tests.OfferDetails;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SquarebookAutomation.Tests.OfferAuction;

namespace SquarebookAutomation.Tests.PlaceBid
{
    public partial class PlaceBidBase : Base
    {
        /// <summary>
        /// Common function to place a bid on an IPO offer
        /// </summary>
        /// <param name="wait"></param>
        /// <param name="offername">Name of the offer to place bid</param>
        /// <param name="bidprice">Bid price, must be within the offer bid range</param>
        /// <param name="numberofshares">Number of shares to bid for, must be less than or equal to the shares in offer</param>
        public static void PlaceABidOnIPO(WebDriverWait wait, string offername, float bidprice, int numberofshares)
        {
            ClickOnNavBarLink(wait, LOCATOR_OFFERS_LINK);
            OfferDetailsBase.OpenOfferDetailsPageFromDashboard(wait, offername);
            OfferAuctionBase.OpenOfferAuctionPageFromOfferDetails(wait);
            ClickOnButton(wait, LOCATOR_NEWBID_BTN);
            AddDataToField(wait, LOCATOR_EDITBIDNUMBEROFSHARES_FIELD, numberofshares.ToString());
            AddDataToField(wait, LOCATOR_BIDPRICE_FIELD, bidprice.ToString());
            AddDataToField(wait, LOCATOR_PLACEBIDPASSWORD_FIELD, PASSWORD);
            ClickOnButton(wait, LOCATOR_PLACEBID_BTN);
        }
        /// <summary>
        /// Common function to place a bid on an IPO offer from an Advisor on behalf of an investor
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="wait"></param>
        /// <param name="offername">Name of the offer to place bid</param>
        /// <param name="bidprice">Bid price, must be within the offer bid range</param>
        /// <param name="numberofshares">Number of shares to bid for, must be less than or equal to the shares in offer</param>
        public static void PlaceABidOnIPO(WebDriverWait wait, string offername, float bidprice, int numberofshares, string onbehalfofinvestor)
        {
            ClickOnNavBarLink(wait, LOCATOR_OFFERS_LINK);
            OfferDetailsBase.OpenOfferDetailsPageFromDashboard(wait, offername);
            OfferAuctionBase.OpenOfferAuctionPageFromOfferDetails(wait);
            ClickOnButton(wait, LOCATOR_NEWBID_BTN);
            ClickOnDropDown(wait, LOCATOR_ONBEHALFOF_DROPDOWN);
            SelectFromDropDown(wait, onbehalfofinvestor);
            AddDataToField(wait, LOCATOR_ONBEHALFOFCOMMENT_FIELD, $"{onbehalfofinvestor} Bid");
            AddDataToField(wait, LOCATOR_EDITBIDNUMBEROFSHARES_FIELD, numberofshares.ToString());
            AddDataToField(wait, LOCATOR_BIDPRICE_FIELD, bidprice.ToString());
            AddDataToField(wait, LOCATOR_PLACEBIDPASSWORD_FIELD, PASSWORD);
            ClickOnButton(wait, LOCATOR_PLACEBID_BTN);
        }
    }
}
