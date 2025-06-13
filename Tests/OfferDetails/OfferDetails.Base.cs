using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquarebookAutomation.Tests.OfferDetails
{
    public partial class OfferDetailsBase : Base
    {
        public static void OpenOfferDetailsPageFromDashboard(WebDriverWait wait, string offername)
        {
            ClickOnButton(wait, LOCATOR_DashboardCompanyCardLocator(offername));
        }
        public static void OpenOfferDetailsPageFromAllOfferPage(WebDriverWait wait, string offername)
        {
            ClickOnButton(wait, LOCATOR_DASHBOARDSEEALLOFFERS_LINK);
            ClickOnButton(wait, LOCATOR_DashboardCompanyCardLocator(offername));
        }
    }
}
