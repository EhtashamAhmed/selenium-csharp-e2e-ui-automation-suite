using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquarebookAutomation.Tests.ElementLocators
{
    public partial class Locators : Configurations
    {
        protected const string LOCATOR_TOWNHALL_TITLE_FIELD = "//h5[text()='Townhall']//following::input[@placeholder='Enter title'][1]";
        protected const string LOCATOR_TOWNHALL_STARTSAT_DATE_FIELD = "//h5[text()='Townhall']//following::span[text()='Starts at'][1]//following::input[@title='Select a date'][1]";
        protected const string LOCATOR_TOWNHALL_STARTSAT_TIME_FIELD = "//h5[text()='Townhall']//following::span[text()='Starts at'][1]//following::input[@title='Select a time'][1]";
        protected const string LOCATOR_TOWNHALL_ENDSAT_DATE_FIELD = "//h5[text()='Townhall']//following::span[text()='Ends at'][1]//following::input[@title='Select a date'][1]";
        protected const string LOCATOR_TOWNHALL_ENDSAT_TIME_FIELD = "//h5[text()='Townhall']//following::span[text()='Ends at'][1]//following::input[@title='Select a time'][1]";
        protected const string LOCATOR_TOWNHALL_ORGANISERS_MULTISELECT = "//h5[text()='Townhall']//following::span[text()='Organisers'][1]//following::li[@class='select2-search select2-search--inline'][1]";
        protected const string LOCATOR_TOWNHALL_REMOVEALL_ORGANISERS_BUTTON = "//h5[text()='Townhall']//following::span[text()='Organisers'][1]//following::i[@title='Remove all selections'][1]";
        protected static string LOCATOR_TOWNHALL_MEETINGSLOT_ADD_BUTTON = "//h5[text()='Townhall']//following::i[@title='Add meeting slot']";
        protected const string LOCATOR_TOWNHALL_MEETINGSLOT_EDIT_BUTTON = "//h5[text()='Townhall']//following::i[@title='Edit row'][1]";
        protected const string LOCATOR_TOWNHALL_MEETINGSLOT_DELETE_BUTTON = "//h5[text()='Townhall']//following::i[@title='Delete row'][1]";
        protected const string LOCATOR_TOWNHALL_INVITES_MULTISELECT = "//h5[text()='Townhall']//following::span[text()='Invites'][1]//following::li[@class='select2-search select2-search--inline'][1]";

        protected const string LOCATOR_TOWNHALL_ATTENDEESLIMIT_FIELD = "//h5[text()='Townhall']//following::input[@placeholder='Attendees limit'][1]";
        protected const string LOCATOR_TOWNHALL_DESCRIPTION_FIELD = "//h5[text()='Townhall']//following::div[@class='note-editable' and @role='textbox'][1]";
        protected const string LOCATOR_TOWNHALL_STATE_DROPDOWN = "//h5[text()='Townhall']//following::span[text()='State']//following::span[@class='select2-selection__rendered'][1]";
        protected const string LOCATOR_TOWNHALL_TYPE_DROPDOWN = "//h5[text()='Townhall']//following::span[text()='Type']//following::span[@class='select2-selection__rendered'][1]";
        protected const string LOCATOR_TOWNHALL_URL_FIELD = "//h5[text()='Townhall']//following::input[@placeholder='https://']";
        protected const string LOCATOR_TOWNHALL_ADDRESS_FIELD = "//h5[text()='Townhall']//following::input[@placeholder='Address'][1]";
        protected const string LOCATOR_TOWNHALL_CITY_FIELD = "//h5[text()='Townhall']//following::input[@placeholder='City'][1]";
        protected const string LOCATOR_TOWNHALL_COUNTRY_FIELD = "//h5[text()='Townhall']//following::input[@placeholder='Country'][1]";
        protected const string LOCATOR_TOWNHALL_POSTALCODE_FIELD = "//h5[text()='Townhall']//following::input[@placeholder='Postal code'][1]";
        protected static string LOCATOR_TOWNHALL_SUBMIT_BUTTON = "//h5[text()='Townhall']//following::button[@title='Save townhall meeting'][1]";
        protected static string LOCATOR_TOWNHALL_CANCEL_BUTTON = "//h5[text()='Townhall']//following::button[@title='Cancel'][1]";
    }
}
