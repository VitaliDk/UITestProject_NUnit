Feature: TestComponentFeature
	This feature file is for throwaway scenarios that enable the user to test new task/step components

@mytag
Scenario: Test Orders Page Components
    Given the user is logged into the DMI
	When the user searches for all orders submitted after 1st June 2009
	#When the user attempts to log out
    #Then the user is redirected to the DMI login page
