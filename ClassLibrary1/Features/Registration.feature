Feature: spectest
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Register
	Given I go to the url 'https://www.google.com'
	When I click on the 'Register' element
	And I enter 'username' on the 'usernameByID' element
	Then I should see that the element 'Signin' is displayed
	
