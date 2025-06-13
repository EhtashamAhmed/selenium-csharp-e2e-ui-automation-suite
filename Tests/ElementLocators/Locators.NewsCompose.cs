using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquarebookAutomation.Tests.ElementLocators
{
    public partial class Locators : Configurations
    {
        protected const string LOCATOR_NEWS_HEADING_FIELD = "//input[@placeholder='Enter news heading']";
        protected const string LOCATOR_NEWS_SUMMARY_FIELD = "//textarea[@placeholder='Enter summary']";
        protected const string LOCATOR_NEWS_DESCRIPTION_SUMMERNOTE = "//span[text()='Description']//following::div[@class='note-editable' and @role='textbox'][1]";
        protected const string LOCATOR_NEWS_PUBLISHNEWSITEM_CHECKBOX = "//span[@class='news-compose-checkbox-styling'][1]";
        protected const string LOCATOR_NEWS_ICON_UPLOADER = "//input[@name='newsItemImageUplaod']";
        protected const string LOCATOR_NEWS_SOURCELINK_FIELD = "//input[@placeholder='https://']";
        protected const string LOCATOR_NEWS_PUBLISHDATE_FIELD = "//span[text()='Published date and time']//following::input[@title='Select a date'][1]";
        protected const string LOCATOR_NEWS_PUBLISHTIME_FIELD = "//span[text()='Published date and time']//following::input[@title='Select a time'][1]";
        protected const string LOCATOR_NEWS_VISIBILITY_DROPDOWN = "//span[text()='Visibility']//following::span[@class='select2-selection__rendered'][1]";
        protected const string LOCATOR_NEWS_SHOWFILTERS_BTN = "//i[@title='Show filters' or @title='Hide filters']";
        protected const string LOCATOR_NEWS_FILTERPROPERTIES_BTN = "//span[text()='Properties']";
        protected const string LOCATOR_NEWS_CLEARALLFILTERS_BTN = "//button[text()='Clear all filters']";
        protected const string LOCATOR_NEWS_APPLYFILTERS_BTN = "//button[text()='Apply filters']";
        protected const string LOCATOR_NEWS_FILTER_ORGANISATIONS_DROPDOWN = "//label[text()='Organisations']//following::ul[@class='select2-selection__rendered'][1]";
        protected const string LOCATOR_NEWS_FILTER_ROLES_DROPDOWN = "(//label[text()='Roles'])[last()]//following::ul[@class='select2-selection__rendered'][1]";
        protected const string LOCATOR_NEWS_FILTER_ORGANISATIONTYPES_DROPDOWN = "(//label[text()='Organisation types'])[last()]//following::ul[@class='select2-selection__rendered'][1]";
        protected const string LOCATOR_NEWS_FILTER_SELECTUSERS_DROPDOWN = "//span[text()='Select users']//following::ul[@class='select2-selection__rendered'][1]";
        protected const string LOCATOR_NEWS_PREVIEW_BTN = "//button[contains(text(),'Preview')]";
        protected const string LOCATOR_NEWS_SAVEDRAFT_BTN = "//button[contains(text(),'Save as draft')]";
        protected const string LOCATOR_NEWS_SAVE_BTN = "//button[text()='Save and send notification']";
        protected const string LOCATOR_NEWS_CANCEL_BTN = "//button[text()='Cancel']";

        //Temporarily saved data found popup
        protected const string LOCATOR_NEWSPOPUP_IUNDERSTAND_CHECKBOX = "//span[contains(@title,'button will work when this checkbox will be checked')]";
        protected const string LOCATOR_NEWSPOPUP_CONTINUEEDITING_BTN = "//button[contains(text(),'Continue editing')]";
        protected const string LOCATOR_NEWSPOPUP_STARTFRESH_BTN = "//button[contains(text(),'Start fresh')]";
        protected const string LOCATOR_NEWSPOPUP_CANCEL_BTN = "(//button[@title='This will redirect you to the previous page'])[last()]";               
    }
}
