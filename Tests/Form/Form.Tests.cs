using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using SquarebookAutomation.Tests.Login;
using System;
using System.Collections.Generic;
using System.Text;
using xRetry;
using Xunit;

namespace SquarebookAutomation.Tests.Form
{
    public partial class Form : FormBase, IDisposable
    {
        /// <summary>
        /// Test for verifying the Form management is visible in navbar
        /// </summary>
        [Fact]
        public void CheckIfFormsNavbarItemIsVisible_FormsShouldBeInTheNavbarUnderFormManagement()
        {
            LoginBase.LoginToPlatform(Driver, WebDriverWait, AppURL);
            ClickOnNavBarLink(WebDriverWait, LOCATOR_FORMMANAGEMENT_LINK);
            var navbarItemSignups = WebDriverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(LOCATOR_FORMS_SUBLINK)));
            Assert.Equal("Forms", navbarItemSignups.Text);
        }

        /// <summary>
        /// Test for opening form management page
        /// </summary>
        [Fact]
        public void OpeningFormManagement_ShouldOpenFormManagement()
        {
            LoginBase.LoginToPlatform(Driver, WebDriverWait, AppURL);
            ClickOnNavBarLink(WebDriverWait, LOCATOR_FORMMANAGEMENT_LINK);
            ClickOnNavBarLink(WebDriverWait, LOCATOR_FORMS_SUBLINK);
            var FormManagementHeading = WebDriverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(LOCATOR_INDEXPAGE_HEADING)));
            Assert.Equal("Forms", FormManagementHeading.Text);
        }

        /// <summary>
        /// Test for creating a new form
        /// </summary>
        [RetryFact(FAIL_TEST_RETRIES)]
        public void CreatingAForm_ShouldCreateANewForm()
        {
            LoginBase.LoginToPlatform(Driver, WebDriverWait, AppURL);
            CreateAForm(Driver, WebDriverWait);
            IWebElement toastObject = ToastMessageTextObjectReturn(WebDriverWait, LOCATOR_TOAST_MESSAGE);
            Assert.Equal(FORM_ADD_SUCCESS_MESSAGE, toastObject.Text);
        }
        
        /// <summary>
        /// Test for creating a new form with bidding items in it
        /// </summary>
        [RetryFact(FAIL_TEST_RETRIES)]
        public void CreatingABiddingForm_ShouldCreateANewBiddingForm()
        {
            LoginBase.LoginToPlatform(Driver, WebDriverWait, AppURL);
            CreateABiddingForm(Driver, WebDriverWait);
            IWebElement toastObject = ToastMessageTextObjectReturn(WebDriverWait, LOCATOR_TOAST_MESSAGE);
            Assert.Equal(FORM_ADD_SUCCESS_MESSAGE, toastObject.Text);
        }
    }
}
