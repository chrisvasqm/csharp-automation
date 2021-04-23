using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace CSharpAutomation.Page
{
    class PageObject
    {
        protected IWebDriver _driver;
        protected WebDriverWait _wait;

        public PageObject(IWebDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }
    }
}
