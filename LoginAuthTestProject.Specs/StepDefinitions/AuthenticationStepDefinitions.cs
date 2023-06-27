using TechTalk.SpecFlow;

namespace LoginAuthTestProject.Specs.StepDefinitions
{
    [Binding]
    public sealed class AuthenticationStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        [Given("User is in Xamarin App Home")]
        public void GivenUserIsInXamarinAppHome()
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 

            throw new PendingStepException();
        }

        [When("User navigates to hamburger menu")]
        public void WhenUserNavigatesToHamburgerMenu()
        {
            //TODO: implement act (action) logic

            throw new PendingStepException();
        }

        [When("User selects logout from hamburger menu")]
        public void WhenUserSelectsLogoutFromHamburgerMenu()
        {
            //TODO: implement act (action) logic

            throw new PendingStepException();
        }


        [Then("User is taken back to Xamarin App Login Page")]
        public void ThenUserIsTakenBackToXamarinAppLoginPage()
        {
            //TODO: implement assert (verification) logic

            throw new PendingStepException();
        }
    }
}