using System;
using System.Collections.Generic;
using System.Text;

namespace SquarebookAutomation.Tests.ElementLocators
{
    public partial class Locators : Configurations
    {
        //Details
        protected const string LOCATOR_TRANCHEDETAILS_TAB = "//h6[text()='Details']";
        protected const string LOCATOR_TRANCHENAME_FIELD = "//input[@placeholder='Enter the tranche name']";
        protected const string LOCATOR_TRANCHEOFFERS_DROPDOWN = "//span[text()='Offers']//following::span[@class='select2-selection__rendered'][1]";
        protected const string LOCATOR_TRANCHEROUND_DROPDOWN = "//span[text()='Round']//following::span[@class='select2-selection__rendered'][1]";
        protected const string LOCATOR_TRANCHENUMBEROFSHARES_FIELD = "//input[@id='sharesinclub']";
        protected const string LOCATOR_MAXSHARESPERMEMBER_FIELD = "//input[@placeholder='Enter the maximum number of shares']";
        protected const string LOCATOR_TRANCHEORGANISATIONTYPERESTRICTION_DROPDOWN = "//span[text()='Organisation type restriction']//following::span[@class='select2-selection__rendered'][1]";
        protected const string LOCATOR_TRANCHEPOINTSINTHRESH_FIELD = "//input[@id='pointsinthreshold']";
        protected const string LOCATOR_TRANCHEMAXIMUMMEMBERS_FIELD = "//input[@id='maxinummembers']";
        protected const string LOCATOR_ACTIVEICON_UPLOADER = "//input[@name='activeicon']";
        protected const string LOCATOR_INACTIVEICON_UPLOADER = "//input[@name='inactiveicon']";
        protected const string LOCATOR_TRANCHESAVE_BUTTON = "//button[text()='Save' and @title='Save tranche']";
        protected const string LOCATOR_TRANCHECANCEL_BUTTON = "//button[text()='Cancel']";

        //Prizes
        protected const string LOCATOR_TRANCHEPRIZES_TAB = "//h6[text()='Prizes']";
        protected const string LOCATOR_ADDNEWPRIZE_BUTTON = "//button[@title='Add new prize']";
        protected const string LOCATOR_PRIZEDESCRIPTION_FIELD = "(//input[@placeholder='Enter prize description'])[last()]";
        protected const string LOCATOR_PRIZEPREFERENCEFACTOR_FIELD = "//input[@placeholder='Enter preference factor']";
        protected const string LOCATOR_PRIZEPERCENTAGEDISC_FIELD = "//input[@placeholder='Enter percentage discount']";
        protected const string LOCATOR_PRIZEPERCENTAGEFREESHARES_FIELD = "//input[@placeholder='Enter free shares']";

        //Rules
        protected const string LOCATOR_TRANCHERULES_TAB = "//h6[text()='Rules']";
        protected const string LOCATOR_ADDRULE_DROPDOWN = "//label[text()='Add rule:']//following::span[@class='select2-selection__rendered'][1]";
        protected const string LOCATOR_RULEDESCRIPTION_FIELD = "(//input[@placeholder='Enter rule description'])[last()]";
        protected const string LOCATOR_RULEPOINTS_FIELD = "(//input[@placeholder='Enter rule points'])[last()]";
        protected const string LOCATOR_CUSTOMRULE_TEXTAREA = "//textarea[1]";
        protected const string LOCATOR_RULEQUESTIONNAIRE_DROPDOWN = "(//span[text()='Questionnaire'])[last()]//following::span[@class='select2-selection__rendered'][1]";
        protected const string LOCATOR_RULESHARES_FIELD = "(//span[text()='Shares'])[last()]//following::input[1]";
        protected const string LOCATOR_NHIGHESTBIDS_FIELD = "//span[text()='N highest bids']//following::input[1]";
        protected const string LOCATOR_TRANCHEFLAG_DROPDOWN = "(//span[text()='Flag'])[last()]//following::span[@class='select2-selection__rendered'][1]";
        protected const string LOCATOR_ITEM_DROPDOWN = "(//span[text()='Item'])[last()]//following::span[@class='select2-selection__rendered'][1]";
        protected const string LOCATOR_RULEBENCHMARK_FIELD = "(//span[text()='Benchmark'])[last()]//following::input[1]";
    }
}
