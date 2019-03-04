using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using SP_Challenge.Pages;
using SP_Challenge.Tests;
using TechTalk.SpecFlow;

namespace SP_Challenge
{
    [Binding]
    public class TestFixture
    {
    
        [BeforeFeature]
        public static void CalledFirstonFeature()
        {
            Console.WriteLine("Calling before Features");
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            BaseTest.Initialize();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            BaseTest.EndTest();
        }
    }
}
