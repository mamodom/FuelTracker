using BoDi;
using FuelTracker.DI.Ninject;
using FuelTracker.Libs;
using TechTalk.SpecFlow;

namespace FuelTracker.Specs.Steps
{
    [Binding]
    public class Hooks
    {
        private readonly IObjectContainer _objectContainer;

        public Hooks(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
            
        }

        [BeforeScenario]
        public void RegisterResolver() => ResolverFactory
            .Create()
            .Pipe(resolver => _objectContainer
                .RegisterInstanceAs(resolver));
    }
}