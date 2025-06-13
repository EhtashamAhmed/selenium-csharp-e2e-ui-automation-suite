using System;
using System.Collections.Generic;
using System.Text;

namespace SquarebookAutomation.Tests.ElementLocators
{
    public partial class Locators : Configurations
    {
        protected const string LOCATOR_TOAST_MESSAGE = "//span[@class='toast-message']";
        protected const string LOCATOR_ADD_BUTTON = "//button[@class='btn-add mb-0' or @class='btn-add mt-2' or @class='btn-add fa-plus-padding mb-0']";
        protected const string LOCATOR_SEARCH_FIELD = "//input[@placeholder='Search']";
        protected const string LOCATOR_SEARCH_BUTTON = "//i[@title='Search given entry']";
        protected const string LOCATOR_TABLESEARCH_DATA = "//tbody[@class='rz-datatable-data  rz-datatable-hoverable-rows']";
        protected const string LOCATOR_INDEXPAGE_HEADING = "//h3";
        protected const string LOCATOR_DASHBOARD_HEADING = "//h3";
    }
}
