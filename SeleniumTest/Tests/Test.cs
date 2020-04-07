using System;
using System.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumTest.Framework;
using SeleniumTest.PageObject;

namespace SeleniumTest.Tests
{
    public abstract class TestCase
    {
        protected IWebDriver driver;
        protected TestCase()
        {
            driver = Selenium.GetDriver(Drivers.Chrome);
            driver.Navigate().GoToUrl(Settings.url);
        }
        
    }
   
}
