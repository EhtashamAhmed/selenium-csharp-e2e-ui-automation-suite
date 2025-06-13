using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SquarebookAutomation.Tests.Tag
{
    public partial class TagBase : Base
    {
        /// <summary>
        /// Generic method for creating a new tag category
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="wait"></param>
        protected static void CreateATagCategory(IWebDriver driver, WebDriverWait wait)
        {
            ClickOnNavBarLink(wait, LOCATOR_COMPANYMANAGEMENT_LINK);
            ScrollToElement(driver, wait, LOCATOR_TAGS_LINK);
            ClickOnNavBarLink(wait, LOCATOR_TAGS_LINK);
            ClickOnAddButton(wait);
            ClickOnButton(wait, LOCATOR_ADDNEWTAGCATEGORY_BUTTON);
            AddDataToField(wait, LOCATOR_TAGCATNAME_FIELD, $"{TAG_CATEGORY_NAME} {Uniqueness}");
            ClickOnButton(wait, LOCATOR_TAGCATSAVE_BUTTON);
            Thread.Sleep(3000);
        }
        /// <summary>
        /// Generic method for creating a new tag
        /// </summary>
        /// <param name="wait"></param>
        protected static void CreateATag(IWebDriver driver, WebDriverWait wait)
        {
            ClickOnNavBarLink(wait, LOCATOR_COMPANYMANAGEMENT_LINK);
            ScrollToElement(driver, wait, LOCATOR_TAGS_LINK);
            ClickOnNavBarLink(wait, LOCATOR_TAGS_LINK);
            ClickOnAddButton(wait);
            ClickOnButton(wait, LOCATOR_ADDNEWTAG_BUTTON);
            AddDataToField(wait, LOCATOR_TAGNAME_FIELD, $"{TAG_NAME} {Uniqueness}");
            ClickOnButton(wait, LOCATOR_TAGSAVE_BUTTON);
            Thread.Sleep(3000);
            ClickOnButton(wait, LOCATOR_TAGMODALSAVE_BUTTON);
            Thread.Sleep(3000);
        }
    }
}
