namespace LastExamSolving.Pages.MainPage
{
    using OpenQA.Selenium;
    using LastExamSolving.Pages;
    using System;
    using System.IO;
    using System.Collections.Generic;
    using System.Text;
    using OpenQA.Selenium.Interactions;
    using System.Threading;
    using OpenQA.Selenium.Support.UI;

    public partial class BasePage : DriverBase
    {
        public BasePage(IWebDriver driver) : base(driver)
        {
        }
        public void NavigateTo(string url)
        {
            this.Driver.Url = url;
            Driver.Manage().Window.Maximize();
        }

        public void TakeScreenshot(string fileName)
        {
            var screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
            screenshot.SaveAsFile(@"..\\..\\..\\screenshots\" + fileName + ".png", ScreenshotImageFormat.Png);
        }

        public void Type(IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text);
        }



    }
}



