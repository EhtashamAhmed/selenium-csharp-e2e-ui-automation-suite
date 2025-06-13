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

namespace SquarebookAutomation.Tests.Tag
{
    [Order(1)]
    public partial class Tag : TagBase, IDisposable
    {
        /// <summary>
        /// Test for verifying tags item present in the navbar
        /// </summary>
        [Fact]
        public void CheckIfNavbarItemIsVisible_TagsShouldBeInTheNavbar()
        {
            LoginBase.LoginToPlatform(Driver, WebDriverWait, AppURL);
            ClickOnNavBarLink(Driver, WebDriverWait, LOCATOR_COMPANYMANAGEMENT_LINK);
            var navbarItemTag = ReturnIWebElementObject(WebDriverWait, LOCATOR_TAGS_LINK);
            Assert.Equal("Tags", navbarItemTag.Text);
        }

        /// <summary>
        /// Test for opening the tag management page
        /// </summary>
        [Fact]
        public void OpeningTagManagement_ShouldOpenTagManagement()
        {
            LoginBase.LoginToPlatform(Driver, WebDriverWait, AppURL);
            ClickOnNavBarLink(Driver, WebDriverWait, LOCATOR_COMPANYMANAGEMENT_LINK);
            ClickOnNavBarLink(Driver, WebDriverWait, LOCATOR_TAGS_LINK);
            var TagManagementHeading = ReturnIWebElementObject(WebDriverWait, LOCATOR_INDEXPAGE_HEADING);
            Assert.Equal("Tag management", TagManagementHeading.Text);
        }

        /// <summary>
        /// Test for opening the Create tags modal form
        /// </summary>
        [Fact]
        public void OpeningCreateTagsModalForm_ShouldOpenCreateTagsModalForm()
        {
            LoginBase.LoginToPlatform(Driver, WebDriverWait, AppURL);
            ClickOnNavBarLink(Driver, WebDriverWait, LOCATOR_COMPANYMANAGEMENT_LINK);
            ClickOnNavBarLink(Driver, WebDriverWait, LOCATOR_TAGS_LINK);
            ClickOnAddButton(WebDriverWait);
            var CreateTagsModalHeading = ReturnIWebElementObject(WebDriverWait, LOCATOR_CREATETAGSMODAL_HEADING);
            Assert.Equal("Create tags", CreateTagsModalHeading.Text);
        }

        /// <summary>
        /// Test for opening the Tag category modal form
        /// </summary>
        [Fact]
        public void OpeningTagCategoryModalForm_ShouldOpenTagCategoryModalForm()
        {
            LoginBase.LoginToPlatform(Driver, WebDriverWait, AppURL);
            ClickOnNavBarLink(Driver, WebDriverWait, LOCATOR_COMPANYMANAGEMENT_LINK);
            ClickOnNavBarLink(Driver, WebDriverWait, LOCATOR_TAGS_LINK);
            ClickOnAddButton(WebDriverWait);
            ClickOnButton(WebDriverWait, LOCATOR_ADDNEWTAGCATEGORY_BUTTON);
            var TagCategoryModalHeading = ReturnIWebElementObject(WebDriverWait, LOCATOR_TAGCATEGORYMODAL_HEADING);
            Assert.Equal("Tag category details", TagCategoryModalHeading.Text);
        }

        /// <summary>
        /// Test for creating a new tag category
        /// </summary>
        [Fact]
        public void CreatingNewTagCategory_ShouldCreateANewTagCategory()
        {
            LoginBase.LoginToPlatform(Driver, WebDriverWait, AppURL);
            CreateATagCategory(Driver, WebDriverWait);
            IWebElement toastObject = ToastMessageTextObjectReturn(WebDriverWait, LOCATOR_TOAST_MESSAGE);
            Assert.Equal(TAG_CATEGORY_CREATION_MESSAGE, toastObject.Text);
        }

        /// <summary>
        /// Test for opening the Tag details modal form
        /// </summary>
        [Fact]
        public void OpeningTagModalForm_ShouldOpenTagModalForm()
        {
            LoginBase.LoginToPlatform(Driver, WebDriverWait, AppURL);
            ClickOnNavBarLink(Driver, WebDriverWait, LOCATOR_COMPANYMANAGEMENT_LINK);
            ClickOnNavBarLink(Driver, WebDriverWait, LOCATOR_TAGS_LINK);
            ClickOnAddButton(WebDriverWait);
            ClickOnButton(WebDriverWait, LOCATOR_ADDNEWTAG_BUTTON);
            var TagModalHeading = ReturnIWebElementObject(WebDriverWait, LOCATOR_TAGDETAILSMODAL_HEADING);
            Assert.Equal("Tag details", TagModalHeading.Text);
        }

        /// <summary>
        /// Test for creating a new tag
        /// </summary>
        [RetryFact(FAIL_TEST_RETRIES)]
        public void CreatingNewTag_ShouldCreateANewTag()
        {
            LoginBase.LoginToPlatform(Driver, WebDriverWait, AppURL);
            CreateATag(Driver, WebDriverWait);
            IWebElement toastObject = ToastMessageTextObjectReturn(WebDriverWait, LOCATOR_TOAST_MESSAGE);
            Assert.Equal(TAG_CREATION_MESSAGE, toastObject.Text);
        }
    }
}
