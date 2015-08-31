using System.Collections.Generic;
using System.Linq;
using FuelTracker.Libs.Extensions;
using RestSharp;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace FuelTracker.Specs.Steps.WebApi
{
    [Binding]
    public class StepDefinitions
    {
        private readonly RestClient _client;
        private IEnumerable<FillUp> _fillUps;

        public StepDefinitions()
        {
            _client = new RestClient("http://localhost:52236/");
        }

        [Given(@"I added the following fillup")]
        public void GivenIAddedTheFollowingFillup(Table table) =>
            new RestRequest("api/FillUps", Method.POST)
                .Tap(request => table.Rows.ToList().ForEach(row => request.AddParameter(row["Field"], row["Value"])))
                .Then(_client.Execute);

        [When(@"I list my fillups")]
        public void WhenIListMyFillups() =>
            _fillUps = new RestRequest("api/FillUps", Method.GET)
                .Then(_client.Execute<List<FillUp>>)
                .Data;

        [Then(@"I should see the following fillups")]
        public void ThenIShouldSeeTheFollowingFillups(Table table) => table.CompareToSet(_fillUps);
    }
}