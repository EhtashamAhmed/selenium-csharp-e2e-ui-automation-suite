using OpenQA.Selenium;
using SquarebookAutomation.Tests.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xRetry;
using Xunit;
using Xunit.Extensions.Ordering;

namespace SquarebookAutomation.Tests.RoadshowCompose
{
    [Order(7)]
    public partial class Roadshow : RoadshowBase, IDisposable
    {
        /// <summary>
        /// Test for verifying if the Roadshow management page is opening
        /// </summary>
        [Fact]
        public void OpeningRoadshowManagement_ShouldOpenRoadshowManagement()
        {
            LoginBase.LoginToPlatform(Driver, WebDriverWait, AppURL);
            NavigateToRoadshowIndexPage(Driver, WebDriverWait);
            var RoadshowManagementHeading = ReturnIWebElementObject(WebDriverWait, LOCATOR_INDEXPAGE_HEADING);
            Assert.Equal("Roadshow management", RoadshowManagementHeading.Text);
        }
                
        /// <summary>
        /// Test for creating a roadshow
        /// </summary>
        [RetryFact(FAIL_TEST_RETRIES)]
        public void CreatingNewRoadshow_ShouldCreateANewRoadshow()
        {
            LoginBase.LoginToPlatform(Driver, WebDriverWait, AppURL);
            CreateARoadshow(Driver, WebDriverWait,
                $"Roadshow {Uniqueness}",
                $"{COMPANY_TITLE} {Uniqueness}",
                $"{ISSUER_FIRST_NAME} {ISSUER_LAST_NAME}",
                "Published",
                "None",
                $"Townhall {Uniqueness}",
                DateTime.Now.AddDays(1).ToString("dd MM yyyy"),
                "12:00 AM",
                1,
                "Published",
                $"{INST_INVESTOR_FIRST_NAME} {INST_INVESTOR_LAST_NAME}",
                "Physical",
                "XYZ Street");
            IWebElement toastObject = ToastMessageTextObjectReturn(WebDriverWait, LOCATOR_TOAST_MESSAGE);
            Assert.Equal(ROADSHOW_ADD_TOAST_MESSAGE, toastObject.Text);
        }
    }
}
