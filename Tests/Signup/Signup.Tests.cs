using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using SquarebookAutomation.Tests.Login;
using System;
using System.Collections.Generic;
using System.Text;
using xRetry;
using Xunit;
using Xunit.Extensions.Ordering;

namespace SquarebookAutomation.Tests.Signup
{
    [Order(4)]
    public partial class Signup : SignupBase, IDisposable
    {
        /// <summary>
        /// Test for checking the Singups in the navbar menu
        /// </summary>
        [Fact]
        public void CheckIfSignupsIsVisibleInNavbar_SignupsShouldBeInTheNavbarUnderUserManagement()
        {
            LoginBase.LoginToPlatform(Driver, WebDriverWait, AppURL);
            ClickOnNavBarLink(WebDriverWait, LOCATOR_USERMANAGEMENT_LINK);
            var navbarItemSignups = WebDriverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(LOCATOR_SIGNUP_SUBLINK)));
            Assert.Equal("Signups", navbarItemSignups.Text);
        }

        /// <summary>
        /// Test for opening singup management page
        /// </summary>
        [Fact]
        public void OpeningSignupManagement_ShouldOpenSignupManagement()
        {
            LoginBase.LoginToPlatform(Driver, WebDriverWait, AppURL);
            ClickOnNavBarLink(Driver, WebDriverWait, LOCATOR_USERMANAGEMENT_LINK);
            ClickOnNavBarLink(Driver, WebDriverWait, LOCATOR_SIGNUP_SUBLINK);
            var SignupManagementHeading = WebDriverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(LOCATOR_INDEXPAGE_HEADING)));
            Assert.Equal("Signup management", SignupManagementHeading.Text);
        }

        /// <summary>
        /// Test for creating singup of every type
        /// </summary>
        /// <param name="OrganizationType"></param>
        /// <param name="role"></param>
        [RetryTheory(FAIL_TEST_RETRIES)]
        [InlineData("Admin", "Administrator")]
        [InlineData("Advisor", "Advisor corporate")]
        [InlineData("Advocate", "Advocate")]
        [InlineData("Institutional investor", "Bidder")]
        [InlineData("Issuer", "Issuer")]
        [InlineData("Private investor", "Bidder")]
        public void CreatingNewSignup_ShouldCreateANewSingup(string OrganizationType, string role)
        {
            LoginBase.LoginToPlatform(Driver, WebDriverWait, AppURL);
            //Organization.Organization.CreateAnOrganization(Driver, WebDriverWait, OrganizationType);
            CreateASignup(Driver, WebDriverWait, OrganizationType, role);
            IWebElement toastObject = ToastMessageTextObjectReturn(WebDriverWait, LOCATOR_TOAST_MESSAGE);
            Assert.Equal(SIGNUP_ADD_TOAST_MESSAGE, toastObject.Text);
        }
    }
}
