using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            Console.WriteLine("Calling before Scenario");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine("Calling after Scenario");
        }
    }
}
