Feature: SampleFeature
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@smoke
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen

Scenario: Create a new employee with mandatory details
	#Given I have open my application
	#Then I should see employee details page
	When I fill all the mandatory details in form
	| Name    | Age | Phone      | Email              |
	| JSotelo | 35  | 8181853121 | jsotelo@luxoft.com |
	| MSotelo | 34  | 8181853122 | msotelo@luxoft.com |
	| LSotelo | 33  | 8181853122 | lsotelo@luxoft.com |
	#And I click the save button
	#Then I should see all the details saved in my application and DB

Scenario Outline: Create a new employee with mandatory details for different iteration
	#Given I have open my application
	#Then I should see employee details page
	When I fill all the mandatory details in form <Name>, <Age> and <Phone>
	#And I click the save button
	#Then I should see all the details saved in my application and DB
Examples:
	| Name    | Age | Phone      |
	| JSotelo | 35  | 8181853121 |
	| MSotelo | 34  | 8181853122 |
	| LSotelo | 33  | 8181853122 |

Scenario: Check if I could get the details entered via table from Extended Steps
	When I fill all the mandatory details in form
	| Name    | Age | Phone      | Email              |
	| JSotelo | 35  | 8181853121 | jsotelo@luxoft.com |
	Then I should get the same value from Extended steps
