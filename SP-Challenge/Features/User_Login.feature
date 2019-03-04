Feature: User_Login
	Simple feature to demostrate user Login feature

@user
Scenario: Login for user portal
	Given I have open the application
	And I login to application
	Then I see user portal
