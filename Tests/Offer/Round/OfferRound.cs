using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquarebookAutomation.Tests.Offer.Round
{
    public class OfferRound
    {
        string RoundTitle = "";
        string RoundDescription = "";
        string RoundInvitationsAccess = "";
        string RoundAdvisors = "";
        string RoundAdvisorInvites = "";
        string RoundIssuerInvestorInvites = "";
        string RoundActivities = "";
        string RoundStage = "";
        public OfferRound(string roundtitle,
        string rounddescription,
        string roundinvitationsAccess,
        string roundadvisors,
        string roundadvisorInvites,
        string roundissuerInvestorInvites,
        string roundactivities,
        string roundstage)
        {
            RoundTitle = roundtitle;
            RoundDescription = rounddescription;
            RoundInvitationsAccess = roundinvitationsAccess;
            RoundAdvisors = roundadvisors;
            RoundAdvisorInvites = roundadvisorInvites;
            RoundIssuerInvestorInvites = roundissuerInvestorInvites;
            RoundActivities = roundactivities;
            RoundStage = roundstage;
        }   
    }
}
