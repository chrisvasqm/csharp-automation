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
        public void Open_CanNavigateToSearchPage()
        {
            _google.Open();

            Assert.AreEqual("https://www.google.com/", _driver.Url);
        }

        [Test]
        public void SearchFor_CanSearchForWebsite()
        {
            _google.SearchFor("udemy");

            Assert.That(_google.IsUdemyCardTitleDisplayed(), Is.True);
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}