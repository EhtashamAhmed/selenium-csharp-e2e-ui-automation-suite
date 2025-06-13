using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SquarebookAutomation.Tests.ForgetPassword
{
    public partial class ForgetPassword : ForgetPasswordBase, IDisposable
    {
        /// <summary>
        /// Test to check the forget password functionality.
        /// It navigates to the Forget password page and enter the email in the email field
        /// Then gets redirected to login page
        /// </summary>
        /// <param name="ForgotEmailAddress">Email address to be put in the email field</param>
        [Theory]
        [InlineData("abc@xyz.com")]
        public void RequestingPasswordResetOnForgetPassword_RedirectionToLoginPageWithConfirmationMessage(string ForgotEmailAddress)
        {
            Driver.Url = AppURL;
            ClickOnButton(WebDriverWait, LOCATOR_ACCEPTCONSENT_BUTTON);
            ClickOnButton(WebDriverWait, LOCATOR_FORGOTPASSWORD_LINK);
            AddDataToField(WebDriverWait, LOCATOR_FORGOTPWEMAIL_FIELD, ForgotEmailAddress);
            ClickOnButton(WebDriverWait, LOCATOR_FORGOTPWREQUEST_BUTTON);
            var alertbox_txt = WebDriverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(LOCATOR_ALERTBOX)));
            Assert.Equal(LOCATOR_RESETPASSWORD_MESSAGE, alertbox_txt.Text);
        }
    }
}
