namespace SquarebookAutomation.Tests.ElementLocators
{
    public partial class Locators : Configurations
    {
        protected const string LOCATOR_COMPANYFILTERICON_BTN = "//input[@placeholder='Search']";
        protected const string LOCATOR_OFFERFILTERICON_BTN = "//i[@title='Search given entry']";
        protected const string LOCATOR_MEETINGWIDGET_DROPDOWN = "//tbody[@class='rz-datatable-data  rz-datatable-hoverable-rows']";
        //protected const string LOCATOR_DASHBOARD_HEADING = "//h5";
        protected static string LOCATOR_DashboardOfferCardLocator(string offername)
        {
            return $"//div[text()='Companies']//following::div[text()='{offername}']";
        }
        protected static string LOCATOR_DashboardCompanyCardLocator(string companyname)
        {
            return $"//div[text()='Offers']//following::div[text()='{companyname}']";
        }
        protected const string LOCATOR_DASHBOARDSEEALLCOMPANIES_LINK = "//div[text()='Companies']//following::a[text()='See all']";
        protected const string LOCATOR_DASHBOARDSEEALLOFFERS_LINK = "//div[text()='Offers']//following::a[text()='See All']";
    }
}
