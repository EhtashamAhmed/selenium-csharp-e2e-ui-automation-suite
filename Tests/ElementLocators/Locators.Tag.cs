using System;
using System.Collections.Generic;
using System.Text;

namespace SquarebookAutomation.Tests.ElementLocators
{
    public partial class Locators : Configurations
    {
        //CreateTagsModalLocators    
        protected const string LOCATOR_ADDNEWTAGCATEGORY_BUTTON = "//button[@title='Add a new tag category']";
        protected const string LOCATOR_ADDNEWTAG_BUTTON = "//button[@title='Add a new tag']";
        protected const string LOCATOR_CREATETAGSMODAL_HEADING = "//h5[text()='Create tags']";
        protected const string LOCATOR_TAGMODALSAVE_BUTTON = "//button[text()='Save' and @title='Save changes related to currently selected tag']";
        protected const string LOCATOR_TAGMODALCANCEL_BUTTON = "//button[text()='Cancel' and @title='Reset all changes related to selected category']";
        protected const string LOCATOR_TAGMODALCLOSE_BUTTON = "(//button[@type='button' and @title='Close' and @class='close' and @aria-label='Close'])[1]";
        protected const string LOCATOR_TAGMODALDELETE_BUTTON = "//button[@title='Delete currently selected tag category']";

        //TagModalLocators
        protected const string LOCATOR_TAGDETAILSMODAL_HEADING = "//h5[text()='Tag details']";
        protected const string LOCATOR_TAGNAME_FIELD = "(//span[text()='Name'])[3]//following::input[1]";
        protected const string LOCATOR_SCOPE_DROPDOWN = "(//span[@class='select2-selection__rendered'])[last()]";
        protected const string LOCATOR_TAGSAVE_BUTTON = "//button[text()='Save' and @title='Save tag']";
        protected const string LOCATOR_TAGCANCEL_BUTTON = "//span[text()='Scope']//following::button[text()='Cancel' and @title='Go back']";
        protected const string LOCATOR_TAGCLOSE_BUTTON = "(//button[@type='button' and @title='Close' and @class='close' and @aria-label='Close'])[3]";

        //TagCategoryModalLocators
        protected const string LOCATOR_TAGCATEGORYMODAL_HEADING = "//h5[text()='Tag category details']";
        protected const string LOCATOR_TAGCATNAME_FIELD = "//h5[text()='Tag category details']//following::input[1]";
        protected const string LOCATOR_TAGCATSAVE_BUTTON = "//button[text()='Save' and @title='Save tag category']";
        protected const string LOCATOR_TAGCATCANCEL_BUTTON = "//button[text()='Cancel' and @title='Go back']";
        protected const string LOCATOR_TAGCATCLOSE_BUTTON = "(//button[@type='button' and @title='Close' and @class='close' and @aria-label='Close'])[2]";
    }
}
