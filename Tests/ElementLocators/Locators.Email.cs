using System;
using System.Collections.Generic;
using System.Text;

namespace SquarebookAutomation.Tests.ElementLocators
{
    public partial class Locators : Configurations
    {
        protected static string LOCATOR_INSTITUTIONALINV_REFERRAL_URL = $"(//p[contains(text(), '{INST_INVESTOR_FIRST_NAME}')])[1]//following::a[1]";
        protected static string LOCATOR_PVTINV_REFERRAL_URL = $"(//p[contains(text(), '{PVT_INVESTOR_FIRST_NAME}')])[1]//following::a[1]";
        protected static string LOCATOR_ADMIN_REFERRAL_URL = $"(//p[contains(text(), '{ADMIN_FIRST_NAME}')])[1]//following::a[1]";
        protected static string LOCATOR_ADVISOR_REFERRAL_URL = $"(//p[contains(text(), '{ADVISOR_FIRST_NAME}')])[1]//following::a[1]";
        protected static string LOCATOR_ADVOCATE_REFERRAL_URL = $"(//p[contains(text(), '{ADVOCATE_FIRST_NAME}')])[1]//following::a[1]";
        protected static string LOCATOR_ISSUER_REFERRAL_URL = $"(//p[contains(text(), '{ISSUER_FIRST_NAME}')])[1]//following::a[1]";
    }
}
