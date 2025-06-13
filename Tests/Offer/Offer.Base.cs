using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using SquarebookAutomation.Tests.Offer.Round;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SquarebookAutomation.Tests.Offer
{
    public partial class OfferBase : Base
    {
        protected string companyTitle = "";
        /// <summary>
        /// Generic method to create an IPO offer
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="wait"></param>
        /// <param name="offerName">Name of the offer</param>
        /// <param name="company">Company name for which the offer is created for</param>
        /// <param name="isPublic">True or False based on setting the offer visibility to Public or Private</param>
        /// <param name="offerStatus">Status of the offer</param>
        /// <param name="currency">Currency for the offer</param>
        /// <param name="shares">Number of shares in that offer</param>
        /// <param name="publishedMaxRange">Published Max price range</param>
        /// <param name="permittedMaxRange">Permitted Max price range</param>
        protected static void CreateAnIpoOffer(IWebDriver driver, 
            WebDriverWait wait, 
            string offerName, 
            string company, 
            bool isPublic = true, 
            bool isShowTradeSymbol = false, 
            string offerStatus = "Active", 
            string currency = "Dollar", 
            string shares = "100000", 
            string publishedMaxRange = "20", 
            string permittedMaxRange = "20")
        {
            NavigateToOfferIndexPage(driver, wait);
            //Details tab
            ClickOnDropDown(wait, LOCATOR_ISSUETYPE_DROPDOWN);
            SelectFromDropDown(wait, "Single round");
            AddDataToField(wait, LOCATOR_OFFERNAME_FIELD, offerName);
            AddDataToField(wait, LOCATOR_SUMMARY_FIELD, COMPANY_SUMMARY);
            AddDataToField(wait, LOCATOR_OFFERWEBURL_FIELD, OFFER_WEBSITE_URL);
            ClickOnDropDown(wait, LOCATOR_OFFEREXECUTIONROUTES_MULTISELECT);
            SelectFromDropDown(wait, "Squarebook");
            ClickOnDropDown(wait, LOCATOR_OFFERSETTLEMENTROUTES_MULTISELECT);
            SelectFromDropDown(wait, "Paying the issuing company directly");
            ClickOnDropDown(wait, LOCATOR_OFFERDUEDILIGENCE_DROPDOWN);
            SelectFromDropDown(wait, "Bid rejected unless KYC/AML is completed by deal close");
            ClearDataOfAField(wait, LOCATOR_OFFERENDDATE_FIELD);
            AddDataToField(wait, LOCATOR_OFFERENDDATE_FIELD, OFFER_END_DATE);
            HitEnterKey(wait, LOCATOR_OFFERENDDATE_FIELD);
            AddDataToField(wait, LOCATOR_NOOFSHARES_FIELD, shares);
            ClickOnDropDown(wait, LOCATOR_CURRENCY_DROPDOWN);
            SelectFromDropDown(wait, currency);
            ClickOnDropDown(wait, LOCATOR_OFFERCOMPANY_DROPDOWN);
            SelectFromDropDown(wait, company);
            ReplacingDataOfAField(wait, LOCATOR_PERMMAXRANGE_FIELD, permittedMaxRange);
            ReplacingDataOfAField(wait, LOCATOR_PERMMINRANGE_FIELD, "1");
            //ReplacingDataOfAField(wait, LOCATOR_PUBLISHEDMAXRANGE_FIELD, publishedMaxRange);            
            //ReplacingDataOfAField(wait, LOCATOR_PUBLISHEDMINRANGE_FIELD, "1");            
            ClickOnDropDown(wait, LOCATOR_OFFERSTATUS_DROPDOWN);
            SelectFromDropDown(wait, offerStatus);
            if (isPublic == true)
            {
                ClickOnButton(wait, LOCATOR_OFFERISPUBLIC_CHECKBOX);
            }
            if (isShowTradeSymbol == true)
            {
                ClickOnButton(wait, LOCATOR_SHOWTRADESYMBOL_CHECKBOX);
                AddDataToField(wait, LOCATOR_TRADESYMBOL_FIELD, $"{TRADE_SYMBOL} {Uniqueness}");
            }
            ClickOnDropDown(wait, LOCATOR_MARKERS_MULTISELECT);
            SelectFromDropDown(wait, $"{MARKERTITLE} {Uniqueness}");
            ClickOnDropDown(wait, LOCATOR_ADVISORS_MULTISELECT);
            SelectFromDropDown(wait, $"{ADVISOR_ORG_NAME} {Uniqueness}");
            ClickOnDropDown(wait, LOCATOR_OFFERINVESTORORGANIZATIONS_MULTISELECT);
            SelectFromDropDown(wait, $"{INSTITUTIONAL_INVESTOR_ORG_NAME} {Uniqueness}");
            ClickOnDropDown(wait, LOCATOR_OFFERISSUERINVITES_MULTISELECT);
            SelectFromDropDown(wait, $"{PRIVATE_INVESTOR_ORG_NAME} {Uniqueness}");            
            ScrollToElement(driver,wait, LOCATOR_OFFERDESCRIPTION_TAB);

            AddOfferDescription(driver, wait, true, true, true, true);
            ScrollToElement(driver,wait, LOCATOR_OFFERDOCUMENTS_TAB);

            //Document Library Tab
            ClickOnButton(wait, LOCATOR_OFFERDOCUMENTS_TAB);
            ScrollToElement(driver,wait, LOCATOR_OFFERVIDEOS_TAB);

            //Video Library Tab
            ClickOnButton(wait, LOCATOR_OFFERVIDEOS_TAB);
            ScrollToElement(driver,wait, LOCATOR_ALLOCATIONPOLICY_TAB);

            //Allocation Policy Tab
            ClickOnButton(wait, LOCATOR_ALLOCATIONPOLICY_TAB);
            AddDataToField(wait, LOCATOR_ALLOCPOLICY_SUMMERNOTE, COMPANY_FANCY_TEXT_DESCRIPTION);
            ScrollToElement(driver,wait, LOCATOR_OFFERTAGS_TAB);

            ////Tags tab
            ClickOnButton(wait, LOCATOR_OFFERTAGS_TAB);
            ClickOnButton(wait, LOCATOR_OFFEREXPANDTAGCATEGORIES_BUTTON);
            ClickOnButton(wait, LOCATOR_OFFERSPECIFICTAG_BUTTON);
            ClickOnButton(wait, LOCATOR_OFFERSAVE_BUTTON);
            Thread.Sleep(2000);
        }
        /// <summary>
        /// Method to create a new multi round offer
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="wait"></param>
        /// <param name="offerName">Name of the offer</param>
        /// <param name="company">Company name for which the offer is being created</param>
        /// <param name="url">Url of the offer website</param>
        /// <param name="enddate">End date for the offer</param>
        /// <param name="isPublic">True | False</param>
        /// <param name="isShowTradeSymbol"></param>
        /// <param name="offerStatus"></param>
        /// <param name="currency"></param>
        /// <param name="shares"></param>
        /// <param name="publishedMaxRange"></param>
        /// <param name="permittedMaxRange"></param>
        protected static void CreateMultiRoundOffer(IWebDriver driver,
            WebDriverWait wait,
            string offerName,
            string company,
            string url,
            string enddate,
            bool isPublic = true,
            bool isShowTradeSymbol = false,
            string offerStatus = "Active",
            string currency = "Dollar",
            string shares = "100000",
            string publishedMaxRange = "20",
            string permittedMaxRange = "20")
        {
            NavigateToOfferIndexPage(driver, wait);
            //Details tab
            ClickOnDropDown(wait, LOCATOR_ISSUETYPE_DROPDOWN);
            SelectFromDropDown(wait, "Multi round");
            AddDataToField(wait, LOCATOR_OFFERNAME_FIELD, offerName);
            AddDataToField(wait, LOCATOR_SUMMARY_FIELD, COMPANY_SUMMARY);
            AddDataToField(wait, LOCATOR_OFFERWEBURL_FIELD, url);
            ClearDataOfAField(wait, LOCATOR_OFFERENDDATE_FIELD);
            AddDataToField(wait, LOCATOR_OFFERENDDATE_FIELD, enddate);
            HitEnterKey(wait, LOCATOR_OFFERENDDATE_FIELD);
            AddDataToField(wait, LOCATOR_NOOFSHARES_FIELD, shares);
            ClickOnDropDown(wait, LOCATOR_CURRENCY_DROPDOWN);
            SelectFromDropDown(wait, currency);
            ClickOnDropDown(wait, LOCATOR_OFFERCOMPANY_DROPDOWN);
            SelectFromDropDown(wait, company);
            ReplacingDataOfAField(wait, LOCATOR_PERMMAXRANGE_FIELD, permittedMaxRange);
            ReplacingDataOfAField(wait, LOCATOR_PERMMINRANGE_FIELD, "1");
            //ReplacingDataOfAField(wait, LOCATOR_PUBLISHEDMAXRANGE_FIELD, publishedMaxRange);
            //ReplacingDataOfAField(wait, LOCATOR_PUBLISHEDMINRANGE_FIELD, "1");
            ClickOnDropDown(wait, LOCATOR_OFFERSTATUS_DROPDOWN);
            SelectFromDropDown(wait, offerStatus);
            if (isPublic == true)
            {
                ClickOnButton(wait, LOCATOR_OFFERISPUBLIC_CHECKBOX);
            }
            if (isShowTradeSymbol == true)
            {
                ClickOnButton(wait, LOCATOR_SHOWTRADESYMBOL_CHECKBOX);
                AddDataToField(wait, LOCATOR_TRADESYMBOL_FIELD, $"{TRADE_SYMBOL} {Uniqueness}");
            }
            
            ScrollToElement(driver, wait, LOCATOR_OFFERDESCRIPTION_TAB);
            AddOfferDescription(driver, wait, true);

            ScrollToElement(driver, wait, LOCATOR_OFFERTAGS_TAB);
            ////Tags tab
            ClickOnButton(wait, LOCATOR_OFFERTAGS_TAB);
            ClickOnButton(wait, LOCATOR_OFFERSAVE_BUTTON);
            Thread.Sleep(2000);
        }

        protected static void CreateMultiRoundOffer(IWebDriver driver,
            WebDriverWait wait,
            string offerName,
            string company,
            string url,
            string enddate,
            Dictionary<string, OfferRound> rounds,
            bool isPublic = true,
            bool isShowTradeSymbol = false,
            string offerStatus = "Active",
            string currency = "Dollar",
            string shares = "100000",
            string publishedMaxRange = "20",
            string permittedMaxRange = "20")
        {
            NavigateToOfferIndexPage(driver, wait);
            //Details tab
            ClickOnDropDown(wait, LOCATOR_ISSUETYPE_DROPDOWN);
            SelectFromDropDown(wait, "Multi round");
            AddDataToField(wait, LOCATOR_OFFERNAME_FIELD, offerName);
            AddDataToField(wait, LOCATOR_SUMMARY_FIELD, COMPANY_SUMMARY);
            AddDataToField(wait, LOCATOR_OFFERWEBURL_FIELD, url);
            ClickOnDropDown(wait, LOCATOR_OFFEREXECUTIONROUTES_MULTISELECT);
            SelectFromDropDown(wait, "Squarebook");
            ClickOnDropDown(wait, LOCATOR_OFFERSETTLEMENTROUTES_MULTISELECT);
            SelectFromDropDown(wait, "Paying the issuing company directly");
            ClickOnDropDown(wait, LOCATOR_OFFERDUEDILIGENCE_DROPDOWN);
            SelectFromDropDown(wait, "Bid rejected unless KYC/AML is completed by deal close");
            ClearDataOfAField(wait, LOCATOR_OFFERENDDATE_FIELD);
            AddDataToField(wait, LOCATOR_OFFERENDDATE_FIELD, enddate);
            HitEnterKey(wait, LOCATOR_OFFERENDDATE_FIELD);
            AddDataToField(wait, LOCATOR_NOOFSHARES_FIELD, shares);
            ClickOnDropDown(wait, LOCATOR_CURRENCY_DROPDOWN);
            SelectFromDropDown(wait, currency);
            ClickOnDropDown(wait, LOCATOR_OFFERCOMPANY_DROPDOWN);
            SelectFromDropDown(wait, company);
            ReplacingDataOfAField(wait, LOCATOR_PERMMAXRANGE_FIELD, permittedMaxRange);
            ReplacingDataOfAField(wait, LOCATOR_PERMMINRANGE_FIELD, "1");
            //ReplacingDataOfAField(wait, LOCATOR_PUBLISHEDMAXRANGE_FIELD, publishedMaxRange);
            //ReplacingDataOfAField(wait, LOCATOR_PUBLISHEDMINRANGE_FIELD, "1");
            ClickOnDropDown(wait, LOCATOR_OFFERSTATUS_DROPDOWN);
            SelectFromDropDown(wait, offerStatus);
            if (isPublic == true)
            {
                ClickOnButton(wait, LOCATOR_OFFERISPUBLIC_CHECKBOX);
            }
            if (isShowTradeSymbol == true)
            {
                ClickOnButton(wait, LOCATOR_SHOWTRADESYMBOL_CHECKBOX);
                AddDataToField(wait, LOCATOR_TRADESYMBOL_FIELD, $"{TRADE_SYMBOL} {Uniqueness}");
            }

            ScrollToElement(driver, wait, LOCATOR_OFFERDESCRIPTION_TAB);
            
            AddOfferDescription(driver, wait, true);
            ScrollToElement(driver, wait, LOCATOR_OFFERTAGS_TAB);
            ////Tags tab
            ClickOnButton(wait, LOCATOR_OFFERTAGS_TAB);
            ClickOnButton(wait, LOCATOR_OFFERSAVE_BUTTON);
            Thread.Sleep(2000);
        }

        /// <summary>
        /// Common method to add description of the offer
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="wait"></param>
        /// <param name="simpletext">True to add simple text to offer details</param>
        /// <param name="facnytext">True to add fancy text to offer details</param>
        /// <param name="carousel">True to add carousel to offer details</param>
        /// <param name="turtldocument">True to add turtl document to offer details</param>
        protected static void AddOfferDescription(IWebDriver driver,
            WebDriverWait wait,
            bool simpletext = false,
            bool facnytext = false,
            bool carousel = false,
            bool turtldocument = false)
        {
            ClickOnButton(wait, LOCATOR_OFFERDESCRIPTION_TAB);
            if (simpletext == true)
            {
                ClickOnDropDown(wait, LOCATOR_OFFERADDELEMENT_DROPDOWN);
                SelectFromDropDown(wait, "Simple text");
                Thread.Sleep(4000);
                AddDataToField(wait, LOCATOR_OFFERSIMPLETXT_HEADING_FIELD, COMPANY_SIMPLE_TEXT_HEADING);
                AddDataToField(wait, LOCATOR_OFFERSIMPLETXT_DESC_FIELD, COMPANY_SIMPLE_TEXT_DESCRIPTION);
            }
            else if(facnytext == true)
            {
                ClickOnDropDown(wait, LOCATOR_OFFERADDELEMENT_DROPDOWN);
                SelectFromDropDown(wait, "Fancy text");
                Thread.Sleep(10000);
                AddDataToField(wait, LOCATOR_OFFERFANCYTXT_HEADING_FIELD, COMPANY_FANCY_TEXT_HEADING);
                AddDataToField(wait, LOCATOR_OFFERFANCYTXT_DESC_SUMMERNOTE, COMPANY_FANCY_TEXT_DESCRIPTION);
            }
            else if (carousel == true)
            {
                ClickOnDropDown(wait, LOCATOR_OFFERADDELEMENT_DROPDOWN);
                SelectFromDropDown(wait, "Carousel");
                Thread.Sleep(10000);
                UploadAnImage(driver, LOCATOR_OFFERCAROUSEL_IMG_UPLOADER, PrimaryImage);
            }
            else if (turtldocument == true)
            {
                ClickOnDropDown(wait, LOCATOR_OFFERADDELEMENT_DROPDOWN);
                SelectFromDropDown(wait, "Turtl document");
                Thread.Sleep(4000);
                AddDataToField(wait, LOCATOR_OFFERTURTLDOC_DISPLAYNAME_FIELD, "Turtl document");
                AddDataToField(wait, LOCATOR_OFFERTURTLDOC_SRCURL_FIELD, TURTL_DOCUMENT_URL);
                //AddDataToField(wait, LOCATOR_OFFERTURTLDOC_WIDTH_FIELD, TURTL_DOCUMENT_WIDTH);
                //AddDataToField(wait, LOCATOR_OFFERTURTLDOC_HEIGHT_FIELD, TURTL_DOCUMENT_HEIGHT);
            }
        }
        /// <summary>
        /// Method to navigate to the offer compose page
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="wait"></param>
        protected static void NavigateToOfferIndexPage(IWebDriver driver, WebDriverWait wait)
        {
            ClickOnNavBarLink(wait, LOCATOR_AUCTIONMANAGEMENT_LINK);
            Thread.Sleep(2000);
            ScrollToElement(driver, wait, LOCATOR_OFFERS_SUBLINK);
            ClickOnNavBarLink(wait, LOCATOR_OFFERS_SUBLINK);
            ClickOnAddButton(wait);
            //wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".blockUI.blockOverlay")));
            // Wait for the overlay to disappear
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.CssSelector(".blockUI.blockOverlay")));
            Thread.Sleep(12000);
        }
    }
}
