using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SP_Challenge.StepDefinitions
{
    [Binding]
    public sealed class UserLoginStep
    {
        [Given(@"I login to application")]
        [Scope(Tag = "user")]
        public void GivenILoginToApplication()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
