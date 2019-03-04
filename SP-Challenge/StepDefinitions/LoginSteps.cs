using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SP_Challenge.StepDefinitions
{
    [Binding]
    public sealed class LoginSteps
    {
        [Given(@"I have open the application")]
        public void GivenIHaveOpenTheApplication()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I login to application")]
        [Scope(Tag = "customer")]
        public void GivenILoginToApplication()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I see customer portal")]
        public void ThenISeeCustomerPortal()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I see user portal")]
        public void ThenISeeUserPortal()
        {
            ScenarioContext.Current.Pending();
        }


    }
}
