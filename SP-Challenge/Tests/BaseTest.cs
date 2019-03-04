using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SP_Challenge.Tests
{
    class BaseTest
    {
        public static IWebDriver driver;

        [SetUp]
        public static void Initialize()
        {
            driver = new ChromeDriver();
        }

        [TearDown]
        public static void EndTest()
        {
            driver.Quit();
        }
    }
}
