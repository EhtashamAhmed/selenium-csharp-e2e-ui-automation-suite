using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquarebookAutomation.Tests.ElementLocators
{
    public partial class Locators : Configurations
    {
        protected const string LOCATOR_NEWBID_BTN = "//span[contains(text(),'New bid')]";        
        protected const string LOCATOR_BIDEDIT_BTN = "//a[@title='Edit bid']";
        protected const string LOCATOR_BOOKBUILD_TAB = "//h6[text()='Book build']";
        protected const string LOCATOR_BOOKVALUATION_TAB = "//h6[text()='//h6[text()='Book valuation']']";
        protected const string LOCATOR_BIDHISTORY_TAB = "//h6[text()='//h6[text()='Bid history']']";
        protected const string LOCATOR_TRANCHEMEMBERSHIP_TAB = "//h6[text()='//h6[text()='Tranche membership']']";
        protected const string LOCATOR_QUESTIONNAIREANALYTICS_TAB = "//h6[text()='//h6[text()='Questionnaire analytics']']";
        protected const string LOCATOR_ANALYTICS_TAB = "//h6[text()='//h6[text()='Analytics']']";
        protected const string LOCATOR_ROUNDGATES_TAB = "//h6[text()='//h6[text()='Round gates']']";
        protected const string LOCATOR_AMENDMENTS_TAB = "//h6[text()='Amendments']";
        protected const string LOCATOR_CURRENTALLOCATIONS_TAB = "//h6[text()='Current allocations']";
        protected const string LOCATOR_AUCTIONPAGECANCEL_BTN = "//a[contains(text(),'Cancel')]";

        //Book build tab
        protected const string LOCATOR_OFFERTATUS_LABEL = "//span[text()='Offer status']//following::label[3]";
        protected const string LOCATOR_CHANGESTATUS_CHECKBOX = "//input[@type='checkbox']";
        protected const string LOCATOR_ISSUEPRICE_DROPDOWN = "//span[text()='Issue price']//following::span[@class='select2-selection__rendered'][1]";
        protected const string LOCATOR_BUILDBOOKD_BTN = "//span[contains(text(),'Build book')]";
        protected const string LOCATOR_VIEWBOOKD_BTN = "//span[contains(text(),'View book')]";
        protected const string LOCATOR_NTHHIGHEST_FIELD = "//input[@step]";
        protected const string LOCATOR_PROPOSEDPRICE_FIELD = "//span[text()='Proposed price']//following::input[1]";

        protected const string LOCATOR_SUMMARY_TAB = "//a[contains(text(),'Summary')]";
        protected const string LOCATOR_EXPORTTOEXCEL_BTN = "//span[text()='Offer status']//following::button[@title='Export to Excel'][1]";

        protected const string LOCATOR_CONFIRMATION_TAB = "//a[contains(text(),'Confirmations')]";

        protected const string LOCATOR_ADVISORS_TAB = "//a[contains(text(),'Advisors')]";
        protected const string LOCATOR_ADVISORSALLOCATION_DROPDOWN = "//span[@id='select2-__advisors-container']";
        
        protected const string LOCATOR_REFERRERS_TAB = "//a[contains(text(),'Referrers')]";
        protected const string LOCATOR_REFERRERSALLOCATION_DROPDOWN = "//span[@id='select2-__referrers-container']";
        
        protected const string LOCATOR_INTRODUCTIONREWARDS_TAB = "//a[contains(text(),'Introduction rewards')]";
        
        protected const string LOCATOR_INVESTORS_TAB = "//a[contains(text(),'Investors')]";
        protected const string LOCATOR_INVESTORSALLOCATION_DROPDOWN = "//span[@id='select2-__investors-container']";
        
        protected const string LOCATOR_TRANCHEALLOCATIONS_TAB = "//a[contains(text(),'Tranche allocations')]";
        protected const string LOCATOR_TRANCHEALLOCATIONS_DROPDOWN = "//span[@id='select2-__clubs-container']";

        protected const string LOCATOR_PREFERREDALLOCATIONS_TAB = "//a[contains(text(),'Preferred allocations')]";
        protected const string LOCATOR_GENERALALLOCATIONS_TAB = "//a[contains(text(),'General allocations')]";
        protected const string LOCATOR_ALLWINNINGBIDS_TAB = "//a[contains(text(),'All winning bids')]";
        protected const string LOCATOR_ALLAMENDMENTS_TAB = "//a[contains(text(),'All amendments')]";

        //Book valuation tab
        protected const string LOCATOR_VALUATIONMODE_DROPDOWN = "//span[text()='Valuation mode']//following::span[@class='select2-selection__rendered'][1]";
        protected const string LOCATOR_BUILDVALUATIONS_BTN = "//span[text()='Valuation mode']//following::button[@title='Export to Excel']";
        protected const string LOCATOR_CUSTOMVALUATIONSMINPRICE_FIELD = "//input[@id='min-textbox-Issue_price_range_slider']";
        protected const string LOCATOR_CUSTOMVALUATIONSMAXPRICE_FIELD = "//input[@id='max-textbox-Issue_price_range_slider']";

        //Questionnaire analytics tab
        protected const string LOCATOR_MODE_DROPDOWN = "//div[contains(text(),'Mode')]//following::span[@class='select2-selection__rendered'][1]";
        protected const string LOCATOR_OFFERQUESTIONNAIRE_DROPDOWN = "//div[contains(text(),'Questionnaires')]//following::span[@class='select2-selection__rendered'][1]";
    }
}
