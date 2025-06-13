using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SquarebookAutomation.Tests.Tranche
{
    public partial class TrancheBase : Base
    {
        /// <summary>
        /// This is the general function to create a Tranche
        /// </summary>
        /// <param name="driver">web driver parameter</param>
        /// <param name="webDriverWait">setwait for the driver</param>
        /// <param name="trancheTitle">Title for the tranche that is being created</param>
        /// <param name="ipoOfferTitle">Title of the offer for which the tranche will be linked</param>
        /// <param name="trancheShares">Number of shares in the tranche being created</param>
        /// <param name="tranchePointsThreshold">Threshold point (number)</param>
        /// <param name="prizesList">Prizes that will be added to the tranche</param>
        /// <param name="rulesList">Rules that will be added to the tranche</param>
        /// <param name="trancheMaxSharesPerMember">Max shares allocated per member</param>
        /// <param name="offerRound">If the offer is a multi round offer, specify the name of the round for the tranche</param>
        protected static void CreateATranche(IWebDriver driver, 
            WebDriverWait webDriverWait, 
            string trancheTitle, 
            string ipoOfferTitle, 
            string trancheShares, 
            string tranchePointsThreshold, 
            List<string> prizesList, 
            List<string> rulesList, 
            string trancheMaxSharesPerMember = "", 
            string offerRound = null)
        {
            int _prizeCount = 1;
            int _ruleCount = 1;

            //Details
            ClickOnNavBarLink(webDriverWait, LOCATOR_AUCTIONMANAGEMENT_LINK);
            ClickOnNavBarLink(webDriverWait, LOCATOR_TRANCHES_SUBLINK);
            ClickOnAddButton(webDriverWait);
            AddDataToField(webDriverWait, LOCATOR_TRANCHENAME_FIELD, trancheTitle);
            ClickOnDropDown(webDriverWait, LOCATOR_TRANCHEOFFERS_DROPDOWN);
            SelectFromDropDown(webDriverWait, ipoOfferTitle);
            if (offerRound != null)
            {
                ClickOnDropDown(webDriverWait, LOCATOR_TRANCHEROUND_DROPDOWN);
                SelectFromDropDown(webDriverWait, offerRound);
            }
            ReplacingDataOfAField(webDriverWait, LOCATOR_TRANCHENUMBEROFSHARES_FIELD, trancheShares);
            AddDataToField(webDriverWait, LOCATOR_MAXSHARESPERMEMBER_FIELD, trancheMaxSharesPerMember);
            ReplacingDataOfAField(webDriverWait, LOCATOR_TRANCHEPOINTSINTHRESH_FIELD, tranchePointsThreshold);
            ScrollToElement(driver,webDriverWait, LOCATOR_TRANCHEPRIZES_TAB);

            //Prizes
            ClickOnButton(webDriverWait, LOCATOR_TRANCHEPRIZES_TAB);
            foreach (string item in prizesList)
            {
                ClickOnButton(webDriverWait, LOCATOR_ADDNEWPRIZE_BUTTON);
                if (item == "Non platform")
                {
                    ClickOnButton(webDriverWait, $"//span[text()='Prize {_prizeCount}']//following::*[contains(text(),'Non platform')]//span[1]");
                    AddDataToField(webDriverWait, LOCATOR_PRIZEDESCRIPTION_FIELD, TRANCHE_PRIZE_DESCRIPTION);
                }
                else if (item == "Preferred bidder")
                {
                    ClickOnButton(webDriverWait, $"//span[text()='Prize {_prizeCount}']//following::*[contains(text(),'Preferred bidder')]//span[1]");
                    AddDataToField(webDriverWait, LOCATOR_PRIZEDESCRIPTION_FIELD, TRANCHE_PRIZE_DESCRIPTION);
                    AddDataToField(webDriverWait, LOCATOR_PRIZEPREFERENCEFACTOR_FIELD, TRANCHE_PREFERENCE_FACTOR);
                }
                else if (item == "Discount")
                {
                    ClickOnButton(webDriverWait, $"//span[text()='Prize {_prizeCount}']//following::*[contains(text(),'Discount')]//span[1]");
                    AddDataToField(webDriverWait, LOCATOR_PRIZEDESCRIPTION_FIELD, TRANCHE_PRIZE_DESCRIPTION);
                    AddDataToField(webDriverWait, LOCATOR_PRIZEPERCENTAGEDISC_FIELD, TRANCHE_DISCOUNT_PERCENTAGE);
                }
                else if (item == "Free shares")
                {
                    ClickOnButton(webDriverWait, $"//span[text()='Prize {_prizeCount}']//following::*[contains(text(),'Free shares')]//span[1]");
                    AddDataToField(webDriverWait, LOCATOR_PRIZEDESCRIPTION_FIELD, TRANCHE_PRIZE_DESCRIPTION);
                    AddDataToField(webDriverWait, LOCATOR_PRIZEPERCENTAGEFREESHARES_FIELD, TRANCHE_FREE_SHARES_PERCENTAGE);
                }
                Thread.Sleep(1000);
                _prizeCount++;
            }
            ScrollToElement(driver, webDriverWait, LOCATOR_TRANCHERULES_TAB);

            //Rules
            ClickOnButton(webDriverWait, LOCATOR_TRANCHERULES_TAB);
            Thread.Sleep(2000);
            foreach (string rule in rulesList)
            {
                ClickOnButton(webDriverWait, LOCATOR_ADDRULE_DROPDOWN);
                SelectFromDropDown(webDriverWait, rule);
                if (rule == TRANCHE_RULE_1)
                {
                    AddDataToField(webDriverWait, LOCATOR_RULEDESCRIPTION_FIELD, TRANCHE_RULE_1);
                    AddDataToField(webDriverWait, LOCATOR_RULEPOINTS_FIELD, TRANCHE_RULE_POINTS);
                    ClickOnButton(webDriverWait, LOCATOR_RULEQUESTIONNAIRE_DROPDOWN);
                    SelectFromDropDown(webDriverWait, TRANCHE_RULE_QUESTIONNAIRE);
                }
                else if (rule == TRANCHE_RULE_2)
                {
                    AddDataToField(webDriverWait, LOCATOR_RULEDESCRIPTION_FIELD, TRANCHE_RULE_2);
                    AddDataToField(webDriverWait, LOCATOR_RULEPOINTS_FIELD, TRANCHE_RULE_POINTS);
                    AddDataToField(webDriverWait, LOCATOR_RULESHARES_FIELD, TRANCHE_RULE_SHARES);
                }
                else if (rule == TRANCHE_RULE_3)
                {
                    AddDataToField(webDriverWait, LOCATOR_RULEDESCRIPTION_FIELD, TRANCHE_RULE_3);
                    AddDataToField(webDriverWait, LOCATOR_RULEPOINTS_FIELD, TRANCHE_RULE_POINTS);
                }
                else if (rule == TRANCHE_RULE_4)
                {
                    AddDataToField(webDriverWait, LOCATOR_RULEDESCRIPTION_FIELD, TRANCHE_RULE_4);
                    AddDataToField(webDriverWait, LOCATOR_RULEPOINTS_FIELD, TRANCHE_RULE_POINTS);
                    ClickOnButton(webDriverWait, LOCATOR_TRANCHEFLAG_DROPDOWN);
                    SelectFromDropDown(webDriverWait, TRANCHE_FLAG);
                }
                else if (rule == TRANCHE_RULE_5)
                {
                    AddDataToField(webDriverWait, LOCATOR_RULEDESCRIPTION_FIELD, TRANCHE_RULE_5);
                    AddDataToField(webDriverWait, LOCATOR_RULEPOINTS_FIELD, TRANCHE_RULE_POINTS);
                }
                else if (rule == TRANCHE_RULE_6)
                {
                    AddDataToField(webDriverWait, LOCATOR_RULEDESCRIPTION_FIELD, TRANCHE_RULE_6);
                    AddDataToField(webDriverWait, LOCATOR_RULEPOINTS_FIELD, TRANCHE_RULE_POINTS);
                    ClickOnButton(webDriverWait, LOCATOR_RULEQUESTIONNAIRE_DROPDOWN);
                    SelectFromDropDown(webDriverWait, TRANCHE_RULE_QUESTIONNAIRE);
                    ClickOnButton(webDriverWait, LOCATOR_ITEM_DROPDOWN);
                    SelectFromDropDown(webDriverWait, TRANCHE_QUESTIONNAIRE_ITEM);
                }
                else if (rule == TRANCHE_RULE_7)
                {
                    AddDataToField(webDriverWait, LOCATOR_RULEDESCRIPTION_FIELD, TRANCHE_RULE_7);
                    AddDataToField(webDriverWait, LOCATOR_RULEPOINTS_FIELD, TRANCHE_RULE_POINTS);
                    ClickOnButton(webDriverWait, LOCATOR_RULEQUESTIONNAIRE_DROPDOWN);
                    SelectFromDropDown(webDriverWait, TRANCHE_RULE_QUESTIONNAIRE);
                    AddDataToField(webDriverWait, LOCATOR_RULEBENCHMARK_FIELD, TRANCHE_RULE_BENCHMARK);
                    ClickOnButton(webDriverWait, LOCATOR_ITEM_DROPDOWN);
                    SelectFromDropDown(webDriverWait, TRANCHE_QUESTIONNAIRE_ITEM);
                }
                _ruleCount++;
            }
            ClickOnButton(webDriverWait, LOCATOR_TRANCHESAVE_BUTTON);
            Thread.Sleep(2000);
        }
    }
}
