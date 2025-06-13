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

namespace SquarebookAutomation.Tests.Questionnaire
{
    [Order(8)]
    public partial class Questionnaire : QuestionnaireBase, IDisposable
    {
        /// <summary>
        /// Test for opening questionnaire management page
        /// </summary>
        [Fact]
        public void OpeningQuestionnaireManagement_ShouldQuestionnaireQuestionnaireManagement()
        {
            LoginBase.LoginToPlatform(Driver, WebDriverWait, AppURL);
            ClickOnNavBarLink(WebDriverWait, LOCATOR_FORMMANAGEMENT_LINK);
            ClickOnNavBarLink(WebDriverWait, LOCATOR_QUESTIONNAIRES_SUBLINK);
            var QuestionnaireManagementHeading = ReturnIWebElementObject(WebDriverWait, LOCATOR_INDEXPAGE_HEADING);
            Assert.Equal("Questionnaire management", QuestionnaireManagementHeading.Text);
        }

        /// <summary>
        /// Test for creating a new questionnaire
        /// </summary>
        [RetryFact(FAIL_TEST_RETRIES)]
        public void CreatingAQuestionnaire_ShouldCreateANewQuestionnaire()
        {
            LoginBase.LoginToPlatform(Driver, WebDriverWait, AppURL);

            CreateAQuestionnaire(WebDriverWait, $"{QUESTIONNAIRE_TITLE} {Uniqueness}", $"{FORM_TITLE} {Uniqueness}", "Offer",
                $"{IPO_OFFER_TITLE} {Uniqueness}", QUESTIONNAIRE_END_DATE);
            IWebElement toastObject = ToastMessageTextObjectReturn(WebDriverWait, LOCATOR_TOAST_MESSAGE);
            Assert.Equal(Questionnaire_ADD_SUCCESS_MESSAGE, toastObject.Text);
        }
    }
}
