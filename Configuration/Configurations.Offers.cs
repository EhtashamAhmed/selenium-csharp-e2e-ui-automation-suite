using System;
using System.Collections.Generic;
using System.Text;

namespace SquarebookAutomation
{
    public partial class Configurations
    {
        //Offer
        protected const string IPO_OFFER_TITLE = "OFFER IPO";
        protected const string SECONDARY_OFFER_TITLE = "OFFER Sec";
        protected const string MULTI_ROUND_OFFER_TITLE = "OFFER MR";
        protected static readonly string OFFER_WEBSITE_URL = AppURL;
        protected static readonly string OFFER_END_DATE = DateTime.Now.AddYears(1).ToString("dd MM yyyy");
        protected const string TRADE_SYMBOL = "OFFER";
        protected readonly string OFFER_HEADER_ICON = PrimaryImage;
        protected readonly string OFFER_HEADER_BACKGROUND = SecondaryImage;
        protected const string OFFER_ADD_SUCCESS_MESSAGE = "Offer item was added successfully..";
    }
}
