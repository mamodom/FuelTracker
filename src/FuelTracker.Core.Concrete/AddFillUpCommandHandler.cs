using FuelTracker.Core.Abstract;
using FuelTracker.Core.Commands;
using FuelTracker.Core.Entities;
using FuelTracker.Libs;
using FuelTracker.Storage.Core;

namespace FuelTracker.Core.Concrete
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

        public void Handle(AddFillUpCommand command)
        {
            _fillUpFactory.Create(command)
                .Pipe(_fillUps.Add);
        }
    }
}