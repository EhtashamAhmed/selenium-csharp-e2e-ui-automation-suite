using System;
using System.Collections.Generic;
using System.Text;

namespace SquarebookAutomation
{
    public partial class Configurations
    {
        //Tranche
        protected const string TRANCHE_TITLE = "Tranche";
        protected const string TRANCHE_SHARES = "40000";
        protected const string TRANCHE_MAX_SHARES_PER_MEMBER = "10000";
        protected const string TRANCHE_POINTS_THRESHOLD = "3";
        protected const string TRANCHE_MAXIMUM_MEMBERS = "";
        protected const string TRANCHE_PRIZE_DESCRIPTION = "Automated Tranche Prize";
        protected const string TRANCHE_PREFERENCE_FACTOR = "1.5";
        protected const string TRANCHE_DISCOUNT_PERCENTAGE = "15";
        protected const string TRANCHE_FREE_SHARES_PERCENTAGE = "15";
        protected const string TRANCHE_RULE_POINTS = "3";
        protected const string TRANCHE_RULE_SHARES = "30000";
        protected const string TRANCHE_RULE_BENCHMARK = "10";
        protected const string TRANCHE_RULE_QUESTIONNAIRE = null;
        protected const string TRANCHE_FLAG = null;
        protected const string TRANCHE_QUESTIONNAIRE_ITEM = null;
        protected const string Tranche_ADD_SUCCESS_MESSAGE = "Tranche was added successfully..";
        protected const string TRANCHE_RULE_8 = "Custom";
        protected const string TRANCHE_RULE_1 = "Has submitted response to a questionnaire";
        protected const string TRANCHE_RULE_2 = "Highest bidder with requested shares greater than or equal to N";
        protected const string TRANCHE_RULE_3 = "Institute investor with bid price within first standard deviation of highest bid among institute investors";
        protected const string TRANCHE_RULE_4 = "N highest bid with specified flag";
        protected const string TRANCHE_RULE_5 = "With bid price within first standard deviation of highest bid";
        protected const string TRANCHE_RULE_6 = "With highest response value among all responses for a specific questionnaire";
        protected const string TRANCHE_RULE_7 = "With response to specific question higher than specific value";
    }
}
