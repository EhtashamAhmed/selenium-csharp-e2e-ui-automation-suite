using System;
using System.Collections.Generic;
using System.Text;

namespace SquarebookAutomation.Tests.ElementLocators
{
    public partial class Locators : Configurations
    {
        //Details
        protected const string LOCATOR_DETAILS_TAB = "//h6[text()='Details']";
        protected const string LOCATOR_COMPANYTITLE_FIELD = "//input[@placeholder='Enter company title']";
        protected const string LOCATOR_SUMMARY_FIELD = "//textarea[@placeholder='Enter summary']";
        protected const string LOCATOR_ICONIMG_UPLOADER = "//input[@name='companyImageUplaod']";
        protected const string LOCATOR_BACKGROUNDIMG_UPLOADER = "//input[@name='companyBackgroundImageUplaod']";
        protected const string LOCATOR_CURRENCY_DROPDOWN = "//span[text()='Currency']//following::span[@class='select2-selection__rendered'][1]";
        protected const string LOCATOR_COMPANYMINSIZERANGE_FIELD = "//input[@title='Minimum size range']";
        protected const string LOCATOR_COMPANYMAXSIZERANGE_FIELD = "//input[@title='Maximum size range']";
        protected const string LOCATOR_TYPE_DROPDOWN = "//span[text()='Type']//following::span[@class='select2-selection__rendered'][1]";
        protected const string LOCATOR_ADVISORS_MULTISELECT = "//span[text()='Advisors']//following::span[@class='select2-selection select2-selection--multiple'][1]";
        protected const string LOCATOR_SETTLEMENTROUTES_MULTISELECT = "//span[text()='Settlement routes']//following::span[@class='select2-selection select2-selection--multiple'][1]";
        protected const string LOCATOR_MARKERS_MULTISELECT = "(//select[@id='offerMarkers'])//following::span[@class='select2-selection select2-selection--multiple'][1]";
        protected const string LOCATOR_ISSUER_DROPDOWN = "//span[text()='Issuer']//following::span[@class='select2-selection__rendered'][1]";
        protected const string LOCATOR_SHOWOBSFUCATEDINFO_CHECKBOX = "(//span[@class='margin-below-checkbox'])[3]";
        protected const string LOCATOR_ENABLEMERGERANDACQUISITION_CHECKBOX = "(//span[@class='margin-below-checkbox'])[4]";
        protected const string LOCATOR_ENABLESECONDARY_CHECKBOX = "(//span[@class='margin-below-checkbox'])[5]";
        protected const string LOCATOR_LISTEDSECURITIES_CHECKBOX = "(//span[@class='margin-below-checkbox'])[6]";
        protected const string LOCATOR_ENFORCESAMELEADADVISORS_CHECKBOX = "(//span[@class='margin-below-checkbox'])[7]";
        protected const string LOCATOR_STATUS_DROPDOWN = "//span[text()='Status']//following::span[@class='select2-selection__rendered'][1]";
        protected const string LOCATOR_LOCATION_DROPDOWN = "//span[text()='Location']//following::span[@class='select2-selection__rendered'][1]";
        protected const string LOCATOR_COMPANYSAVE_BUTTON = "//button[text()='Save' and @title='Save company']";
        protected const string LOCATOR_COMPANYCANCEL_BUTTON = "//button[text()='Cancel' and @title='Go back']";

        //Description
        protected const string LOCATOR_COMPANYDESCRIPTION_TAB = "//h6[text()='Description']";
        protected const string LOCATOR_COMPANYADDELEMENT_DROPDOWN = "//span[text()='Add element']//following::span[@class='select2-selection__rendered'][1]";
        protected const string LOCATOR_COMPANYSIMPLETXT_HEADING_FIELD = "//b[text()='Simple text']//following::input[@id='__SimpleTextHeading'][1]";
        protected const string LOCATOR_COMPANYSIMPLETXT_DESC_FIELD = "//b[text()='Simple text']//following::textarea[@placeholder='Enter description'][1]";
        protected const string LOCATOR_COMPANYFANCYTXT_HEADING_FIELD = "//b[text()='Fancy text']//following::input[@id='__SimpleTextHeading'][1]";
        protected const string LOCATOR_COMPANYFANCYTXT_DESC_SUMMERNOTE = "//b[text()='Fancy text']//following::div[@class='note-editable' and @role='textbox'][1]";
        protected const string LOCATOR_COMPANYCAROUSEL_HEADING_FIELD = "//b[text()='Carousel']//following::input[@id='__SimpleTextHeading'][1]";
        protected const string LOCATOR_COMPANYCAROUSEL_DESC_SUMMERNOTE = "//b[text()='Carousel']//following::div[@class='note-editable' and @role='textbox'][1]";
        protected const string LOCATOR_COMPANYCAROUSEL_IMG_UPLOADER = "//b[text()='Carousel']//following::span[text()='Select photo']//following::input[@accept='image/*']";
        protected const string LOCATOR_COMPANYADDCAROUSEL_BUTTON = "//b[text()='Carousel']//following::span[text()='Select photo']//following::button[@title='Add new slide']";
        protected const string LOCATOR_COMPANYTURTLDOCDISPLAYNAME_SRCURL_FIELD = "//b[text()='Turtl document']//following::input[@id='__SimpleTextHeading'][1]";
        protected const string LOCATOR_COMPANYTURTLDOC_SRCURL_FIELD = "//b[text()='Turtl document']//following::input[@id='__TurtlDocumentSrc'][1]";
        protected const string LOCATOR_COMPANYTURTLDOC_WIDTH_FIELD = "//b[text()='Turtl document']//following::input[@id='__TurtlDocumentWidth'][1]";
        protected const string LOCATOR_COMPANYTURTLDOC_HEIGHT_FIELD = "//b[text()='Turtl document']//following::input[@id='__TurtlDocumentHeight'][1]";

        //Documents
        protected const string LOCATOR_COMPANYDOCUMENTS_TAB = "//h6[text()='Documents']";
        protected const string LOCATOR_NDAUPLOAD_FIELD = "//input[@id='companyNDA']";

        protected const string LOCATOR_COMPANYADDDOCUMENT_BUTTON = "//h6[text()='Documents']//following::button[@title='Add new document']";
        protected const string LOCATOR_DOCUMENTTITLE_FIELD = "//h6[text()='Documents']//following::span[text()='Document 1']//following::input[1]";
        protected const string LOCATOR_COMPANYSELECTDOCUMENT_FIELD = "//input[@accept='.docx,.xlsx,.pdf,.xlsb']";


        //Videos
        protected const string LOCATOR_COMPANYVIDEOS_TAB = "//h6[text()='Videos']";
        protected const string LOCATOR_COMPANYADDVIDEO_BUTTON = "//h6[text()='Videos']//following::button[@title='Add new video']";
        protected const string LOCATOR_COMPANYVIDEOTITLE_FIELD = "//h6[text()='Videos']//following::span[text()='Video 1']//following::input[1]";
        protected const string LOCATOR_COMPANYSELECTVIDEO_FIELD = "//input[@accept='.mp4,.MP4']";

        //Tags
        protected const string LOCATOR_COMPANYTAGS_TAB = "//h6[text()='Tags']";
        protected const string LOCATOR_COMPANYEXPANDTAGCATEGORIES_BUTTON = "//h6[text()='Tags']//following::a[@title='Expand all categories']";
        protected const string LOCATOR_COMPANYCOLLAPSETAGCATEGORIES_BUTTON = "//h6[text()='Tags']//following::a[@title='Collapse all categories']";
        protected static string LOCATOR_COMPANYSPECIFICTAG_BUTTON = $"//h6[text()='Tags']//following::button[text()='{$"{TAG_NAME} {Uniqueness}"}']";
    }
}
