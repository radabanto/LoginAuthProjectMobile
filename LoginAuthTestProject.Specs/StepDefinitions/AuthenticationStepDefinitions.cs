using FluentAssertions;
using FluentAssertions.Execution;
using LoginAuthTestProject.Specs.Drivers;
using LoginAuthTestProject.Specs.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using TechTalk.SpecFlow;

namespace LoginAuthTestProject.Specs.StepDefinitions
{
    [Binding]
    public class AuthenticationStepDefinitions
    {
        TestAndroidDriver _stepsDriver;

        public AuthenticationStepDefinitions(TestAndroidDriver androidDriver)
        {
            _stepsDriver = androidDriver;
        }

        #region Given
        [Given("User is in Xamarin App Home")]
        public void GivenUserIsInXamarinAppHome()
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 
            AndroidHomePage _homePage = new AndroidHomePage(_stepsDriver);
            var titleElement = _homePage.GetLearnMoreButton();
            titleElement.Text.Should().Be("LEARN MORE");
        }

        [Given("User is Logged out of App")]
        public void GivenUserIsLoggedOutOfApp()
        {
            WhenUserNavigatesToHamburgerMenu();
            WhenUserSelectsLogoutFromHamburgerMenu();
        }
        #endregion

        #region When
        [When("User navigates to hamburger menu")]
        public void WhenUserNavigatesToHamburgerMenu()
        {
            AndroidHomePage _homePage = new AndroidHomePage(_stepsDriver);
            _homePage.ClickHamburgerMenuButton();
        }

        [When("User selects logout from hamburger menu")]
        public void WhenUserSelectsLogoutFromHamburgerMenu()
        {
            AndroidHomePage _homePage = new AndroidHomePage(_stepsDriver);
            _homePage.ClickLogoutWithinHamburgerFlyout();
        }

        [When("User logs in to the App")]
        public void WhenUserLogsInToTheApp()
        {
            AndroidLoginPage _loginPage = new AndroidLoginPage(_stepsDriver);
            _loginPage.ClickLogin();
        }
        #endregion


        #region Then
        [Then("User is taken back to Xamarin App Login Page")]
        public void ThenUserIsTakenBackToXamarinAppLoginPage()
        {
            AndroidLoginPage _loginPage = new AndroidLoginPage(_stepsDriver);
            AndroidElement loginButton;
            try
            {
                loginButton = _loginPage.GetLoginButton();
            }
            catch
            {
                throw new AssertionFailedException("Login Button not found; must not be login page");
            }

        }

        [Then("User is taken to the Xamarin App Home About Page")]
        public void ThenUserIsTakenToTheXamarinAppHomeAboutPage()
        {
            AndroidHomePage _homePage = new AndroidHomePage(_stepsDriver);
            _homePage.GetLearnMoreButton().Text.Should().Be("LEARN MORE");
        }
        #endregion
    }
}