namespace LastExamSolving.Pages.MainPage

{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;
    using LastExamSolving.Pages;
    using System.Collections.Generic;
    using System.Linq;
    using LastExamSolving.Pages.MainPage;

    public partial class BasePage
    {
        //GoogleSearch map
        public IWebElement SearchField => Driver.FindElement(By.Name("q"));
        public IWebElement FirstSentence => Driver.FindElement(By.XPath("//*[@id=\"rso\"]/div[1]/div/div[1]/a"));
        
       

        //SoftUniLearnings map
        public IWebElement CookieButton => Driver.FindElement(By.Id("header-nav"));
        public IWebElement Learnings => Driver.FindElement(By.LinkText("ОБУЧЕНИЯ"));
        public IWebElement QaCourse => Driver.FindElement(By.LinkText("QA Fundamentals - септември 2020"));
        public IWebElement HeaderCheck => Driver.FindElement(By.TagName("h1"));
    }



}

