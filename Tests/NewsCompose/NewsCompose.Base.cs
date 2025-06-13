using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SquarebookAutomation.Tests.NewsCompose
{
    public class NewsComposeBase : Base
    {
        /// <summary>
        /// Common method to create a News
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="wait"></param>
        protected static void CreateANews(IWebDriver driver, WebDriverWait wait, string newsTitle, string newsSummary, string newsDescription, bool isNewsPublished)
        {
            NavigateToNewsManagement(driver, wait);
            NavigateToNewsCreationComposePage(wait);
            if(CheckForTemporarilySavedDataFoundPopup(wait)==true)
            {
                StartFreshNewsPage(wait);
            }
            AddDataToField(wait, LOCATOR_NEWS_HEADING_FIELD, newsTitle);
            AddDataToField(wait, LOCATOR_NEWS_SUMMARY_FIELD, newsSummary);
            AddDataToField(wait, LOCATOR_NEWS_DESCRIPTION_SUMMERNOTE, newsDescription);
            ClickOnButton(wait, LOCATOR_NEWS_PUBLISHNEWSITEM_CHECKBOX);
            UploadAnImage(driver, LOCATOR_NEWS_ICON_UPLOADER, PrimaryImage);
            AddDataToField(wait, LOCATOR_NEWS_SOURCELINK_FIELD, AppURL);
            ClickOnButton(wait, LOCATOR_NEWS_SAVE_BTN);
        }
        /// <summary>
        /// Common method to navigate to the News index page
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="wait"></param>
        protected static void NavigateToNewsManagement(IWebDriver driver, WebDriverWait wait)
        {
            ClickOnNavBarLink(wait, LOCATOR_NEWS_MANAGEMENT_LINK);
            ScrollToElement(driver, wait, LOCATOR_NEWS_LINK);
            ClickOnNavBarLink(wait, LOCATOR_NEWS_LINK);
        }
        /// <summary>
        /// Method to navigate to the News compose page from News index page
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="wait"></param>
        protected static void NavigateToNewsCreationComposePage(WebDriverWait wait)
        {
            ClickOnAddButton(wait);
            Thread.Sleep(4000);
        }
        /// <summary>
        /// Method to check if an already saved data/draft on News creation page exists
        /// </summary>
        /// <param name="wait"></param>
        /// <returns></returns>
        protected static bool CheckForTemporarilySavedDataFoundPopup(WebDriverWait wait)
        {
            return CheckIfElementExists(wait, LOCATOR_NEWSPOPUP_IUNDERSTAND_CHECKBOX);
        }
        /// <summary>
        /// Method to start fresh on the news creation page if any data is found
        /// </summary>
        /// <param name="wait"></param>
        protected static void StartFreshNewsPage(WebDriverWait wait)
        {
            Thread.Sleep(2000);
            ClickOnButton(wait, LOCATOR_NEWSPOPUP_IUNDERSTAND_CHECKBOX);
            ClickOnButton(wait, LOCATOR_NEWSPOPUP_STARTFRESH_BTN);
        }
        /// <summary>
        /// Method to continue with the already found data on News creation page
        /// </summary>
        /// <param name="wait"></param>
        protected static void ContinueWithExistingDate(WebDriverWait wait)
        {
            ClickOnButton(wait, LOCATOR_NEWSPOPUP_CONTINUEEDITING_BTN);
        }
    }
}
