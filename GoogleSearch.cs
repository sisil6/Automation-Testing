using LastExamSolving.Pages.MainPage;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;

namespace LastExamSolving
{
    [TestFixture]
    public class GoogleSearch
    {
        private IWebDriver _driver; 

        private BasePage _basePage;


        [SetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            _basePage = new BasePage(_driver);
        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                string fileName = TestContext.CurrentContext.Test.Name;
                _basePage.TakeScreenshot(fileName);
            }
            _driver.Quit();
        }

        [Test]
        public void Test01_GoogleSearch()
        {

            //arrange
            _driver.Manage().Window.Maximize();

            //act
            _driver.Navigate().GoToUrl("https://google.com");

            
            _basePage.SearchField.SendKeys("Selenium");

            _basePage.SearchField.SendKeys(Keys.Enter);
            TimeSpan.FromSeconds(1);
            _basePage.FirstSentence.Click();

            //assert
            Assert.AreEqual("SeleniumHQ Browser Automation", _driver.Title);
           
        }


    }
}

