using FuelTracker.Core.Abstract.Factories;
using FuelTracker.Core.Commands;
using FuelTracker.Core.Entities;
using FuelTracker.Libs;
using FuelTracker.Libs.Extensions;
using FuelTracker.Storage.Core;

namespace FuelTracker.Core.Concrete.Handlers
{
    public class AddFillUpCommandHandler : ICommandHandler<AddFillUpCommand>
    {
        private readonly IFillUpFactory _fillUpFactory;
        private readonly IRepository<FillUp> _fillUps;

        public AddFillUpCommandHandler(IRepository<FillUp> fillUps, IFillUpFactory fillUpFactory)
        {
            _fillUps = fillUps;
            _fillUpFactory = fillUpFactory;
        }

        public void Handle(AddFillUpCommand command) =>
            _fillUpFactory.Create(command)
                .Finally(_fillUps.Add);
    }
}