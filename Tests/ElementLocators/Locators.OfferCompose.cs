using System;
using System.Collections.Generic;
using System.Text;

namespace SquarebookAutomation.Tests.ElementLocators
{
    public partial class Locators : Configurations
    {
        //Details
        protected const string LOCATOR_OFFERDETAILS_TAB = "//h6[text()='Details']";
        protected const string LOCATOR_ISSUETYPE_DROPDOWN = "//span[text()='Issue type']//following::span[@class='select2-selection__rendered'][1]";
        protected const string LOCATOR_OFFERNAME_FIELD = "//span[text()='Name']//following::input[@id='name'][1]";
        protected const string LOCATOR_OFFERSUMMARY_FIELD = "//textarea[@placeholder='Enter summary']";
        protected const string LOCATOR_OFFERWEBURL_FIELD = "//input[@placeholder='https://']";
        protected const string LOCATOR_OFFEREXECUTIONROUTES_MULTISELECT = "(//span[text()='Execution routes'])[last()]//following::span[@class='select2-selection select2-selection--multiple'][1]";
        protected const string LOCATOR_OFFERSETTLEMENTROUTES_MULTISELECT = "(//span[text()='Settlement routes'])[last()]//following::span[@class='select2-selection select2-selection--multiple'][1]";
        protected const string LOCATOR_OFFERDUEDILIGENCE_DROPDOWN = "//span[text()='Customer due diligence']//following::span[@class='select2-selection__rendered'][1]";
        protected const string LOCATOR_OFFERSTARTDATE_FIELD = "//span[text()='Start date']//following::input[@title='Select a date'][1]";
        protected const string LOCATOR_OFFERSTARTTIME_FIELD = "//span[text()='Start date']//following::input[@title='Select a time'][1]";
        protected const string LOCATOR_OFFERENDDATE_FIELD = "//span[text()='End date']//following::input[@title='Select a date'][1]";
        protected const string LOCATOR_OFFERENDTIME_FIELD = "//span[text()='End date']//following::input[@title='Select a time'][1]";
        protected const string LOCATOR_NOOFSHARES_FIELD = "//span[text()='Number of shares in offer']//following::input[@type='number'][1]";
        protected const string LOCATOR_OFFERCURRENCY_DROPDOWN = "//span[text()='Currency']//following::span[@class='select2-selection__rendered'][1]";
        protected const string LOCATOR_OFFERCOMPANY_DROPDOWN = "//span[text()='Company']//following::span[@class='select2-selection__rendered'][1]";
        protected const string LOCATOR_PERMMINRANGE_FIELD = "//input[@id='min-textbox-kt_nouislider_14']";
        protected const string LOCATOR_PERMMAXRANGE_FIELD = "//input[@id='max-textbox-kt_nouislider_14']";
        protected const string LOCATOR_PUBLISHEDMINRANGE_FIELD = "//input[@id='min-textbox-kt_nouislider_15']";
        protected const string LOCATOR_PUBLISHEDMAXRANGE_FIELD = "//input[@id='max-textbox-kt_nouislider_15']";
        protected const string LOCATOR_HEADERICON_UPLOADER = "//input[@name='headerIconUpload']";
        protected const string LOCATOR_HEADERBACKGROUND_UPLOADER = "//input[@name='headerBackgroundUpload']";
        protected const string LOCATOR_OFFERSTATUS_DROPDOWN = "//span[text()='Offer status']//following::span[@class='select2-selection__rendered'][1]";
        protected const string LOCATOR_OFFERISPUBLIC_CHECKBOX = "//span[text()='Offer status']//following::span[@class='margin-below-checkbox']";
        protected const string LOCATOR_SHOWTRADESYMBOL_CHECKBOX = "//span[text()='Make this offer public']//following::span[@class='margin-below-checkbox']";
        protected const string LOCATOR_TRADESYMBOL_FIELD = "//span[text()='Trade symbol']//following::input[@id='name'][1]";
        protected const string LOCATOR_OFFERVISIBILITY_DROPDOWN = "//span[text()='Offer visibility']//following::span[@class='select2-selection__rendered'][1]";
        protected const string LOCATOR_OFFERMARKERS_MULTISELECT = "(//span[text()='Markers'])[last()]//following::span[@class='select2-selection select2-selection--multiple'][1]";
       
        protected const string LOCATOR_OFFERINVITATIONSACCESS_DROPDOWN = "//span[text()='Invitations access']//following::span[@class='select2-selection__rendered'][1]";
        protected const string LOCATOR_OFFERADVISORS_MULTISELECT = "//span[text()='Advisors']//following::span[@class='select2-selection select2-selection--multiple'][1]";
        
        protected const string LOCATOR_OFFERINVESTORORGANIZATIONS_MULTISELECT = "//span[text()='Investor organisations']//following::span[@class='select2-selection select2-selection--multiple'][1]";
        protected const string LOCATOR_OFFERADVISORUSERINVITES_MULTISELECT = "(//span[text()='Email notifications'])[1]//following::span[@class='select2-selection select2-selection--multiple'][1]";
       
        protected const string LOCATOR_OFFERISSUERINVITES_MULTISELECT = "//span[text()='Issuer investor invites']//following::span[@class='select2-selection select2-selection--multiple'][1]";
        protected const string LOCATOR_OFFERISSUERUSERINVITES_MULTISELECT = "(//span[text()='Email notifications'])[last()]//following::span[@class='select2-selection select2-selection--multiple'][1]";

        protected const string LOCATOR_RANKINGNOTIFICATIONSCHEDULE_DROPDOWN = "//span[text()='Ranking notification schedule']//following::span[@class='select2-selection__rendered'][1]";
        protected const string LOCATOR_ENABLEEMAILNOTIFICATIONS_CHECKBOX = "//div[contains(text(),'Notification on')]//following::input[1]";
        protected const string LOCATOR_ADDRANKINGNOTIFICATION_BUTTON = "//button[@title='Add an offer report notification']";
        protected const string LOCATOR_RANKINGNOTIFICATIONSTARTDATE_FIELD = "//span[text()='Start date and time']//following::input[@title='Select a date'][1]";
        protected const string LOCATOR_RANKINGNOTIFICATIONSTARTTIME_FIELD = "//span[text()='Start date and time']//following::input[@title='Select a time'][1]";
        protected const string LOCATOR_RANKINGNOTIFICATIONREPEATSAFTER_DROPDOWN = "//span[text()='Repeat after']//following::span[@class='select2-selection__rendered'][1]";

        protected const string LOCATOR_OFFERSAVE_BUTTON = "//button[text()='Save' and @title='Create offer']";
        protected const string LOCATOR_OFFERCANCEL_BUTTON = "//button[text()='Cancel' and @title='Go back']";  

        //Description
        protected const string LOCATOR_OFFERDESCRIPTION_TAB = "//h6[text()='Description']";
        protected const string LOCATOR_OFFERADDELEMENT_DROPDOWN = "//span[text()='Add element']//following::span[@class='select2-selection__rendered'][1]";
        protected const string LOCATOR_OFFERSIMPLETXT_HEADING_FIELD = "//b[text()='Simple text']//following::input[@id='__SimpleTextHeading'][1]";
        protected const string LOCATOR_OFFERSIMPLETXT_DESC_FIELD = "//b[text()='Simple text']//following::textarea[@placeholder='Enter description'][1]";
        protected const string LOCATOR_OFFERFANCYTXT_HEADING_FIELD = "//b[text()='Fancy text']//following::input[@id='__SimpleTextHeading'][1]";
        protected const string LOCATOR_OFFERFANCYTXT_DESC_SUMMERNOTE = "//b[text()='Fancy text']//following::div[@class='note-editable' and @role='textbox'][1]";
        protected const string LOCATOR_OFFERCAROUSEL_HEADING_FIELD = "//b[text()='Carousel']//following::input[@id='__SimpleTextHeading'][1]";
        protected const string LOCATOR_OFFERCAROUSEL_DESC_SUMMERNOTE = "//b[text()='Carousel']//following::div[@class='note-editable' and @role='textbox'][1]";
        protected const string LOCATOR_OFFERCAROUSEL_IMG_UPLOADER = "//b[text()='Carousel']//following::span[text()='Select photo']//following::input[@accept='image/*']";
        protected const string LOCATOR_OFFERADDCAROUSEL_BUTTON = "//b[text()='Carousel']//following::span[text()='Select photo']//following::button[@title='Add new slide']";
        protected const string LOCATOR_OFFERTURTLDOC_DISPLAYNAME_FIELD = "//b[text()='Turtl document']//following::input[@id='__SimpleTextHeading'][1]";
        protected const string LOCATOR_OFFERTURTLDOC_SRCURL_FIELD = "//b[text()='Turtl document']//following::input[@id='__TurtlDocumentSrc'][1]";
        protected const string LOCATOR_OFFERTURTLDOC_WIDTH_FIELD = "//b[text()='Turtl document']//following::input[@id='__TurtlDocumentWidth'][1]";
        protected const string LOCATOR_OFFERTURTLDOC_HEIGHT_FIELD = "//b[text()='Turtl document']//following::input[@id='__TurtlDocumentHeight'][1]";


        //Auction rounds
        protected const string LOCATOR_AUCTION_ROUNDS_TAB = "//h6[text()='Auction rounds']";
        protected const string LOCATOR_ADD_AUCTIONROUND_BUTTON = "//button[@title='Add new auction round']";

        protected static string LOCATOR_ROUND_TITLE_FIELD = "//span[contains(text(),'Round {0}')]//following::input[@placeholder='Enter title'][1]";
        protected static string LOCATOR_ROUND_SUMMARY_FIELD = "//span[contains(text(),'Round {0}')]//following::textarea[@placeholder='Enter summary'][1]";
        protected static string LOCATOR_ROUND_INVITATIONACCESS_DROPDOWN = "//span[contains(text(),'Round {0}')]//following::span[text()='Invitations access']//following::span[@class='select2-selection__rendered'][1]";

        protected static string LOCATOR_ROUND_ADVISORS_MULTISELECT = "//span[contains(text(),'Round {0}')]//following::span[text()='Advisors']//following::span[@class='select2-selection select2-selection--multiple'][1]";

        // Round advisor investor invites
        protected static string LOCATOR_ROUND_ADVISOR_INVESTORORGANIZATIONS_MULTISELECT = "//span[contains(text(),'Round {0}')]//following::span[text()='Investor organisations']//following::span[@class='select2-selection select2-selection--multiple'][1]";
        protected static string LOCATOR_ROUND_ADVISOR_INVESTOR_EMAILNOTIFICATIONS_MULTISELECT = "(//span[contains(text(),'Round {0}')]//following::span[text()='Email notifications'])[1]//following::span[@class='select2-selection select2-selection--multiple'][1]";
        protected static string LOCATOR_ROUND_ADD_ALL_INVESTORUSERS_TOEMAILNOTIFICATIONS_FOR_ADVISORS_BUTTON = "(//span[contains(text(),'Round {0}')]//following::i[@title='Select all options'])[1]";

        // Round advisor advocates invites
        protected static string LOCATOR_ROUND_ADVISOR_ADVOCATEORGANIZATIONS_MULTISELECT = "//span[contains(text(),'Round {0}')]//following::span[text()='Advocate organisations']//following::span[@class='select2-selection select2-selection--multiple'][1]";
        protected static string LOCATOR_ROUND_ADVISOR_ADVOCATE_EMAILNOTIFICATIONS_MULTISELECT = "(//span[contains(text(),'Round {0}')]//following::span[text()='Advocate organisations']//following::span[text()='Email notifications'])[1]//following::span[@class='select2-selection select2-selection--multiple'][1]";
        protected static string LOCATOR_ROUND_ADDALL_ADVOCATEUSERS_TOEMAILNOTIFICATIONS_FOR_ADVISORS_BUTTON = "(//span[contains(text(),'Round {0}')]//following::span[text()='Advocate organisations']//following::i[@title='Select all options'])[1]";

        // Round issuer investor invites
        protected static string LOCATOR_ROUND_ISSUER_INVESTORORGANIZATIONS_MULTISELECT = "//span[contains(text(),'Round {0}')]//following::span[text()='Issuer investor invites']//following::span[@class='select2-selection select2-selection--multiple'][1]";
        protected static string LOCATOR_ROUND_ISSUER_INVESTOR_EMAILNOTIFICATIONS_MULTISELECT = "(//span[contains(text(),'Round {0}')]//following::span[text()='Issuer investor invites']//following::span[text()='Email notifications'])[1]//following::span[@class='select2-selection select2-selection--multiple'][1]";
        protected static string LOCATOR_ROUND_ADDALL_INVESTORUSERS_TOEMAILNOTIFICATIONS_FOR_ISSUER_BUTTON = "//span[contains(text(),'Round {0}')]//following::span[text()='Issuer investor invites']//following::i[@title='Select all options'][1]";

        // Round advocate advocates invites
        protected static string LOCATOR_ROUND_ISSUER_ADVOCATEORGANIZATIONS_MULTISELECT = "//span[contains(text(),'Round {0}')]//following::span[text()='Issuer investor invites']//following::span[text()='Issuer advocate invites']//following::span[@class='select2-selection select2-selection--multiple'][1]";
        protected static string LOCATOR_ROUND_ISSUER_ADVOCATE_EMAILNOTIFICATIONS_MULTISELECT = "//span[contains(text(),'Round {0}')]//following::span[text()='Issuer investor invites']//following::span[text()='Issuer advocate invites']//following::span[text()='Email notifications']//following::span[@class='select2-selection select2-selection--multiple'][1]";
        protected static string LOCATOR_ROUND_ADDALL_ADVOCATEUSERS_TOEMAILNOTIFICATIONS_FORISSUER_BUTTON = "(//span[contains(text(),'Round {0}')]//following::span[text()='Issuer investor invites']//following::span[text()='Issuer advocate invites']//following::span[text()='Email notifications']//following::i[@title='Select all options'])[1]";

        protected static string LOCATOR_ROUND_ACTIVITIES_DROPDOWN = "//span[contains(text(),'Round {0}')]//following::span[text()='Activities']//following::span[@class='select2-selection select2-selection--multiple'][1]";
        protected static string LOCATOR_ROUND_COMPUTE_ISSUEPRICE_CHECKBOX = "//span[contains(text(),'Round {0}')]//following::span[text()='Activities']//following::span[@class='margin-below-checkbox']";
        protected static string LOCATOR_ROUND_ISSUEPRICE_FIELD = "//span[contains(text(),'Round {0}')]//following::span[text()='Issue price']//following::input[1]";
        protected static string LOCATOR_ROUND_STAGE_DROPDOWN = "//span[contains(text(),'Round {0}')]//following::span[text()='Stage']//following::span[@class='select2-selection__rendered'][1]";

        protected static string LOCATOR_ROUND_RANKING_NOTIFICATION_SCHEDULE_DROPDOWN = "//span[contains(text(),'Round {0}')]//following::span[text()='Ranking notification schedule']//following::span[@class='select2-selection__rendered'][1]";
        protected static string LOCATOR_ROUND_ENABLE_EMAILNOTIFICATIONS_CHECKBOX = "//span[contains(text(),'Round {0}')]//following::div[contains(text(),'Notification on')]//following::input[1]";
        protected static string LOCATOR_ROUND_ADD_RANKING_NOTIFICATION_BUTTON = "//span[contains(text(),'Round {0}')]//following::button[@title='Add an offer report notification']";
        protected static string LOCATOR_ROUND_RANKING_NOTIFICATION_STARTDATE_FIELD = "//span[contains(text(),'Round {0}')]//following::span[text()='Start date and time']//following::input[@title='Select a date'][1]";
        protected static string LOCATOR_ROUND_RANKING_NOTIFICATION_STARTTIME_FIELD = "//span[contains(text(),'Round {0}')]//following::span[text()='Start date and time']//following::input[@title='Select a time'][1]";
        protected static string LOCATOR_ROUND_RANKINGNOTIFICATION_REPEATSAFTER_DROPDOWN = "//span[contains(text(),'Round {0}')]//following::span[text()='Repeat after']//following::span[@class='select2-selection__rendered'][1]";
        protected static string LOCATOR_ROUND_IS_FINALROUND_CHECKBOX = "//span[contains(text(),'Round {0}')]//following::*[contains(text(),'Is it final round')]";
                     
        //Document Library
        protected const string LOCATOR_OFFERDOCUMENTS_TAB = "//h6[text()='Document library']";
        protected const string LOCATOR_OFFERADDDOCUMENT_BUTTON = "//h6[text()='Document library']//following::button[@title='Add new document']";
        protected const string LOCATOR_OFFERDOCUMENTTITLE_FIELD = "//h6[text()='Document library']//following::span[text()='Document 1']//following::input[1]";
        protected const string LOCATOR_OFFERSELECTDOCUMENT_FIELD = "//input[@accept='.docx,.xlsx,.pdf,.xlsb']";

        //Video Library
        protected const string LOCATOR_OFFERVIDEOS_TAB = "//h6[text()='Video library']";
        protected const string LOCATOR_OFFERADDVIDEO_BUTTON = "//h6[text()='Video library']//following::button[@title='Add new video']";
        protected const string LOCATOR_OFFERVIDEOTITLE_FIELD = "//h6[text()='Video library']//following::span[text()='Video 1']//following::input[1]";
        protected const string LOCATOR_OFFERSELECTVIDEO_FIELD = "//input[@accept='.mp4,.MP4']";

        //Allocation Policy
        protected const string LOCATOR_ALLOCATIONPOLICY_TAB = "//h6[text()='Allocation policy']";
        protected const string LOCATOR_ALLOCPOLICY_SUMMERNOTE = "//h6[text()='Allocation policy']//following::div[@class='note-editable'][last()]";

        //Tags
        protected const string LOCATOR_OFFERTAGS_TAB = "//h6[text()='Tags']";
        protected const string LOCATOR_OFFEREXPANDTAGCATEGORIES_BUTTON = "//h6[text()='Tags']//following::a[@title='Expand all categories']";
        protected const string LOCATOR_OFFERCOLLAPSETAGCATEGORIES_BUTTON = "//h6[text()='Tags']//following::a[@title='Collapse all categories']";
        protected static string LOCATOR_OFFERSPECIFICTAG_BUTTON = $"//h6[text()='Tags']//following::button[text()='{$"{TAG_NAME} {Uniqueness}"}']";
    }
}
