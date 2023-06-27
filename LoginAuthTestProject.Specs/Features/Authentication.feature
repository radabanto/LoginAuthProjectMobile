Feature: Xamarin App

Scenario: Logout from Xamarin Forms
	Given User is in Xamarin App Home
	When User navigates to hamburger menu
	And User selects logout from hamburger menu
	Then User is taken back to Xamarin App Login Page