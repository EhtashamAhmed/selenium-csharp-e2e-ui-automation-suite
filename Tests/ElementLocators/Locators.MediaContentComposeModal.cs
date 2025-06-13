using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquarebookAutomation.Tests.ElementLocators
{
    public partial class Locators : Configurations
    {
        protected const string LOCATOR_MEDIACONTENT_TITLE_FIELD = "//h5[text()='Media content']//following::input[@placeholder='Enter title'][1]";
        protected const string LOCATOR_MEDIACONTENT_URL_FIELD = "//h5[text()='Media content']//following::input[@placeholder='https://'][1]";
        protected const string LOCATOR_MEDIACONTENT_DESCRIPTION_FIELD = "//h5[text()='Media content']//following::div[@class='note-editable' and @role='textbox'][1]";
        protected const string LOCATOR_MEDIACONTENT_STATE_DROPDOWN = "//h5[text()='Media content']//following::span[text()='State'][1]//following::span[@class='select2-selection__rendered'][1]";
        protected const string LOCATOR_MEDIACONTENT_TYPE_DROPDOWN = "//h5[text()='Media content']//following::span[text()='Type'][1]//following::span[@class='select2-selection__rendered'][1]";
        protected const string LOCATOR_MEDIACONTENT_INVITES_MULTISELECT = "//h5[text()='Media content']//following::span[text()='Invites'][1]//following::li[@class='select2-search select2-search--inline'][1]";
        protected static string LOCATOR_MEDIACONTENT_SUBMIT_BUTTON = "//h5[text()='Media content']//following::button[@title='Save media content'][1]";
        protected static string LOCATOR_MEDIACONTENT_CANCEL_BUTTON = "//h5[text()='Media content']//following::button[@title='Cancel'][1]";
    }
}
