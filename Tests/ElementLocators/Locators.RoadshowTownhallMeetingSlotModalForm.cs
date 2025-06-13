using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquarebookAutomation.Tests.ElementLocators
{
    public partial class Locators : Configurations
    {
        protected const string LOCATOR_ROADSHOWTOWNHALL_MEETINGSLOT_TITLE_FIELD = "//h5[text()='Meeting details']//following::input[@placeholder='Title'][1]";
        protected const string LOCATOR_ROADSHOWTOWNHALL_MEETINGSLOT_MEETING_DATE_FIELD = "//h5[text()='Meeting details']//following::input[@title='Select a date'][1]";
        protected const string LOCATOR_ROADSHOWTOWNHALL_MEETINGSLOT_STARTSAT_FIELD = "//h5[text()='Meeting details']//following::span[text()='Starts at'][1]//following::input[@title='Select a time'][1]";
        protected const string LOCATOR_ROADSHOWTOWNHALL_MEETINGSLOT_ENDSAT_FIELD = "//h5[text()='Meeting details']//following::span[text()='Ends  at'][1]//following::input[@title='Select a time'][1]";
        
        protected const string LOCATOR_ROADSHOWTOWNHALL_MEETINGSLOT_ONLINE_CHECKBOX = "//h5[text()='Meeting details']//following::*[contains(text(),'Online')]";
        protected const string LOCATOR_ROADSHOWTOWNHALL_MEETINGSLOT_URL_FIELD = "//h5[text()='Meeting details']//following::input[@placeholder='URL']";
        protected const string LOCATOR_ROADSHOWTOWNHALL_MEETINGSLOT_PHONE_CHECKBOX = "//h5[text()='Meeting details']//following::*[contains(text(),'Phone')][1]";
        protected const string LOCATOR_ROADSHOWTOWNHALL_MEETINGSLOT_PHONENUMBER_FIELD = "//h5[text()='Meeting details']//following::input[@placeholder='Phone number']";
        protected const string LOCATOR_ROADSHOWTOWNHALL_MEETINGSLOT_INPERSON_CHECKBOX = "//h5[text()='Meeting details']//following::*[contains(text(),'In person')][1]";
        protected const string LOCATOR_ROADSHOWTOWNHALL_MEETINGSLOT_ADDRESS_FIELD = "//h5[text()='Meeting details']//following::input[@placeholder='Number, building name, street etc']";
        protected const string LOCATOR_ROADSHOWTOWNHALL_MEETINGSLOT_MEETINGSTATE_DROPDOWN = "//span[text()='Meeting state']//following::span[@class='select2-selection__rendered'][1]";
        protected const string LOCATOR_ROADSHOWTOWNHALL_MEETINGSLOT_MEETING_ATTENDEESLIMIT_FIELD = "//h5[text()='Meeting details']//following::input[@placeholder='Attendees limit'][1]";
        protected const string LOCATOR_ROADSHOWTOWNHALL_MEETINGSLOT_CITY_FIELD = "//h5[text()='Meeting details']//following::input[@placeholder='City'][1]";
        protected const string LOCATOR_ROADSHOWTOWNHALL_MEETINGSLOT_COUNTRY_FIELD = "//h5[text()='Meeting details']//following::input[@placeholder='Country'][1]";
        protected const string LOCATOR_ROADSHOWTOWNHALL_MEETINGSLOT_POSTALCODE_FIELD = "//h5[text()='Meeting details']//following::input[@placeholder='Postal code'][1]";
        protected static string LOCATOR_ROADSHOW_MEETINGSLOT_SUBMIT_BUTTON = "//h5[text()='Meeting details']//following::button[@title='Save the meeting slot'][1]";
        protected static string LOCATOR_ROADSHOW_MEETINGSLOT_CANCEL_BUTTON = "//h5[text()='Meeting details']//following::button[@title='Cancel'][1]";

    }
}
