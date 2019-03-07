using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SP_Challenge.Pages;
using TechTalk.SpecFlow;

namespace SP_Challenge.StepDefinitions
{
    [Binding]
    public sealed class Wiki_SearchEngineSteps
    {
        private readonly IWebDriver webDriver;
        private string textSearch;

        public Wiki_SearchEngineSteps()
        {
            this.webDriver = (IWebDriver)ScenarioContext.Current["webDriver"];
            homePage = new HomePage(this.webDriver);
            articlePage = new ArticlePage(this.webDriver);
        }

        HomePage homePage;
        ArticlePage articlePage;

        [Given(@"I have entered (.*) into search text box")]
        public void EntertextIntoSearchTextBox(string text)
        {
            textSearch = text;
            homePage.search(textSearch);
        }

        //[When(@"I click search button")]
        //public void WhenIClickSearchButton()
        //{
        //    ScenarioContext.Current.Pending();
        //}

        [Then(@"I see (.*) article result page loaded on the screen")]
        public void ValidateArticleResultPageLoaded(string text)
        {
            textSearch = text;
            articlePage.validateExpectedArticle(textSearch);
        }

        [Then(@"I see expected studio albumns properly displayed on the screen")]
        public void ValidateStudioAlbumnsProperlyDisplayed()
        {
            string[] albums;
            albums = new string[6];

            albums[0] = "Taylor Swift";
            albums[1] = "Fearless";
            albums[2] = "Speak Now";
            albums[3] = "Red";
            albums[4] = "1989";
            albums[5] = "Reputation";

            articlePage.validateExpectedStudioAlbums(albums);
        }

        [Then(@"I see hover message appears properly on the screen for Reputation albumn")]
        public void ValidateHoverMessageAppearsProperly()
        {
            articlePage.validateHoverMessageAppears();
        }

    }
}
