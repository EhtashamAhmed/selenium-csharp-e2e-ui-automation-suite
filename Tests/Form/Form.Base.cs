using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SquarebookAutomation.Tests.Form
{
    public partial class FormBase : Base
    {
        /// <summary>
        /// General method to create a new form with a number item in it
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="wait"></param>
        protected static void CreateAForm(IWebDriver driver, WebDriverWait wait)
        {
            ClickOnNavBarLink(wait, LOCATOR_FORMMANAGEMENT_LINK);
            ClickOnNavBarLink(wait, LOCATOR_FORMS_SUBLINK);
            ClickOnAddButton(wait);
            AddDataToField(wait, LOCATOR_FORMTITLE_FIELD, $"{FORM_TITLE} {Uniqueness}");
            UploadAnImage(driver, LOCATOR_FORMICON_UPLOADER, FORM_ICON);
            ClickOnDropDown(wait, LOCATOR_FORMSTAGE_DROPDOWN);
            SelectFromDropDown(wait, "Published and locked");
            ClickOnButton(wait, LOCATOR_FORMSTAGECONFIRM_BUTTON);
            AddDataToField(wait, LOCATOR_CONTEXT_FIELD, FORM_CONTEXT);
            ClickOnButton(wait, LOCATOR_FORMBUILDER_TAB);
            ClickOnButton(wait, LOCATOR_ADDITEM_BUTTON);
            AddDataToField(wait, LOCATOR_ITEMTITLE_FIELD, FORM_ITEM_TITLE);
            ClickOnButton(wait, LOCATOR_REQUIRED_CHECKBOX);
            ClickOnDropDown(wait, LOCATOR_ADDEXTENSION_DROPDOWN);
            SelectFromDropDown(wait, "Number");
            AddDataToField(wait, LOCATOR_ITEMSUBTITLE_FIELD, FORM_NUMBER_ITEM_SUBTITLE);
            ClickOnButton(wait, LOCATOR_ITEMSAVE_BUTTON);
            Thread.Sleep(2000);
            ClickOnButton(wait, LOCATOR_FORMSAVE_BUTTON);
        }
        /// <summary>
        /// General method to create a new form with a bidding related items in it
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="wait"></param>
        protected static void CreateABiddingForm(IWebDriver driver, WebDriverWait wait)
        {
            ClickOnNavBarLink(wait, LOCATOR_FORMMANAGEMENT_LINK);
            ClickOnNavBarLink(wait, LOCATOR_FORMS_SUBLINK);
            ClickOnAddButton(wait);
            AddDataToField(wait, LOCATOR_FORMTITLE_FIELD, $"{FORM_TITLE}Bidding {Uniqueness}");
            UploadAnImage(driver, LOCATOR_FORMICON_UPLOADER, FORM_ICON);
            AddDataToField(wait, LOCATOR_CONTEXT_FIELD, FORM_CONTEXT);
            ClickOnButton(wait, LOCATOR_FORMBUILDER_TAB);
            ClickOnButton(wait, LOCATOR_ADDBIDDINGITEMS_BUTTON);
            ClickOnButton(wait, LOCATOR_EDITGROUP_BUTTON);
            ClickOnButton(wait, LOCATOR_FORMPAGEDELETE_BUTTON);
            ClickOnButton(wait, LOCATOR_FORMSAVE_BUTTON);
        }
    }
}
