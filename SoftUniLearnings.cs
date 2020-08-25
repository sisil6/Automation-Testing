using LastExamSolving.Pages.MainPage;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.IO;
using System.Reflection;

namespace LastExamSolving
{
    [TestFixture]
    public class SoftUniLearnings
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
        public void Test01_SoftUniLearnings()
        {
            //arrange
            _driver.Manage().Window.Maximize();

            //act
            _driver.Navigate().GoToUrl("https://softuni.bg");
            _basePage.CookieButton.Click();
            _basePage.Learnings.Click();
            Actions action = new Actions(_driver);
            action.MoveToElement(_basePage.QaCourse).Perform();
            _basePage.QaCourse.Click();

            //assert
            Assert.AreEqual("QA Fundamentals - септември 2020", _basePage.HeaderCheck.Text);
        }
    }
}
