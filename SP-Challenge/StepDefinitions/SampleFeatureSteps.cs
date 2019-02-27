using SP_Challenge.StepDefinitions;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using SpecFlow.Assist.Dynamic;

namespace SP_Challenge
{
    [Binding]
    public class SampleFeatureSteps
    {
        public readonly EmployeeDetails employee;

        public SampleFeatureSteps(EmployeeDetails emp)
        {
            this.employee = emp;
        }

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int numbers)
        {
            Console.WriteLine(numbers);
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            Console.WriteLine("Pressed Add Button");
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int result)
        {
            if (result == 120)
                Console.WriteLine("The test PASSED");
            else
            {
                Console.WriteLine("The test FAILED");
                throw new Exception("The value is different");
            }
        }

        [When(@"I fill all the mandatory details in form")]
        public void WhenIFillAllTheMandatoryDetailsInForm(Table table)
        {
            var data = table.CreateDynamicSet();
            foreach (var item in data)
            {
                employee.Name = (string)item.Name;
                employee.Age = (int)item.Age;
                employee.Phone = (long)item.Phone;
                employee.Email = (string)item.Email;
            }

            //var details = table.CreateSet<EmployeeDetails>();

            //foreach (EmployeeDetails emp in details)
            //{
            //    Console.WriteLine("The Details of employee : " + emp.Name);
            //    Console.WriteLine("*************************************");
            //    Console.WriteLine(emp.Name);
            //    Console.WriteLine(emp.Age);
            //    Console.WriteLine(emp.Phone);
            //    Console.WriteLine(emp.Email);
            //}

            //work with dynamic assist
            //var  details = table.CreateDynamicSet();

            //foreach (var emp in details)
            //{
            //    Console.WriteLine("The Details of employee : " + emp.Name);
            //    Console.WriteLine("*************************************");
            //    Console.WriteLine(emp.Name);
            //    Console.WriteLine(emp.Age);
            //    Console.WriteLine(emp.Phone);
            //    Console.WriteLine(emp.Email);
            //}

        }

        [When(@"I fill all the mandatory details in form (.*), (.*) and (.*)")]
        public void WhenIFillAllTheMandatoryDetailsInFormJSoteloAnd(string name, int age, Int64 phone)
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("Phone Number : " + phone);

            ScenarioContext.Current["InfoforNextStep"] = "Step1 Passed";
            Console.WriteLine(ScenarioContext.Current["InfoforNextStep"].ToString());

            List<EmployeeDetails> empDetails = new List<EmployeeDetails>()
            {
                new EmployeeDetails()
                {
                    Name = "JSotelo",
                    Age = 35,
                    Phone = 8181853121,
                    Email = "jsotelo@luxoft.com",
                },
                new EmployeeDetails()
                {
                    Name = "MSotelo",
                    Age = 34,
                    Phone = 8181853122,
                    Email = "msotelo@luxoft.com",
                },
                new EmployeeDetails()
                {
                    Name = "LSotelo",
                    Age = 33,
                    Phone = 8181853123,
                    Email = "lsotelo@luxoft.com",
                }
            };

            //Saved the value in the scenario context
            ScenarioContext.Current.Add("EmpDetails", empDetails);

            //Get the value out of the scenario context
            var emplist = ScenarioContext.Current.Get<IEnumerable<EmployeeDetails>>("EmpDetails");

            foreach (EmployeeDetails emp in emplist)
            {
                Console.WriteLine("The employee name is : " + emp.Name);
                Console.WriteLine("The employee age is : " + emp.Age);
                Console.WriteLine("The employee phone is : " + emp.Phone);
                Console.WriteLine("The employee email is : " + emp.Email);
                Console.WriteLine("\n");

            }

            Console.WriteLine(ScenarioContext.Current.ScenarioInfo.Title);
            Console.WriteLine(ScenarioContext.Current.Count);
            Console.WriteLine(ScenarioContext.Current.CurrentScenarioBlock);

        }


    }
}
