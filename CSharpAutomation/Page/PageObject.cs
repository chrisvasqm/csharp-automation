using OpenQA.Selenium;

namespace CSharpAutomation.Page
{
    class PageObject
    {
        protected IWebDriver _driver;

        public PageObject(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
