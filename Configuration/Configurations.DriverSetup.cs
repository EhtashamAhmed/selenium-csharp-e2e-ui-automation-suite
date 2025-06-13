using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

namespace SquarebookAutomation
{
    public partial class Configurations
    {
        protected const int WAIT_FOR_ELEMENT_TIMEOUT = 30;
        protected static IWebDriver _driver;
        protected static WebDriverWait _webDriverWait;
        protected const int FAIL_TEST_RETRIES = 3;
        protected const bool IS_HEADLESS = false;
        /// <summary>
        /// This function setups the web driver. All the configurations of headless or with head execution is done here
        /// </summary>
        /// <returns></returns>
        protected static IWebDriver SetupDriver()
        {
            if (IS_HEADLESS != true)
            {
                //new DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);
                _driver = new ChromeDriver();
                _driver.Manage().Window.Maximize();
            }
            else
            {
                var chromeOptions = new ChromeOptions();
                chromeOptions.AddArguments("headless");
                chromeOptions.AddArgument("no-sandbox");
                chromeOptions.AddArguments("--window-size=1280,800");
                _driver = new ChromeDriver(chromeOptions);
            }
            return _driver;
        }

        /// <summary>
        /// Setting the common wait for the web driver
        /// </summary>
        /// <returns></returns>
        protected static WebDriverWait SetupWait()
        {
            _webDriverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(WAIT_FOR_ELEMENT_TIMEOUT));
            return _webDriverWait;
        }

        /// <summary>
        /// Disposable method to be used to quit the driver after each test execution
        /// </summary>
        protected static void DriverDispose()
        {
            _driver.Quit();
        }
    }
}
