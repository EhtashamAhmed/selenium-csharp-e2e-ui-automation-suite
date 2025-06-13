using System;
using System.Collections.Generic;
using System.Text;

namespace SquarebookAutomation
{
    public partial class Configurations
    {
        //Questionnaire
        protected const string QUESTIONNAIRE_TITLE = "Questionnaire";
        protected readonly string QUESTIONNAIRE_END_DATE = DateTime.Now.AddYears(1).ToString("dd MM yyyy");
        protected const string Questionnaire_ADD_SUCCESS_MESSAGE = "Questionnaire was added successfully..";
        protected const string Questionnaire_EDIT_SUCCESS_MESSAGE = "Questionnaire was updated successfully..";
    }
}
