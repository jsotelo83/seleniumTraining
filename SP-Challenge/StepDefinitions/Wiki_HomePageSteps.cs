using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using SP_Challenge.Pages;
using TechTalk.SpecFlow;


namespace SP_Challenge.StepDefinitions
{
    [Binding]
    public class Wiki_HomePageSteps

    {
        private readonly IWebDriver webDriver;

        public Wiki_HomePageSteps()
        {
            this.webDriver = (IWebDriver)ScenarioContext.Current["webDriver"];
            homePage = new HomePage(this.webDriver);
        }

        HomePage homePage;
       
        [Given(@"I have entered to wikipedia home page")]
        public void GoToHomePage()
        {
            homePage.goToHome();
        }

        [Then(@"I see wikipedia site loaded on the screen")]
        public void ValidateCurrentURL()
        {
            homePage.validateCurrentURL(homePage.getBaseURL());
        }

    }
}
