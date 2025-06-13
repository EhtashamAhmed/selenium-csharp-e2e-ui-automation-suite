using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Extensions.Ordering;
using SquarebookAutomation.Tests.Login;
using OpenQA.Selenium;

namespace SquarebookAutomation.Tests.System.Settings
{
    [Order(1)]
    public partial class Settings : SettingsBase, IDisposable
    {
        /// <summary>
        /// Test to create a create jurisdiction from the system management
        /// </summary>
        [Fact]
        public void CreateAJurisdiction_ShouldCreateANewJurisdiction()
        {
            LoginBase.LoginToPlatform(Driver, WebDriverWait, AppURL);
            CreateAJurisdiction(WebDriverWait, $"Jurisdiction {Uniqueness}");
            IWebElement toastObject = ToastMessageTextObjectReturn(WebDriverWait, LOCATOR_TOAST_MESSAGE);
            Assert.Equal("Successfully created jurisdiction.", toastObject.Text);
        }
        /// <summary>
        /// Test to create a create Capabilitiy from the system management
        /// </summary>
        [Fact]
        public void CreateACapability_ShouldCreateANewCapability()
        {
            LoginBase.LoginToPlatform(Driver, WebDriverWait, AppURL);
            CreateACapability(WebDriverWait, $"Capabilitiy {Uniqueness}");
            IWebElement toastObject = ToastMessageTextObjectReturn(WebDriverWait, LOCATOR_TOAST_MESSAGE);
            Assert.Equal("Capability created successfully", toastObject.Text);
        }
    }
}
