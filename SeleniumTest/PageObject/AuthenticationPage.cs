using OpenQA.Selenium;
using SeleniumTest.Framework;
using System;
using System.Linq;

namespace SeleniumTest.PageObject
{
    public class AuthenticationPage: PageObject
    {
        private static readonly By createSearchInput=By.Id("search_query_top");
        private static readonly By IsSearch = By.XPath("//form[@id='searchbox']");//form-ok
        public AuthenticationPage(IWebDriver driver) : base(driver)
        { }
        public AuthenticationPage EnterSearch(string text)
        {
            Driver.FindElement(createSearchInput).SendKeys(text);
            Driver.FindElement(createSearchInput).SendKeys(Keys.Enter);
            Driver.FindElement(createSearchInput).Clear();
            return this;
        }
        public bool IsSearchOk()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.Zero;
            bool isOk =Wait.WaitFor(()=> Driver.FindElements(IsSearch).Any());
            Driver.Manage().Timeouts().ImplicitWait = Settings.implicitWait;
            return isOk;
        }
    }
}