using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SquarebookAutomation.Tests.Login;
using System;
using System.Collections.Generic;
using System.Text;
using xRetry;
using Xunit;
using Xunit.Extensions.Ordering;

namespace SquarebookAutomation.Tests.UserRegistration
{
    [Order(5)]
    public partial class UserRegistration : UserRegistrationBase, IDisposable
    {
        /// <summary>
        /// This automation completes the user registration
        /// </summary>
        /// <param name="userOrgType"></param>
        [RetryTheory(FAIL_TEST_RETRIES)]
        [InlineData("Admin")]
        [InlineData("Advisor")]
        [InlineData("Advocate")]
        [InlineData("Institutional investor")]
        [InlineData("Issuer")]
        [InlineData("Private investor")]
        public void CompletingTheUserSignup(string userOrgType)
        {
            LoginBase.LoginToPlatform(Driver, WebDriverWait, AppURL);
            CompleteRegistration(Driver, WebDriverWait, userOrgType);
            var alertbox_txt = ReturnIWebElementObject(WebDriverWait, LOCATOR_ALERTBOX);
            Assert.Equal(LOCATOR_REGISTRATIONCOMPLETE_MESSAGE, alertbox_txt.Text);
        }
    }
}
