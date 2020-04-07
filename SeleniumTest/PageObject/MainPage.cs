using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
namespace SeleniumTest.PageObject
{
    public class MainPage: PageObject
    {
        private static readonly By searchLine = By.Id("search_query_top");
        public MainPage(IWebDriver driver) : base(driver) { }
        public AuthenticationPage ClickOnSearch()
        {
            Driver.FindElement(searchLine).Click();
            return new AuthenticationPage(Driver);
        }

    }
}
