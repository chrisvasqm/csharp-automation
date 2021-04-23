using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace CSharpAutomation.Page
{
    class Google : PageObject
    {
        private IWebElement _searchBar => _driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[1]/div/div[2]/input"));

        private IWebElement _udemyCardTitle => _driver.FindElement(By.XPath("//*[@text=\"Udemy, Inc.\"]"));

        public Google(IWebDriver driver) : base(driver)
        {

        }

        public void Open()
        {
            _driver.Navigate().GoToUrl("https://www.google.com");
        }

        public void SearchFor(string text)
        {
            if (string.IsNullOrEmpty(text))
                throw new ArgumentException("The text used to search for can not be null or empty");

            _searchBar.SendKeys(text);
            _searchBar.SendKeys(Keys.Enter);
        }

        public bool IsUdemyCardTitleDisplayed()
        { 
            return _udemyCardTitle.Displayed;
        }
    }
}
