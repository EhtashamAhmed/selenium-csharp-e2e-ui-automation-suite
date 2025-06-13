using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SquarebookAutomation.Tests.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xRetry;
using Xunit;
using Xunit.Extensions.Ordering;

namespace SquarebookAutomation.Tests.NewsCompose
{
    [Order(1)]
    public partial class NewsCompose : NewsComposeBase, IDisposable
    {
        /// <summary>
        /// Test for verifying if the News management page is opening
        /// </summary>
        [Fact]
        public void OpeningNewsManagement_ShouldOpenNewsManagement()
        {
            LoginBase.LoginToPlatform(Driver, WebDriverWait, AppURL);
            NavigateToNewsManagement(Driver, WebDriverWait);
            var NewsManagementHeading = ReturnIWebElementObject(WebDriverWait, LOCATOR_INDEXPAGE_HEADING);
            Assert.Equal("News management", NewsManagementHeading.Text);
        }

        /// <summary>
        /// Test for creating a new marker
        /// </summary>
        [RetryFact(FAIL_TEST_RETRIES)]
        public void CreatingNews_ShouldCreateANewNewsThatIsVisibleToEveryOne()
        {
            LoginBase.LoginToPlatform(Driver, WebDriverWait, AppURL);
            CreateANews(Driver, WebDriverWait, NEWS_HEADING, NEWS_SUMMARY, NEWS_DESCRIPTION, true);
            IWebElement toastObject = ToastMessageTextObjectReturn(WebDriverWait, LOCATOR_TOAST_MESSAGE);
            Assert.Equal(NEWS_ADD_SUCCESS_MESSAGE, toastObject.Text);
        }

    }
}
