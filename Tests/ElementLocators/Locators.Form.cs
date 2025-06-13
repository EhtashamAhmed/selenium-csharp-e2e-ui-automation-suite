using System;
using System.Collections.Generic;
using System.Text;

namespace SquarebookAutomation.Tests.ElementLocators
{
    public partial class Locators : Configurations
    {
        //FormComposeLocators
        protected const string LOCATOR_FORMDETAILS_TAB = "//h6[text()='Form details']";
        protected const string LOCATOR_FORMTITLE_FIELD = "//input[@id='__clubname' or @placeholder = 'Enter form title']";
        protected const string LOCATOR_FORMICON_UPLOADER = "//input[@name='formlogoImageUpload']";
        protected const string LOCATOR_FORMSTAGE_DROPDOWN = "//span[text()='Stage']//following::span[@class='select2-selection__rendered']";
        protected const string LOCATOR_FORMSTAGECONFIRM_BUTTON = "//button[text()='Confirm']";
        protected const string LOCATOR_CONTEXT_FIELD = "//textarea[@placeholder='Enter context']";
        protected const string LOCATOR_FORMBUILDER_TAB = "//h6[text()='Form builder']";
        protected const string LOCATOR_ADDBIDDINGITEMS_BUTTON = "//button[contains(text(),'bidding related items')]";
        protected const string LOCATOR_ADDITEM_BUTTON = "//button[contains(text(),'Add item')]";
        protected const string LOCATOR_ADDPAGE_BUTTON = "//button[contains(text(),'Add page')]";
        protected const string LOCATOR_EDITGROUP_BUTTON = "//div[@title='Edit group']";
        protected const string LOCATOR_FORMSAVE_BUTTON = "//button[text()='Save' and @title='Save form']";
        protected const string LOCATOR_FORMCANCEL_BUTTON = "//button[text()='Cancel' and @title='Go back']";

        //FormIteamModalLocators
        protected const string LOCATOR_ITEMTYPE_FIELD = "(//span[@class='select2-selection__rendered'])[1]";
        protected const string LOCATOR_ITEMTITLE_FIELD = "//textarea[@id='Title' and @placeholder = 'Enter title']";
        protected const string LOCATOR_SUBTITLE_FIELD = "//textarea[@id='Title' and @placeholder = 'Enter subtitle']";
        protected const string LOCATOR_REQUIRED_CHECKBOX = "//input[@id='Required']";
        protected const string LOCATOR_ADDEXTENSION_DROPDOWN = "//span[@id='select2-__itemextensionselect-container']";
        protected const string LOCATOR_NUMBERDEFAULTVALUE_FIELD = "//input[@type='number']";
        protected const string LOCATOR_ITEMSUBTITLE_FIELD = "//input[@type='text' and @placeholder='Enter subtitle' and @id='subtitle' and @class='form-control']";
        protected const string LOCATOR_ITEMSAVE_BUTTON = "//button[text()='Save' and @title='Save item']";
        protected const string LOCATOR_ITEMCANCEL_BUTTON = "//button[text()='Cancel' and @title='Close modal']";

        //PageItemsModalLocators
        protected const string LOCATOR_FORMPAGETITLE_FIELD = "(//span[@class='select2-selection__rendered'])[1]";
        protected const string LOCATOR_FORMPAGEDESCRIPTION_FIELD = "//textarea[@id='Title' and @placeholder = 'Enter title']";
        protected const string LOCATOR_FORMPAGESAVE_BUTTON = "//button[text()='Save' and @title='Save Page']";
        protected const string LOCATOR_FORMPAGECANCEL_BUTTON = " //button[text()='Cancel' and @title='Close Modal']";
        protected const string LOCATOR_FORMPAGEDELETE_BUTTON = " //button[text()='Delete' and @title='Delete page']";
    }
}
