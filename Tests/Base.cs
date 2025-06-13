using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using SquarebookAutomation.Tests.ElementLocators;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SquarebookAutomation.Tests
{
    public class Base : Locators, IDisposable
    {
        protected readonly IWebDriver Driver;
        protected readonly WebDriverWait WebDriverWait;

        public Base()
        {
            Driver = SetupDriver();
            WebDriverWait = SetupWait();
        }

        public void Dispose()
        {
            DriverDispose();
        }

        /// <summary>
        /// Generic function to enter data to an input field using SendKeys of Selenium
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="wait"></param>
        /// <param name="path">XPath of the input field</param>
        /// <param name="FieldData">Data to be entered</param>
        protected static void AddDataToField(WebDriverWait wait, string path, string FieldData)
        {
            Thread.Sleep(1000);
            var inputField =wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(path)));
            inputField.SendKeys(FieldData);
        }

        /// <summary>
        /// Generic function to clear all the data in an input field
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="wait"></param>
        /// <param name="path">XPath of the field</param>
        protected static void ClearDataOfAField(WebDriverWait wait, string path)
        {
            Thread.Sleep(1000);
           wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(path))).Clear();
        }

        /// <summary>
        /// Generic function replace a preexisting text data in a field by selecting all the data and entering new text data
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="wait"></param>
        /// <param name="path">XPath of the field</param>
        /// <param name="FieldData">Data to be entered in the field</param>
        protected static void ReplacingDataOfAField(WebDriverWait wait, string path, string FieldData)
        {
            Thread.Sleep(1000);
           wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(path))).SendKeys(Keys.Control + "a");
           wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(path))).SendKeys(FieldData);
        }

        /// <summary>
        /// Generic method to click on a drop down list
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="wait"></param>
        /// <param name="path">XPath of the element</param>
        protected static void ClickOnDropDown(WebDriverWait wait, string path)
        {
            var clickableElement =wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(path)));
            clickableElement.Click();
            Thread.Sleep(3000);
        }

        /// <summary>
        /// Generic method to select an entry from a drop down list
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="wait"></param>
        /// <param name="item">Name of the item to select</param>
        protected static void SelectFromDropDown(WebDriverWait wait, string item)
        {
            var clickableElement =wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//li[contains(text(),'{item}')]")));
            clickableElement.Click();
            Thread.Sleep(2000);
        }

        /// <summary>
        /// Generic method to select last finding entry from a drop down list
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="wait"></param>
        /// <param name="item">Name of the item to select</param>
        protected static void SelectLastFoundFromDropDown(WebDriverWait wait, string item)
        {
            var clickableElement = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"(//li[contains(text(),'{item}')])[last()]")));
            clickableElement.Click();
            Thread.Sleep(2000);
        }

        /// <summary>
        /// Generic method to click on any button
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="wait"></param>
        /// <param name="path">XPath of the button element</param>
        protected static void ClickOnButton(WebDriverWait wait, string path)
        {
            var clickableElement =wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(path)));
            clickableElement.Click();
        }

        /// <summary>
        /// Generic method for uploading an image
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="wait"></param>
        /// <param name="path">XPath of the image up loader input element</param>
        /// <param name="image">Path of the image file</param>
        protected static void UploadAnImage(IWebDriver driver, string path, string image)
        {
            driver.FindElement(By.XPath(path)).SendKeys(image);
            Thread.Sleep(5000);
        }

        /// <summary>
        /// Generic method for scrolling the browser to a specific location on the page
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="wait"></param>
        /// <param name="path">XPath of the element where you want to scroll the page</param>
        protected static void ScrollToElement(IWebDriver driver, WebDriverWait wait, string path)
        {
            var element =wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(path)));
            Actions actions = new Actions(driver);
            actions.MoveToElement(element);
            actions.Perform();
        }

        /// <summary>
        /// Generic method for verifying if an element exists on the page
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="wait"></param>
        /// <param name="path">XPath of the element</param>
        /// <returns>True if the specified element exists or vice versa</returns>
        protected static bool CheckIfElementExists(WebDriverWait wait, string path)
        {
            try
            {
                return wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(path))).Displayed;
            }
            catch(WebDriverTimeoutException)
            {
                return false;
            }
        }

        /// <summary>
        /// Generic method to press enter key in an input field
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="wait"></param>
        /// <param name="path">XPath of the field where enter key is to be pressed</param>
        protected static void HitEnterKey(WebDriverWait wait, string path)
        {
           wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(path))).SendKeys(Keys.Enter);
        }

        //IndexPages

        /// <summary>
        /// Generic method to click on Add Button of index pages
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="wait"></param>
        protected static void ClickOnAddButton(WebDriverWait wait)
        {
           Thread.Sleep(6000);
           wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(LOCATOR_ADD_BUTTON))).Click();
        }

        /// <summary>
        /// Generic method that returns the toast notification object
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="wait"></param>
        /// <param name="path">XPath of the field toast message</param>
        /// <returns>IWebElement of the toast notification</returns>
        protected static IWebElement ToastMessageTextObjectReturn(WebDriverWait wait, string path)
        {
            Thread.Sleep(500);
            var toastMessageObject =wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(path)));
            return toastMessageObject;
        }

        /// <summary>
        /// Method to search data in the data table
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="wait"></param>
        /// <param name="SearchData">Data that needs to be searched</param>
        protected static void SearchInDataGrid(WebDriverWait wait, string SearchData)
        {
            Thread.Sleep(10000);
            AddDataToField(wait, LOCATOR_SEARCH_FIELD, SearchData);
            Thread.Sleep(2000);
           wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(LOCATOR_SEARCH_BUTTON))).Click();
            Thread.Sleep(5000);
        }

        /// <summary>
        /// Method to return any IWebElement object
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="wait"></param>
        /// <param name="path">XPath of the element</param>
        /// <returns></returns>
        protected static IWebElement ReturnIWebElementObject(WebDriverWait wait, string path)
        {
            Thread.Sleep(500);
            var IWebElementObject =wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(path)));
            return IWebElementObject;
        }

        //Navbar

        /// <summary>
        /// Method to click on any option of the navbar
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="wait"></param>
        /// <param name="NavbarItem"></param>
        protected static void ClickOnNavBarLink(WebDriverWait wait, string NavbarItem)
        {

            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(LOCATOR_COMPANYMANAGEMENT_LINK)));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(NavbarItem))).Click();
        }

        //Navbar

        /// <summary>
        /// Method to click on any option of the navbar
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="wait"></param>
        /// <param name="NavbarItem"></param>
        protected static void ClickOnNavBarLink(IWebDriver driver, WebDriverWait wait, string NavbarItem)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(LOCATOR_COMPANYMANAGEMENT_LINK)));
            ScrollToElement(driver, wait, NavbarItem);
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(NavbarItem))).Click();
        }

        //Email Management
        /// <summary>
        /// Method to return the URL of an hypertext from email management
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="wait"></param>
        /// <param name="path">XPath of the hypertext</param>
        /// <returns>Returns the link of that text</returns>
        protected static string ReturnURL(WebDriverWait wait, string path)
        {
            return ReturnIWebElementObject(wait, path).GetAttribute("href");
        }
        /// <summary>
        /// Method to set the parameters in locators 
        /// Usage: var formattedString = ReturnLocatorByPassingAnInputString(_, _);
        /// </summary>
        /// <param name="locator">Name of the locator variable</param>
        /// <param name="inputParam">Value to be set inside that variable</param>
        /// <returns></returns>
        protected string ReturnLocatorByPassingAnInputString(string locator, string inputParam) 
        {
            return string.Format(locator, inputParam);
        }
    }
}
