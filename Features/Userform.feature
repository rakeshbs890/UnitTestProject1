﻿Feature: Userform
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@positive @UI @Fix3452
Scenario: User Details form entry verification
	Given I navigate to application
	And I enter username and password
		| UserName | Password  |
		| admin    | admin    |
	And I click login
	And I start entering user form details like
		| Initial | FirstName | MiddleName | Language |
		| k       | Karthik   | k          | Hindi    |
	And I click submit button
	Then I verify the entered user form details in the application database
		| Initial | FirstName | MiddleName |
		| k      | Karthik   |   k         |
	Then I logout of application