using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using FuelTracker.Core.Commands;
using FuelTracker.Libs;

namespace FuelTracker.Web.Api.Controllers
{
    public class FillUpsController : ApiController
    {
        private readonly IQueryHandler<ListFillUpQuery, IEnumerable<FillUpPresenter>> _handler;

        public FillUpsController(IQueryHandler<ListFillUpQuery,IEnumerable<FillUpPresenter>> handler)
        {
            _handler = handler;
        }

        public string Get(int id)
        {
            return $"Hello {id} world";
        }
    }
}
