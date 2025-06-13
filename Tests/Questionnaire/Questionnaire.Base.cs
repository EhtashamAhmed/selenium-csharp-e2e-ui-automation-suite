using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SquarebookAutomation.Tests.Questionnaire
{
    public partial class QuestionnaireBase : Base
    {
        /// <summary>
        /// Common method to create a questionnaire
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="wait"></param>
        /// <param name="questionnaireName">Name of the questionnaire</param>
        /// <param name="questionnaireForm">Form to be linked with the questionnaire</param>
        /// <param name="questionnaireType">Type of the questionnaire either Company, Offer or Roadshow</param>
        /// <param name="connectingEntity">Company/Offer/Roadshow name for which the questionnaire is being made</param>
        /// <param name="endingDate">Ending date of the questionnaire. Must be greater than the current date</param>
        /// <param name="status">Status of the questionnaire. Either New/Previwe/Published/Unpublished</param>
        /// <param name="state">State of the questionnaire. Either None/Pre-bidding/Pre-offer</param>
        /// <param name="emailMessage">Either Default or Custom</param>
        /// <param name="emailMessageText">Message text if the Email Message is selected Custom</param>
        protected static void CreateAQuestionnaire(WebDriverWait wait, string questionnaireName, string questionnaireForm, string questionnaireType, string connectingEntity, string endingDate, string status = "Published", string state = "None", string emailMessage = "Default", string emailMessageText = "Default Message")
        {
            ClickOnNavBarLink(wait, LOCATOR_FORMMANAGEMENT_LINK);
            ClickOnNavBarLink(wait, LOCATOR_QUESTIONNAIRES_SUBLINK);
            ClickOnAddButton(wait);
            AddDataToField(wait, LOCATOR_QUESTIONNAIRETITLE_FIELD, questionnaireName);
            ClickOnDropDown(wait, LOCATOR_FORM_DROPDOWN);
            SelectFromDropDown(wait, questionnaireForm);
            ClickOnDropDown(wait, LOCATOR_FORMTYPE_DROPDOWN);
            if (questionnaireType == "Company")
            {
                SelectFromDropDown(wait, "Company");
                ClickOnDropDown(wait, LOCATOR_QUESTIONNAIRECOMPANY_DROPDOWN);
                SelectFromDropDown(wait, connectingEntity);
            }
            else if (questionnaireType == "Offer")
            {
                SelectFromDropDown(wait, "Offer");
                ClickOnDropDown(wait, LOCATOR_QUESTIONNAIREOFFER_DROPDOWN);
                SelectFromDropDown(wait, connectingEntity);
            }
            else if (questionnaireType == "Roadshow")
            {
                SelectFromDropDown(wait, "Roadshow");
                ClickOnDropDown(wait, LOCATOR_QUESTIONNAIREROADSHOWS_DROPDOWN);
                SelectFromDropDown(wait, connectingEntity);
            }
            ClearDataOfAField(wait, LOCATOR_QUESTIONNAIREENDINGDATE_FIELD);
            AddDataToField(wait, LOCATOR_QUESTIONNAIREENDINGDATE_FIELD, endingDate);
            HitEnterKey(wait, LOCATOR_QUESTIONNAIREENDINGDATE_FIELD);

            ClickOnDropDown(wait, LOCATOR_QUESTIONNAIRESTATUS_DROPDOWN);
            SelectFromDropDown(wait, status);

            ClickOnDropDown(wait, LOCATOR_QUESTIONNAIRESTATE_DROPDOWN);
            SelectFromDropDown(wait, state);

            if (emailMessage == "Custom")
            {
                ClickOnDropDown(wait, LOCATOR_EMAILMESSAGE_DROPDOWN);
                SelectFromDropDown(wait, emailMessage);
                AddDataToField(wait, LOCATOR_EMAILMESSAGE_FIELD, emailMessageText);
            }
            ClickOnButton(wait, LOCATOR_QUESTIONNAIRESAVE_BUTTON);
            Thread.Sleep(2000);
        }
    }
}
