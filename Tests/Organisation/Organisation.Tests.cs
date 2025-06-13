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

namespace SquarebookAutomation.Tests.Organisation
{
    [Order(3)]
    public partial class Organisation : OrganisationBase, IDisposable
    {
        /// <summary>
        /// Test to verify the navbar item Organisation is visible in navbar
        /// </summary>
        [Fact]
        public void CheckIfNavbarItemIsVisible_OrganisationsShouldBeInTheNavbar()
        {
            LoginBase.LoginToPlatform(Driver, WebDriverWait, AppURL);
            ClickOnNavBarLink(WebDriverWait, LOCATOR_COMPANYMANAGEMENT_LINK);
            var navbarItemOrganization = ReturnIWebElementObject(WebDriverWait, LOCATOR_ORGANIZATIONS_LINK);
            Assert.Equal("Organisations", navbarItemOrganization.Text);
        }

        /// <summary>
        /// Test for verifying if the organisation management page is opening
        /// </summary>
        [Fact]
        public void OpeningOrganisationManagement_ShouldOpenOrganisationManagement()
        {
            LoginBase.LoginToPlatform(Driver, WebDriverWait, AppURL);
            ClickOnNavBarLink(WebDriverWait, LOCATOR_COMPANYMANAGEMENT_LINK);
            ClickOnNavBarLink(WebDriverWait, LOCATOR_ORGANIZATIONS_LINK);
            var OrganisationManagementHeading = ReturnIWebElementObject(WebDriverWait, LOCATOR_INDEXPAGE_HEADING);
            Assert.Equal("Organisation management", OrganisationManagementHeading.Text);
        }

        /// <summary>
        /// Test for creating organisation of every type
        /// </summary>
        /// <param name="OrganizationType"></param>
        [RetryTheory(FAIL_TEST_RETRIES)]
        [InlineData("Admin")]
        [InlineData("Advisor")]
        [InlineData("Advocate")]
        [InlineData("Institutional investor")]
        [InlineData("Issuer")]
        [InlineData("Private investor")]
        public void CreatingNewOrganisation_ShouldCreateANewOrganisation(string OrganisationType)
        {
            LoginBase.LoginToPlatform(Driver, WebDriverWait, AppURL);
            CreateAnOrganisation(WebDriverWait, OrganisationType);
            IWebElement toastObject = ToastMessageTextObjectReturn(WebDriverWait, LOCATOR_TOAST_MESSAGE);
            Assert.Equal(ORGANIZATION_ADD_TOAST_MESSAGE, toastObject.Text);
        }
    }
}
