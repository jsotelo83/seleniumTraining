using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SP_Challenge.StepDefinitions
{
    [Binding]
    public sealed class Wiki_SearchEngineSteps
    {
        [Given(@"I have entered Taylor Swift into search text box")]
        public void GivenIHaveEnteredTaylorSwiftIntoSearchTextBox()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click search button")]
        public void WhenIClickSearchButton()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I see Taylor Swift article result page loaded on the screen")]
        public void ThenISeeTaylorSwiftArticleResultPageLoadedOnTheScreen()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I see expected studio albumns properly displayed on the screen")]
        public void ThenISeeExpectedStudioAlbumnsProperlyDisplayedOnTheScreen()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I see hover message appears properly on the screen for Reputation albumn")]
        public void ThenISeeHoverMessageAppearsProperlyOnTheScreenForReputationAlbumn()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
