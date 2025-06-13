using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SquarebookAutomation.Tests.Flag
{
    public partial class FlagBase : Base
    {
        /// <summary>
        /// Common function to create a flag
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="wait"></param>
        /// <param name="FLAG_NAME">Name of the Flag</param>
        /// <param name="offer">Offer Name</param>
        /// <param name="organisations">List of Organisation to add in the flag</param>
        protected static void CreateAFlag(WebDriverWait wait, 
            string FLAG_NAME, 
            string offer, 
            List<string> organisations)
        {
            ClickOnNavBarLink(wait, LOCATOR_AUCTIONMANAGEMENT_LINK);
            ClickOnNavBarLink(wait, LOCATOR_FLAGS_SUBLINK);
            ClickOnAddButton(wait);
            AddDataToField(wait, LOCATOR_FLAGNAME_FIELD, FLAG_NAME);
            ClickOnDropDown(wait, LOCATOR_OFFER_DROPDOWN);
            SelectFromDropDown(wait, offer);
            foreach (string item in organisations)
            {
                ClickOnDropDown(wait, LOCATOR_ORGANISATIONS_MULTISELECT);
                SelectFromDropDown(wait, item);
                Thread.Sleep(500);
            }
            ClickOnButton(wait, LOCATOR_ORGANISATIONSAVE_BUTTON);
            Thread.Sleep(2000);
        }
    }
}
