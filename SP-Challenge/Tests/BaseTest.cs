using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SP_Challenge.Tests
{
    class BaseTest
    {
        public IWebDriver driver;

        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
        }

        [TearDown]
        public void EndTest()
        {
            driver.Quit();
        }
    }
}
