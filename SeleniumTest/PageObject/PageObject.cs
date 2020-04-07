using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
namespace SeleniumTest.PageObject
{
    public abstract class PageObject
    {
        protected readonly IWebDriver Driver;
        public PageObject(IWebDriver driver) => Driver = driver;
    }
}
