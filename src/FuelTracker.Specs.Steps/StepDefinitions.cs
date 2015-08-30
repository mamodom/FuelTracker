using TechTalk.SpecFlow;

namespace FuelTracker.Specs.Steps
{
    [Binding]
    public class StepDefinitions
    {
        [Given(@"I added the following fillup")]
        public void GivenIAddedTheFollowingFillup(Table table)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I list my fillups")]
        public void WhenIListMyFillups()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I should see the following fillups")]
        public void ThenIShouldSeeTheFollowingFillups(Table table)
        {
            ScenarioContext.Current.Pending();
        }
    }
}