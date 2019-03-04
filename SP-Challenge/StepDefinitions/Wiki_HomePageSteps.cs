using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SP_Challenge.Pages;
using SP_Challenge.Tests;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SP_Challenge.StepDefinitions
{
    [Binding]
    public class Wiki_HomePageSteps
    {
        public IWebDriver driver;

        [Given(@"I have entered to wikipedia home page")]
        public void GivenIHaveEnteredToWikipediaHomePage()
        {
            
        }

        [Then(@"I see wikipedia site loaded on the screen")]
        public void ThenISeeWikipediaSiteLoadedOnTheScreen()
        {
            HomePage homePage = new HomePage(driver);
            homePage.validateCurrentURL(homePage.getBaseURL());
        }

    }
}
