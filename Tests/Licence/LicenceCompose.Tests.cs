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

namespace SquarebookAutomation.Tests.Licence
{
    [Order(2)]
    public partial class LicenceCompose : LicenceComposeBase, IDisposable
    {
        /// <summary>
        /// Test for creating a new licence with jurisdiction and capability
        /// </summary>
        [Fact]
        public void CreatingALicence_ShouldCreateANewLicence()
        {
            LoginBase.LoginToPlatform(Driver, WebDriverWait, AppURL);
            NavigateToLicenceManagement(Driver, WebDriverWait);
            ClickOnAddButton(WebDriverWait);
            CreateALicence(WebDriverWait, $"Licence {Uniqueness}", $"Jurisdiction {Uniqueness}", $"Capabilitiy {Uniqueness}");
            IWebElement toastObject = ToastMessageTextObjectReturn(WebDriverWait, LOCATOR_TOAST_MESSAGE);
            Assert.Equal("Licence was added successfully..", toastObject.Text);
        }
    }
}
