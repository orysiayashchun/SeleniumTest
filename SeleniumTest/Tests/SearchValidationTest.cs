using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumTest.Framework;
using SeleniumTest.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace SeleniumTest.Tests
{
    [TestFixture]
    public class SearchValidationTest : TestCase
    {
        public MainPage mainPage;
       
        [OneTimeSetUp]
        public void OneTimeSetUp() => mainPage = new MainPage(driver);
        [OneTimeTearDown]
        public void OneTimeTearDown() => driver.Quit();//видаляє exe

        [TestCase(false, "Blouce")]
        [TestCase(true, "Blouse")]
        public void Test(bool isPositive, string text)
        {
            AuthenticationPage authenticationPage = mainPage.ClickOnSearch();
            bool isOk = authenticationPage.EnterSearch(text).IsSearchOk();
            Assert.That(isOk, Is.EqualTo(isPositive),
                $"Search was validated{(isOk ? "successfully" : "unsuccessfully")}");
        }
        static void Main(string[] args)
        {

        }

    }
   
}
