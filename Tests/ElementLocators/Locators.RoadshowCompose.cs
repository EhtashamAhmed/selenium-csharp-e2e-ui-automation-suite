using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquarebookAutomation.Tests.ElementLocators
{
    public partial class Locators : Configurations
    {
        protected const string LOCATOR_ROADSHOWTITLE_FIELD = "//Input[@id='Title'][1]";
        protected const string LOCATOR_ROADSHOW_DESCRIPTION_FIELD = "(//div[@class='note-editable' and @role='textbox'])[1]";
        protected const string LOCATOR_ROADSHOW_COMPANY_DROPDOWN = "//span[text()='Company']//following::span[@class='select2-selection__rendered'][1]";
        protected const string LOCATOR_ROADSHOW_ORGANISERS_MULTISELECT = "(//li[@class='select2-search select2-search--inline'])[1]";
        protected const string LOCATOR_ROADSHOW_REMOVEALL_ORGANISERS_BUTTON = "(//span[text()='Organisers'])[1]//following::i[@title='Remove all selections'][1]";
        protected static string LOCATOR_ROADSHOW_MEETINGSLOT_ADD_BUTTON = "//span[text()='{0}']//following::i[@title='Add meeting slot']";
        protected const string LOCATOR_ROADSHOW_MEETINGSLOT_EDIT_BUTTON = "//span[text()='{0}']//following::i[@title='Edit row'][1]";
        protected const string LOCATOR_ROADSHOW_MEETINGSLOT_DELETE_BUTTON = "//span[text()='{0}']//following::i[@title='Delete row'][1]";
        protected const string LOCATOR_ROADSHOWICON_UPLOADER = "//input[@name='IconUplaod']";
        protected const string LOCATOR_ROADSHOW_IS_REFERANINVESTORLINK_CHECKBOX = "//span[text()='Icon']//following::span[@class='roadshow-compose-checkbox-below']";
        protected const string LOCATOR_ROADSHOW_DATE_FIELD = "//span[text()='Date']//following::input[@title='Select a date'][1]";
        protected const string LOCATOR_ROADSHOW_STATE_DROPDOWN = "//span[text()='Roadshow state']//following::span[@class='select2-selection__rendered'][1]";
        protected const string LOCATOR_ROADSHOW_INVESTORRESTRICTION_DROPDOWN = "//span[text()='Investor restriction']//following::span[@class='select2-selection__rendered'][1]";
        
        protected const string LOCATOR_ROADSHOW_ADD_TOWNHALL_BUTTON = "//i[@title='Add townhall meeting'][1]";
        protected const string LOCATOR_ROADSHOW_TOWNHALL_EDIT_BUTTON = "//span[text()='{0}'][1]//following::i[@title='Edit row'][1]";
        protected const string LOCATOR_ROADSHOW_TOWNHALL_DELETE_BUTTON = "//span[text()='{0}'][1]//following::i[@title='Delete row'][1]";

        protected const string LOCATOR_ROADSHOW_ADD_MEDIACONTENT_BUTTON = "//i[@title='Add media content'][1]";
        protected const string LOCATOR_ROADSHOW_MEDIACONTENT_EDIT_BUTTON = "//span[text()='{0}']//following::span[text()='TitleMedia'][1]//following::i[@title='Edit row'][1]";
        protected const string LOCATOR_ROADSHOW_MEDIACONTENT_DELETE_BUTTON = "//span[text()='{0}']//following::span[text()='TitleMedia'][1]//following::i[@title='Delete row'][1]";

        protected const string LOCATOR_ROADSHOW_SAVE_BUTTON = "//button[@title='Create roadshow']";
        protected const string LOCATOR_ROADSHOW_CANCEL_BUTTON = "//button[@title='Go back']";
    }
}
