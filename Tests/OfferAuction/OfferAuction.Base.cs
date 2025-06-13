using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquarebookAutomation.Tests.OfferAuction
{
    public partial class OfferAuctionBase : Base
    {
        /// <summary>
        /// Common method to open the auction page of an offer. Make sure that the user is on the offer details page
        /// </summary>
        /// <param name="wait"></param>
        public static void OpenOfferAuctionPageFromOfferDetails(WebDriverWait wait)
        {
            if (CheckIfElementExists(wait, LOCATOR_BROWSEBIDS_BTN1) == true)
            {
                ClickOnButton(wait, LOCATOR_BROWSEBIDS_BTN1);
            }
            else if (CheckIfElementExists(wait, LOCATOR_VIEWAUCTION_BTN1) == true)
            {
                ClickOnButton(wait, LOCATOR_VIEWAUCTION_BTN1);
            }
        }
        /// <summary>
        /// Common method to open auction page of a round of a multi round offer
        /// </summary>
        /// <param name="wait"></param>
        /// <param name="roundnumber">Number of the round</param>
        public static void OpenOfferRoundAuctionPageFromOfferDetails(WebDriverWait wait, int roundnumber)
        {
            if (CheckIfElementExists(wait, LOCATOR_ROUNDVIEWAUCTION_BTN(roundnumber)) == true)
            {
                ClickOnButton(wait, LOCATOR_ROUNDVIEWAUCTION_BTN(roundnumber));
            }
        }
    }
}
