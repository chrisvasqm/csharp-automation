using CSharpAutomation.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CSharpAutomation
{
    public class GoogleTests
    {
        private IWebDriver _driver;
        private Google _google;

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _google = new Google(_driver);
        }

        [Test]
        public void Google_CanNavigateToSearchPage()
        {
            _google.Open();

            Assert.AreEqual("https://www.google.com/", _driver.Url);
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}