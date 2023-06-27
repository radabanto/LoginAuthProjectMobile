Feature: Authentication
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](LoginAuthTestSample.Specs/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

Scenario: Logout of Xamarin sample App
	Given User is in app home page
	When User navigates to hamburger menu
	And User clicks on logout
	Then the user is logged out of the application