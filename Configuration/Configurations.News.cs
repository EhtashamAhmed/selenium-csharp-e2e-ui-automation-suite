using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquarebookAutomation
{
    public partial class Configurations
    {
        protected static readonly string NEWS_ICON = PrimaryImage;
        protected string NEWS_HEADING = $"Automation test News {Uniqueness}";
        protected const string NEWS_SUMMARY = "Automated News summary";
        protected const string NEWS_DESCRIPTION = "Automated news description";
        protected const string NEWS_ADD_SUCCESS_MESSAGE = "News item was added successfully..";
        protected const string NEWS_SAVEDRAFT_MESSAGE = "Saved as draft.";
        protected const string NEWS_AUTO_SAVEDRAFT_MESSAGE = "Auto saving as draft...";
    }
}
