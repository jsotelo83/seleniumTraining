Feature: Wiki_HomePage
	Navigate to wikipedia page and validate it load successfully

@smoke
Scenario: Navigate to wikipedia page 
	Given I have entered to wikipedia home page
	Then I see wikipedia site loaded on the screen
