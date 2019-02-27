using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SP_Challenge.StepDefinitions
{
    [Binding]
    public sealed class ExtendedSteps
    {
        public readonly EmployeeDetails employee;

        public ExtendedSteps(EmployeeDetails emp)
        {
            this.employee = emp;
        }

        [Then(@"I should get the same value from Extended steps")]
        public void ThenIShouldGetTheSameValueFromExtendedSteps()
        {
            Console.WriteLine(employee.Name);
            Console.WriteLine(employee.Age);
            Console.WriteLine(employee.Phone);
            Console.WriteLine(employee.Email);
        }

    }
}
