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

namespace SquarebookAutomation.Tests.Company
{
    [Order(6)]
    public partial class Company : CompanyBase
    {
        /// <summary>
        /// Test that check sub item Companies is been shown in the navbar
        /// </summary>
        [Fact]
        public void CheckIfCompaniesIsVisibleInNavbar_CompaniesShouldBeInTheNavbarUnderCompanyManagement()
        {
            LoginBase.LoginToPlatform(Driver, WebDriverWait, AppURL);
            ClickOnNavBarLink(WebDriverWait, LOCATOR_COMPANYMANAGEMENT_LINK);
            var navbarItemSignups = ReturnIWebElementObject(WebDriverWait, LOCATOR_COMPANIES_SUBLINK);            
            Assert.Equal("Companies", navbarItemSignups.Text);
        }

        /// <summary>
        /// Test that open the company management page and verifies it opens
        /// </summary>
        [Fact]
        public void OpeningCompanyManagement_ShouldOpenCompanyManagement()
        {
            LoginBase.LoginToPlatform(Driver, WebDriverWait, AppURL);
            ClickOnNavBarLink(WebDriverWait, LOCATOR_COMPANYMANAGEMENT_LINK);
            ClickOnNavBarLink(WebDriverWait, LOCATOR_COMPANIES_SUBLINK);
            var CompanyManagementHeading = ReturnIWebElementObject(WebDriverWait, LOCATOR_INDEXPAGE_HEADING);
            Assert.Equal("Company management", CompanyManagementHeading.Text);
        }

        /// <summary>
        /// Test that creates a company in company management
        /// </summary>
        [RetryFact(FAIL_TEST_RETRIES)]
        public void CreatingNewCompany_ShouldCreateANewCompany()
        {
            LoginBase.LoginToPlatform(Driver, WebDriverWait, AppURL);
            CreateACompany(Driver, WebDriverWait, 
                "Public", 
                $"{ISSUER_ORG_NAME} {Uniqueness}", 
                true, 
                false, 
                "Published");
            IWebElement toastObject = ToastMessageTextObjectReturn(WebDriverWait, LOCATOR_TOAST_MESSAGE);
            Assert.Equal(COMPANY_ADD_SUCCESS_MESSAGE, toastObject.Text);
        }
    }
}
