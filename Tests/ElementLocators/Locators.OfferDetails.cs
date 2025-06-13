using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquarebookAutomation.Tests.ElementLocators
{
    public partial class Locators : Configurations
    {
        protected const string LOCATOR_BROWSEBIDS_BTN1 = "(//span[contains(text(),'Browse bids')])[1]";
        protected const string LOCATOR_BROWSEBIDS_BTN2 = "(//span[contains(text(),'Browse bids')])[2]";
        protected const string LOCATOR_INVITEINVESTORS_BTN = "(//a[contains(text(),'Invite investors')])[1]";
        protected const string LOCATOR_SHOWSETTLEMENTROUTES_BTN = "//span[contains(text(),'Show Settlement Routes')]";
        protected const string LOCATOR_INFORMATION_TAB = "//h6[text()='Information']";
        protected const string LOCATOR_DOCUMENTS_TAB = "//h6[text()='Documents']";
        protected const string LOCATOR_AUCTIONRULES_TAB = "//h6[text()='Auction rules']";
        protected const string LOCATOR_ROUND_STAB = "//h6[text()='Rounds']";
        /// <summary>
        /// Method to set the locator of the View auction button specific to the round number
        /// </summary>
        /// <param name="roundorder"></param>
        /// <returns></returns>
        protected static string LOCATOR_ROUNDVIEWAUCTION_BTN(int roundorder)
        {
            return $"//div[text()='{roundorder}']//following::button[text()='View auction'][1]";
        }        
        protected const string LOCATOR_VIEWAUCTION_BTN1 = "(//span[contains(text(),'View Auction')])[1]";
        protected const string LOCATOR_VIEWAUCTION_BTN2 = "(//span[contains(text(),'View auction')])[1]";
        protected const string LOCATOR_REFERANINVESTOR_BTN = "//button[contains(text(),'Refer an Investor for this offer')]";

    }
}
