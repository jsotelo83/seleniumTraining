using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace SP_Challenge
{
    [Binding]
    public class TestFixture 
    {

        [BeforeScenario]
        public void InitializeWebDriver()
        {
            Console.WriteLine("Before scenario");
            var webDriver = new ChromeDriver();
            //objectContainer.RegisterInstanceAs<IWebDriver>(webDriver);
            ScenarioContext.Current["webDriver"] = webDriver;
        }

        [AfterScenario]
        public void DriverQuit()
        {
            Console.WriteLine("After scenario");
            var webDriver = (IWebDriver)ScenarioContext.Current["webDriver"];
            webDriver.Quit();
        }
    }
}
