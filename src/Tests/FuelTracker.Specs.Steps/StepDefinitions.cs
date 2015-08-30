using FuelTracker.Core.Commands;
using FuelTracker.DI.Ninject;
using FuelTracker.Libs;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace FuelTracker.Specs.Steps
{
    [Binding]
    public class StepDefinitions
    {
        private readonly IResolver _resolver;

        public StepDefinitions(IResolver resolver)
        {
            _resolver = resolver;
        }

        [Given(@"I added the following fillup")]
        public void GivenIAddedTheFollowingFillup(Table table)
        {
            table.CreateInstance<AddFillUpCommand>()
                .Pipe(_resolver.GetInstance<ICommandHandler<AddFillUpCommand>>().Handle);

            var instance = _resolver.GetInstance<ICommandHandler<AddFillUpCommand>>();
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