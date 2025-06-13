using System;
using System.Collections.Generic;
using System.Text;

namespace SquarebookAutomation
{
    public partial class Configurations
    {
        //Company
        protected  const string COMPANY_TITLE = "COMPANY";
        protected const string COMPANY_SUMMARY = "Automated Testing Company Summary";
        protected readonly string COMPANY_LOGO = PrimaryImage;
        protected readonly string COMPANY_BACKGROUND_IMAGE = SecondaryImage;
        protected const string COMPANY_SIMPLE_TEXT_HEADING = "Automated Test Heading";
        protected const string COMPANY_SIMPLE_TEXT_DESCRIPTION = "Automated Test Description";
        protected static readonly string COMPANY_FANCY_TEXT_HEADING = COMPANY_SIMPLE_TEXT_HEADING;
        protected static readonly string COMPANY_FANCY_TEXT_DESCRIPTION = COMPANY_SIMPLE_TEXT_DESCRIPTION;
        protected readonly string CAROUSEL_IMAGE = PrimaryImage;
        protected static readonly string TURTL_DOCUMENT_URL = "https://squarebook.turtl.co/story/test-doc/?fullscreen-toggle=yes";
        protected const string TURTL_DOCUMENT_WIDTH = "928";
        protected const string TURTL_DOCUMENT_HEIGHT = "609";
        protected const string DOCUMENT_TITLE = "Document 1";
        protected const string VIDEO_TITLE = "Video 1";
        protected const string COMPANY_ADD_SUCCESS_MESSAGE = "Company was added successfully..";
    }
}
