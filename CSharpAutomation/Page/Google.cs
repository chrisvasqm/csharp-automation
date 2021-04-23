using OpenQA.Selenium;

namespace CSharpAutomation.Page
{
    class Google : PageObject
    {

        public Google(IWebDriver driver) : base(driver)
        {

        }
       
        public void Open()
        {
            _driver.Navigate().GoToUrl("https://www.google.com");
        }
    }
}
