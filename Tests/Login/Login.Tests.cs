using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SquarebookAutomation.Tests.Login
{
    public partial class Login : LoginBase, IDisposable
    {
        /// <summary>
        /// Test to perform the login with valid credentials and verifying the users lands on the Dashboard
        /// </summary>
        [Fact]
        public void LoginToPWebapp_SuccessfullLoginAndRedirectionToDashboard()
        {
            LoginToPlatform(Driver, WebDriverWait, AppURL);
            var dashboard_txt = ReturnIWebElementObject(WebDriverWait, LOCATOR_DASHBOARD_HEADING);
            Assert.Equal("Dashboard", dashboard_txt.Text);
        }
    }
}
