using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SquarebookAutomation.Tests.RoadshowCompose
{
    public partial class RoadshowBase : Base
    {
        /// <summary>
        /// General method to create a roadshow with default organiser and no townhall or meeting slot or media content
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="wait"></param>
        /// <param name="roadshowName">Name of the roadshow</param>
        /// <param name="companyName">Name of company</param>
        /// <param name="roadshowState">State of the roadshow either Published | Unpublished | Canceled </param>
        /// <param name="roadshowInvestorRestriction">Restriction either Institutional inestor | Private investor | None </param>
        protected static void CreateARoadshow(IWebDriver driver, WebDriverWait wait,
                string roadshowName,
                string companyName,
                string roadshowState,
                string roadshowInvestorRestriction
                )
        {
            NavigateToRoadshowComposePage(driver, wait);
            AddDataToField(wait, LOCATOR_ROADSHOWTITLE_FIELD, roadshowName);
            AddDataToField(wait, LOCATOR_ROADSHOW_DESCRIPTION_FIELD, COMPANY_SUMMARY);
            ClickOnDropDown(wait, LOCATOR_ROADSHOW_COMPANY_DROPDOWN);
            SelectFromDropDown(wait, companyName);                       
            if(roadshowState=="Published")
            {
                ClickOnDropDown(wait, LOCATOR_ROADSHOW_STATE_DROPDOWN);
                SelectFromDropDown(wait, "Published");
            }
            else if (roadshowState == "Canceled")
            {
                ClickOnDropDown(wait, LOCATOR_ROADSHOW_STATE_DROPDOWN);
                SelectFromDropDown(wait, "Canceled");
            }
            if (roadshowInvestorRestriction == "None")
            {
                ClickOnDropDown(wait, LOCATOR_ROADSHOW_INVESTORRESTRICTION_DROPDOWN);
                SelectFromDropDown(wait, "None");
            }
            else if (roadshowInvestorRestriction == "Institutional investors")
            {
                ClickOnDropDown(wait, LOCATOR_ROADSHOW_INVESTORRESTRICTION_DROPDOWN);
                SelectFromDropDown(wait, "Institutional investors");
            }
            else if (roadshowInvestorRestriction == "Private investors")
            {
                ClickOnDropDown(wait, LOCATOR_ROADSHOW_INVESTORRESTRICTION_DROPDOWN);
                SelectFromDropDown(wait, "Private investors");
            }
            ClickOnButton(wait, LOCATOR_ROADSHOW_SAVE_BUTTON);
        }

        /// <summary>
        /// General roadshow creation override method to create a roadshow with the provided organiser
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="wait"></param>
        /// <param name="roadshowName"></param>
        /// <param name="companyName"></param>
        /// <param name="roadshowOrganiser">Organiser name for the Roadshow</param>
        /// <param name="roadshowState">State of the roadshow either Published | Unpublished | Canceled </param>
        /// <param name="roadshowInvestorRestriction">Restriction either Institutional inestor | Private investor | None </param>
        protected static void CreateARoadshow(IWebDriver driver, WebDriverWait wait,
                string roadshowName,
                string companyName,
                string roadshowOrganiser,
                string roadshowState,
                string roadshowInvestorRestriction
                )
        {
            NavigateToRoadshowComposePage(driver, wait);
            AddDataToField(wait, LOCATOR_ROADSHOWTITLE_FIELD, roadshowName);
            AddDataToField(wait, LOCATOR_ROADSHOW_DESCRIPTION_FIELD, COMPANY_SUMMARY);
            ClickOnDropDown(wait, LOCATOR_ROADSHOW_COMPANY_DROPDOWN);
            SelectFromDropDown(wait, companyName);
            if (roadshowOrganiser != null)
            {
                ClickOnButton(wait, LOCATOR_ROADSHOW_REMOVEALL_ORGANISERS_BUTTON);
                ClickOnDropDown(wait, LOCATOR_ROADSHOW_ORGANISERS_MULTISELECT);
                SelectFromDropDown(wait, roadshowOrganiser);
            }
            if (roadshowState == "Published")
            {
                ClickOnDropDown(wait, LOCATOR_ROADSHOW_STATE_DROPDOWN);
                SelectFromDropDown(wait, "Published");
            }
            else if (roadshowState == "Canceled")
            {
                ClickOnDropDown(wait, LOCATOR_ROADSHOW_STATE_DROPDOWN);
                SelectFromDropDown(wait, "Canceled");
            }
            if (roadshowInvestorRestriction == "None")
            {
                ClickOnDropDown(wait, LOCATOR_ROADSHOW_INVESTORRESTRICTION_DROPDOWN);
                SelectFromDropDown(wait, "None");
            }
            else if (roadshowInvestorRestriction == "Institutional investors")
            {
                ClickOnDropDown(wait, LOCATOR_ROADSHOW_INVESTORRESTRICTION_DROPDOWN);
                SelectFromDropDown(wait, "Institutional investors");
            }
            else if (roadshowInvestorRestriction == "Private investors")
            {
                ClickOnDropDown(wait, LOCATOR_ROADSHOW_INVESTORRESTRICTION_DROPDOWN);
                SelectFromDropDown(wait, "Private investors");
            }
            ClickOnButton(wait, LOCATOR_ROADSHOW_SAVE_BUTTON);
        }
        /// <summary>
        /// General over ride method for creating a roadshow with a townhall in it
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="wait"></param>
        /// <param name="roadshowName">Name of roadshow</param>
        /// <param name="companyName">Company linked to the roadshow</param>
        /// <param name="roadshowOrganiser">Organiser user of the roadshow</param>
        /// <param name="roadshowState">Publshed | Unpblished | Canceled </param>
        /// <param name="roadshowInvestorRestriction">Institutional inestor | Private investor | None </param>
        /// <param name="townhallTitle">Title of the townhall</param>
        /// <param name="townhallEndDate">Ending date of the townhall</param>
        /// <param name="townhallEndTime">Ending time of the townhall</param>
        /// <param name="townhallAttendeeLimit">Total attendees limit</param>
        /// <param name="townhallState"> Publshed | Unpblished | Canceled </param>
        /// <param name="townhallInvite">Name of the user to be added in the townhall invites</param>
        /// <param name="townhallType"> Physical | Virtual | Both </param>
        /// <param name="townhallAddress">Address of the townhall if the type is Physical</param>
        protected static void CreateARoadshow(IWebDriver driver, WebDriverWait wait,
                string roadshowName,
                string companyName,
                string roadshowOrganiser,
                string roadshowState,
                string roadshowInvestorRestriction,
                string townhallTitle,
                string townhallEndDate,
                string townhallEndTime,
                int townhallAttendeeLimit,
                string townhallState,
                string townhallInvite,
                string townhallType,
                string townhallAddress  
                )
        {
            NavigateToRoadshowComposePage(driver, wait);
            AddDataToField(wait, LOCATOR_ROADSHOWTITLE_FIELD, roadshowName);
            AddDataToField(wait, LOCATOR_ROADSHOW_DESCRIPTION_FIELD, COMPANY_SUMMARY);
            ClickOnDropDown(wait, LOCATOR_ROADSHOW_COMPANY_DROPDOWN);
            SelectFromDropDown(wait, companyName);
            if (roadshowOrganiser != null)
            {
                ClickOnButton(wait, LOCATOR_ROADSHOW_REMOVEALL_ORGANISERS_BUTTON);
                ClickOnDropDown(wait, LOCATOR_ROADSHOW_ORGANISERS_MULTISELECT);
                SelectLastFoundFromDropDown(wait, roadshowOrganiser);
            }
            if (roadshowState == "Published")
            {
                ClickOnDropDown(wait, LOCATOR_ROADSHOW_STATE_DROPDOWN);
                SelectFromDropDown(wait, "Published");
            }
            else if (roadshowState == "Canceled")
            {
                ClickOnDropDown(wait, LOCATOR_ROADSHOW_STATE_DROPDOWN);
                SelectFromDropDown(wait, "Canceled");
            }
            if (roadshowInvestorRestriction == "None")
            {
                ClickOnDropDown(wait, LOCATOR_ROADSHOW_INVESTORRESTRICTION_DROPDOWN);
                SelectFromDropDown(wait, "None");
            }
            else if (roadshowInvestorRestriction == "Institutional investors")
            {
                ClickOnDropDown(wait, LOCATOR_ROADSHOW_INVESTORRESTRICTION_DROPDOWN);
                SelectFromDropDown(wait, "Institutional investors");
            }
            else if (roadshowInvestorRestriction == "Private investors")
            {
                ClickOnDropDown(wait, LOCATOR_ROADSHOW_INVESTORRESTRICTION_DROPDOWN);
                SelectFromDropDown(wait, "Private investors");
            }

            AddATownhall(driver, wait,
                townhallTitle,
                townhallEndDate,
                townhallEndTime,
                townhallInvite,
                townhallAttendeeLimit,
                townhallState,
                townhallType,
                townhallAddress
             );

            ClickOnButton(wait, LOCATOR_ROADSHOW_SAVE_BUTTON);
        }
        /// <summary>
        /// General method for adding a townhall while creating a roadshow
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="wait"></param>
        /// <param name="townhallTitle">Title of the townhall</param>
        /// <param name="townhallEndDate">Ending date of the townhall</param>
        /// <param name="townhallEndTime">Ending time of the townhall</param>
        /// <param name="townhallAttendeeLimit">Total attendees limit</param>
        /// <param name="townhallState"> Publshed | Unpblished | Canceled </param>
        /// <param name="townhallInvite">Name of the user to be added in the townhall invites</param>
        /// <param name="townhallType"> Physical | Virtual | Both </param>
        /// <param name="townhallAddress">Address of the townhall if the type is Physical</param>
        /// <param name="townhallURL">URL of the townhall if type is Virtual</param>
        /// <param name="townhallCity">Optioal city name</param>
        /// <param name="townhallCountryURL">Optional country name</param>
        /// <param name="townhallPostalcode">Postal code </param>
        protected static void AddATownhall(IWebDriver driver, WebDriverWait wait,
            string townhallTitle,
            string townhallEndDate,
            string townhallEndTime,
            string townhallInivite,
            int townhallAttendeeLimit,
            string townhallState = "Published",
            string townhallType = "Physical",
            string townhallAddress = null,
            string townhallURL = null,
            string townhallCity = null,
            string townhallCountryURL = null,
            string townhallPostalcode = null

            )
        {
            ClickOnButton(wait, LOCATOR_ROADSHOW_ADD_TOWNHALL_BUTTON);
            AddDataToField(wait, LOCATOR_TOWNHALL_TITLE_FIELD, townhallTitle);
            ClearDataOfAField(wait, LOCATOR_TOWNHALL_ENDSAT_DATE_FIELD);
            AddDataToField(wait, LOCATOR_TOWNHALL_ENDSAT_DATE_FIELD, townhallEndDate);
            ClearDataOfAField(wait, LOCATOR_TOWNHALL_ENDSAT_TIME_FIELD);
            HitEnterKey(wait, LOCATOR_TOWNHALL_ENDSAT_DATE_FIELD);
            AddDataToField(wait, LOCATOR_TOWNHALL_ENDSAT_TIME_FIELD, townhallEndTime);
            ClickOnDropDown(wait, LOCATOR_TOWNHALL_INVITES_MULTISELECT);
            SelectLastFoundFromDropDown(wait, townhallInivite);
            AddDataToField(wait, LOCATOR_TOWNHALL_ATTENDEESLIMIT_FIELD, townhallAttendeeLimit.ToString());
            AddDataToField(wait, LOCATOR_TOWNHALL_DESCRIPTION_FIELD, COMPANY_FANCY_TEXT_DESCRIPTION);
            ClickOnDropDown(wait, LOCATOR_TOWNHALL_STATE_DROPDOWN);
            SelectFromDropDown(wait, townhallState);
            AddDataToField(wait, LOCATOR_TOWNHALL_ADDRESS_FIELD, townhallAddress);
            ClickOnButton(wait, LOCATOR_TOWNHALL_SUBMIT_BUTTON);
            Thread.Sleep(2000);
        }

        /// <summary>
        /// General method for navigating to the Index page of the roadshow
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="wait"></param>
        protected static void NavigateToRoadshowIndexPage(IWebDriver driver, WebDriverWait wait)
        {
            ClickOnNavBarLink(wait, LOCATOR_COMPANYMANAGEMENT_LINK);
            Thread.Sleep(2000);
            ScrollToElement(driver, wait, LOCATOR_ROADSHOWS_SUBLINK);
            ClickOnNavBarLink(wait, LOCATOR_ROADSHOWS_SUBLINK);
            Thread.Sleep(4000);
        }

        /// <summary>
        /// General method for navigating to the compose page of the Roadshow
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="wait"></param>
        protected static void NavigateToRoadshowComposePage(IWebDriver driver, WebDriverWait wait)
        {
            NavigateToRoadshowIndexPage(driver, wait);            
            ClickOnAddButton(wait);
            Thread.Sleep(4000);
        }
    }
}
