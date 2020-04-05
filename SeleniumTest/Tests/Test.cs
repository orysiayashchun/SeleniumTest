using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
namespace SeleniumTest.Tests

{
    [TestFixture]
    public class TestCase
    {
        private readonly IWebDriver driver;
        private static readonly string url = "http://automationpractice.com/index.php";
        private static readonly TimeSpan implisitWait = TimeSpan.FromMilliseconds(3000);
        private WebDriverWait wait;
        public TestCase()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(3000);
        }
        [OneTimeTearDown]
        public void OneTimeTearDown() => driver.Quit();//видаляє exe
        [TestCase(true, "Blouse")]
        [TestCase(false, "Blouce")]
        public void Test(bool isPositive, string text)
        {
            driver.FindElement(By.Id("search_query_top")).Click();
            driver.FindElement(By.Id("search_query_top")).SendKeys(text);
            driver.FindElement(By.Id("search_query_top")).SendKeys(Keys.Enter);
            driver.FindElement(By.Id("search_query_top")).Clear();
            wait = new WebDriverWait(driver,TimeSpan.FromMilliseconds(750));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            //wait.Until(x=>x.FindElements(By.));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.Zero;
        }
        static void Main(string[] args)
        {

        }
    }
   
}
