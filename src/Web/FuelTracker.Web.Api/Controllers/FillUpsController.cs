using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using FuelTracker.Core.Commands;
using FuelTracker.Libs;

namespace FuelTracker.Web.Api.Controllers
{
    public class FillUpsController : ApiController
    {
        private readonly IQueryHandler<ListFillUpQuery, IEnumerable<FillUpPresenter>> _queryHandler;
        private readonly ICommandHandler<AddFillUpCommand> _commandHandler;

        public FillUpsController(
            IQueryHandler<ListFillUpQuery, IEnumerable<FillUpPresenter>> queryHandler,
            ICommandHandler<AddFillUpCommand> commandHandler)
        {
            _queryHandler = queryHandler;
            _commandHandler = commandHandler;
        }

        public IEnumerable<FillUpPresenter> Get(ListFillUpQuery query) => _queryHandler.Handle(query);

        public HttpResponseMessage Post(AddFillUpCommand command)
        {
             _commandHandler.Handle(command);
            return new HttpResponseMessage();
        }
    }
}
