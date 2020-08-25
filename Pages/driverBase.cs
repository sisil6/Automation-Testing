namespace LastExamSolving.Pages
{
    using System;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;

    public class DriverBase
    {
        public DriverBase(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebDriver Driver { get;  }

    }
    
}