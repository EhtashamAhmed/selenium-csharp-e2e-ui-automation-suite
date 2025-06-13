using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SquarebookAutomation.Tests.Company
{
    public partial class CompanyBase : Base
    {
        /// <summary>
        /// Generic function to create a company
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="wait"></param>
        /// <param name="CompanyType">Type of the company Private or Public</param>
        /// <param name="Issuer">Issuer of the company</param>
        /// <param name="SecondaryEnabled">True or False based on allowing company to hold secondary</param>
        /// <param name="ListedSecEnabled">True or False based on enabling the listed securities for the company</param>
        /// <param name="status">Status of the company either Published or Unpublished</param>
        protected static void CreateACompany(IWebDriver driver,
            WebDriverWait wait,
            string CompanyType,
            string Issuer, bool SecondaryEnabled,
            bool ListedSecEnabled,
            string status)
        {
            //Details tab
            ClickOnNavBarLink(wait, LOCATOR_COMPANYMANAGEMENT_LINK);
            ClickOnNavBarLink(wait, LOCATOR_COMPANIES_SUBLINK);
            ClickOnAddButton(wait);
            Thread.Sleep(3000);
            AddDataToField(wait, LOCATOR_COMPANYTITLE_FIELD, $"{COMPANY_TITLE} {Uniqueness}");
            AddDataToField(wait, LOCATOR_SUMMARY_FIELD, COMPANY_SUMMARY);
            UploadAnImage(driver, LOCATOR_ICONIMG_UPLOADER, PrimaryImage);
            UploadAnImage(driver, LOCATOR_BACKGROUNDIMG_UPLOADER, SecondaryImage);
            ClickOnDropDown(wait, LOCATOR_CURRENCY_DROPDOWN);
            SelectFromDropDown(wait, "Dollar");
            ReplacingDataOfAField(wait, LOCATOR_COMPANYMINSIZERANGE_FIELD, "10");
            ReplacingDataOfAField(wait, LOCATOR_COMPANYMAXSIZERANGE_FIELD, "20");

            if (CompanyType == "Private")
            {
                ClickOnDropDown(wait, LOCATOR_TYPE_DROPDOWN);
                SelectFromDropDown(wait, "Private");
            }
            ClickOnDropDown(wait, LOCATOR_ADVISORS_MULTISELECT);
            SelectFromDropDown(wait, $"{ADVISOR_ORG_NAME} {Uniqueness}");
            //ClickOnDropDown(wait, LOCATOR_MARKERS_MULTISELECT);
            //SelectFromDropDown(wait, $"{MARKERTITLE} {Uniqueness}");
            ClickOnDropDown(wait, LOCATOR_ISSUER_DROPDOWN);
            SelectFromDropDown(wait, Issuer);
            if (SecondaryEnabled == true)
            {
                ClickOnButton(wait, LOCATOR_ENABLESECONDARY_CHECKBOX);
            }
            if (ListedSecEnabled == true)
            {
                ClickOnButton(wait, LOCATOR_LISTEDSECURITIES_CHECKBOX);
            }
            if (status == "Unpublished")
            {
                ClickOnDropDown(wait, LOCATOR_STATUS_DROPDOWN);
                SelectFromDropDown(wait, "Unpublished");
            }
            ScrollToElement(driver,wait, LOCATOR_COMPANYDESCRIPTION_TAB);

            //Description tab
            ClickOnButton(wait, LOCATOR_COMPANYDESCRIPTION_TAB);
            //Simple Text
            ClickOnDropDown(wait, LOCATOR_COMPANYADDELEMENT_DROPDOWN);
            SelectFromDropDown(wait, "Simple text");
            Thread.Sleep(4000);
            AddDataToField(wait, LOCATOR_COMPANYSIMPLETXT_HEADING_FIELD, COMPANY_SIMPLE_TEXT_HEADING);
            AddDataToField(wait, LOCATOR_COMPANYSIMPLETXT_DESC_FIELD, COMPANY_SIMPLE_TEXT_DESCRIPTION);
            //Fancy Text
            ClickOnDropDown(wait, LOCATOR_COMPANYADDELEMENT_DROPDOWN);
            SelectFromDropDown(wait, "Fancy text");
            Thread.Sleep(10000);
            AddDataToField(wait, LOCATOR_COMPANYFANCYTXT_HEADING_FIELD, COMPANY_FANCY_TEXT_HEADING);
            AddDataToField(wait, LOCATOR_COMPANYFANCYTXT_DESC_SUMMERNOTE, COMPANY_FANCY_TEXT_DESCRIPTION);
            //Carousel
            ClickOnDropDown(wait, LOCATOR_COMPANYADDELEMENT_DROPDOWN);
            SelectFromDropDown(wait, "Carousel");
            Thread.Sleep(10000);
            UploadAnImage(driver, LOCATOR_COMPANYCAROUSEL_IMG_UPLOADER, PrimaryImage);
            //Turtle Document
            ClickOnDropDown(wait, LOCATOR_COMPANYADDELEMENT_DROPDOWN);
            SelectFromDropDown(wait, "Turtl document");
            Thread.Sleep(4000);
            AddDataToField(wait, LOCATOR_COMPANYTURTLDOCDISPLAYNAME_SRCURL_FIELD, "Turtl document");
            AddDataToField(wait, LOCATOR_COMPANYTURTLDOC_SRCURL_FIELD, TURTL_DOCUMENT_URL);
            //AddDataToField(wait, LOCATOR_COMPANYTURTLDOC_WIDTH_FIELD, TURTL_DOCUMENT_WIDTH);
            //AddDataToField(wait, LOCATOR_COMPANYTURTLDOC_HEIGHT_FIELD, TURTL_DOCUMENT_HEIGHT);
            ScrollToElement(driver,wait, LOCATOR_COMPANYDOCUMENTS_TAB);
            //Documents tab
            ClickOnButton(wait, LOCATOR_COMPANYDOCUMENTS_TAB);
            UploadAnImage(driver, LOCATOR_NDAUPLOAD_FIELD, SamplePDF);
            ClickOnButton(wait, LOCATOR_COMPANYADDDOCUMENT_BUTTON);
            AddDataToField(wait, LOCATOR_DOCUMENTTITLE_FIELD, DOCUMENT_TITLE);
            UploadAnImage(driver, LOCATOR_COMPANYSELECTDOCUMENT_FIELD, SampleDocument);
            Thread.Sleep(4000);
            ScrollToElement(driver,wait, LOCATOR_COMPANYVIDEOS_TAB);
            //Videos tab
            ClickOnButton(wait, LOCATOR_COMPANYVIDEOS_TAB);
            ClickOnButton(wait, LOCATOR_COMPANYADDVIDEO_BUTTON);
            AddDataToField(wait, LOCATOR_COMPANYVIDEOTITLE_FIELD, VIDEO_TITLE);
            UploadAnImage(driver, LOCATOR_COMPANYSELECTVIDEO_FIELD, SampleVideo);
            Thread.Sleep(4000);
            ScrollToElement(driver,wait, LOCATOR_COMPANYTAGS_TAB);
            //Tags tab
            ClickOnButton(wait, LOCATOR_COMPANYTAGS_TAB);
            ClickOnButton(wait, LOCATOR_COMPANYEXPANDTAGCATEGORIES_BUTTON);
            ClickOnButton(wait, LOCATOR_COMPANYSPECIFICTAG_BUTTON);
            ClickOnButton(wait, LOCATOR_COMPANYSAVE_BUTTON);
            Thread.Sleep(2000);
        }
    }
}
