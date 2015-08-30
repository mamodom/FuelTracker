using System.Collections.Generic;
using System.Linq;
using FuelTracker.Core.Abstract.Factories;
using FuelTracker.Core.Commands;
using FuelTracker.Core.Entities;
using FuelTracker.Libs;
using FuelTracker.Storage.Core;

namespace FuelTracker.Core.Concrete.Handlers
{
    public class ListFillUpQueryHandler : IQueryHandler<ListFillUpQuery, IEnumerable<FillUpPresenter>>
    {
        private readonly IRepository<FillUp> _fillUps;
        private readonly IFillUpPresenterFactory _fillUpPresenterFactory;

        public ListFillUpQueryHandler(IRepository<FillUp> fillUps, IFillUpPresenterFactory fillUpPresenterFactory)
        {
            _fillUps = fillUps;
            _fillUpPresenterFactory = fillUpPresenterFactory;
        }

        public IEnumerable<FillUpPresenter> Handle(ListFillUpQuery query) =>
            _fillUps.Select(_fillUpPresenterFactory.Create);
    }
}