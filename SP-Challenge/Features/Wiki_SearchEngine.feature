Feature: Wiki_SearchEngine
	Navigate to wikipedia page and test search engine

@smoke
Scenario: Search Taylor Swift in Wikipedia search bar
	Given I have entered to wikipedia home page
	And I have entered Taylor Swift into search text box
	Then I see Taylor Swift article result page loaded on the screen
	
Scenario: Search Taylor Swift in Wikipedia search bar and validate expected studio albumns
	Given I have entered to wikipedia home page
	And I have entered Taylor Swift into search text box
	Then I see expected studio albumns properly displayed on the screen
	#| albums    |
	#| Taylor Swift   |
	#| Fearless   |
	#| Speak Now   |
	#| Red  |
	#| 1989   |
	#| Reputation   |


	
Scenario: Search Taylor Swift in Wikipedia search bar and validate hover message appears
	Given I have entered to wikipedia home page
	And I have entered Taylor Swift into search text box
	Then I see hover message appears properly on the screen for Reputation albumn

