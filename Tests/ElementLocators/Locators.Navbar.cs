using System;
using System.Collections.Generic;
using System.Text;

namespace SquarebookAutomation.Tests.ElementLocators
{
    public partial class Locators : Configurations
    {
        protected const string LOCATOR_DASHBOARD_LINK = "//span[contains(text(),'Dashboard')]";
        protected const string LOCATOR_COMPANIES_LINK = "(//span[contains(text(),'Companies')])[1]";
        protected const string LOCATOR_OFFERS_LINK = "(//span[contains(text(),'Offers')])[1]";
        protected const string LOCATOR_INVESTOR_PROFILES_LINK = "//span[contains(text(),'Investor profiles')]";
        protected const string LOCATOR_MEETINGS_LINK = "//span[contains(text(),'Meetings')]";

        //Audit management
        protected const string LOCATOR_AUDIT_MANAGEMENT_LINK = "//span[contains(text(),'Audit management')]";
        protected const string LOCATOR_EMAILS_LINK = "//span[text()='Emails']";
        protected const string LOCATOR_AUDITS_LINK = "//span[contains(text(),'Audits')]";

        //News management
        protected const string LOCATOR_NEWS_MANAGEMENT_LINK = "//span[contains(text(),'News management')]";
        protected const string LOCATOR_NOTIFICATIONS_LINK = "//span[contains(text(),'Notifications')]";
        protected const string LOCATOR_NEWS_LINK = "//span[text()='News']";

        //Auction management
        protected const string LOCATOR_AUCTIONMANAGEMENT_LINK = "//span[contains(text(),'Auction management')]";
        protected const string LOCATOR_OFFERS_SUBLINK = "//span[contains(text(),'Auction management')]//following::span[text()='Offers']";
        protected const string LOCATOR_BIDS_SUBLINK = "//span[text()='Bids']";
        protected const string LOCATOR_FLAGS_SUBLINK = "//span[text()='Flags']";
        protected const string LOCATOR_TRANCHES_SUBLINK = "//span[text()='Tranches']";
        protected const string LOCATOR_INTEREST_SUBLINK = "//span[contains(text(),'Interest')]";
        protected const string LOCATOR_SECONDARY_SUBLINK = "//span[text()='Secondary']";
        protected const string LOCATOR_PRIVATE_SUBLINK = "//span[text()='Private']";

        //Form management
        protected const string LOCATOR_FORMMANAGEMENT_LINK = "(//span[contains(text(),'Forms')])[1]";
        protected const string LOCATOR_QUESTIONNAIRES_SUBLINK = "//span[text()='Questionnaires']";
        protected const string LOCATOR_FORMS_SUBLINK = "(//span[contains(text(),'Forms')])[2]";

        //Company management
        protected const string LOCATOR_COMPANYMANAGEMENT_LINK = "//span[contains(text(),'Company management')]";
        protected const string LOCATOR_COMPANIES_SUBLINK = "//span[contains(text(),'Company management')]//following::span[text()='Companies']";        
        protected const string LOCATOR_ORGANIZATIONS_LINK = "//span[text()='Organisations']";
        protected const string LOCATOR_SETTLEMENTS_SUBLINK = "//span[contains(text(),'Settlements')]";
        protected const string LOCATOR_ROADSHOWS_SUBLINK = "//span[contains(text(),'Roadshows')]";
        protected const string LOCATOR_TAGS_LINK = "//span[text()='Tags']";
        protected const string LOCATOR_MARKERS_SUBLINK = "//span[text()='Markers']";
        protected const string LOCATOR_INVESTOR_FUNDS_SUBLINK = "//span[contains(text(),'Investor funds')]";
        protected const string LOCATOR_LICENCES_SUBLINK = "//span[contains(text(),'Licences')]";

        //User management
        protected const string LOCATOR_USERMANAGEMENT_LINK = "//span[contains(text(),'User management')]";
        protected const string LOCATOR_USERS_SUBLINK = "//span[text()='Users']";
        protected const string LOCATOR_ROLES_SUBLINK = "//span[text()='Roles']";
        protected const string LOCATOR_SIGNUP_SUBLINK = "//span[text()='Signups']";
        protected const string LOCATOR_REFERRAL_SUBLINK = "//span[text()='Referrals']";

        protected const string LOCATOR_USERPROFILE_LINK = "//span[@id='userProfile-menu-title']";
        protected const string LOCATOR_SETTINGS_LINK = "//a[@title='Go to settings']";
        protected const string LOCATOR_MYPROFILE_LINK = "//a[@title='Go to my profile']";
        protected const string LOCATOR_LOGOUT_LINK = "//span[text()='Logout']";



        protected const string LOCATOR_BLOCKUI_OVERLAY = "//div[@class='blockUI blockOverlay']";
    }
}
