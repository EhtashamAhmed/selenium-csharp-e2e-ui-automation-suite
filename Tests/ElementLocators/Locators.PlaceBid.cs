using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquarebookAutomation.Tests.ElementLocators
{
    public partial class Locators : Configurations
    {
        protected const string LOCATOR_ONBEHALFOF_DROPDOWN = "//span[text()='Place bid on behalf of']//following::span[@class='select2-selection__rendered'][1]";
        protected const string LOCATOR_ONBEHALFOFCOMMENT_FIELD = "//textarea[@id='__aaditionalNotes']";
        protected const string LOCATOR_NUMBEROFSHARES_FIELD = "//input[@id='idNumberofSharesInputField']";
        protected const string LOCATOR_BIDPRICE_FIELD = "(//input[@step])[2]";
        protected const string LOCATOR_SETTLEMENTROUTE_DROPDOWN = "//span[text()='Settlement route']//following::span[@class='select2-selection__rendered'][1]";
        protected const string LOCATOR_PLACEBIDPASSWORD_FIELD = "//input[@type='Password']";
        protected const string LOCATOR_PLACEBID_BTN = "//button[@title='Place bid']";
        protected const string LOCATOR_PALCEBIDCANCEL_BTN = "//button[@title='Go back']";
        protected const string LOCATOR_AUCTIONRULESEXPAND_BTN = "//div[text()='Auction Rules']";
    }
}
