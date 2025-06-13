using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SquarebookAutomation.Tests.Login
{
    public partial class LoginBase : Base
    {
        /// <summary>
        ///Common method to perform login to the site with the Admin account and default password
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="wait"></param>
        /// <param name="web_url">Url of the environment</param>
        public static void LoginToPlatform(IWebDriver driver, WebDriverWait wait, string web_url)
        {
            driver.Url = web_url;
            ClickOnButton(wait, LOCATOR_ACCEPTCONSENT_BUTTON);
            AddDataToField(wait, LOCATOR_LOGINEMAIL_FIELD, USER_NAME);
            AddDataToField(wait, LOCATOR_LOGINPASSWORD_FIELD, PASSWORD);
            ClickOnButton(wait, LOCATOR_LOGIN_BUTTON);
        }
        /// <summary>
        /// Common login method overloaded if a we want to login to the platform from any other custom user email and the default password
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="wait"></param>
        /// <param name="web_url"></param>
        /// <param name="_username">email address of the user account</param>
        public static void LoginToPlatform(IWebDriver driver, WebDriverWait wait, string web_url, string username)
        {
            driver.Url = web_url;
            ClickOnButton(wait, LOCATOR_ACCEPTCONSENT_BUTTON);
            AddDataToField(wait, LOCATOR_LOGINEMAIL_FIELD, username);
            AddDataToField(wait, LOCATOR_LOGINPASSWORD_FIELD, PASSWORD);
            ClickOnButton(wait, LOCATOR_LOGIN_BUTTON);
        }
        /// <summary>
        /// Common login method overloaded if a we want to login to the platform from any other custom user email and with the custom password
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="wait"></param>
        /// <param name="web_url"></param>
        /// <param name="_username">email address of the user account</param>
        /// <param name="_password">password of the user account</param>
        public static void LoginToPlatform(IWebDriver driver, WebDriverWait wait, string web_url, string username, string password)
        {
            driver.Url = web_url;
            ClickOnButton(wait, LOCATOR_ACCEPTCONSENT_BUTTON);
            AddDataToField(wait, LOCATOR_LOGINEMAIL_FIELD, username);
            AddDataToField(wait, LOCATOR_LOGINPASSWORD_FIELD, password);
            ClickOnButton(wait, LOCATOR_LOGIN_BUTTON);
        }
    }
}
