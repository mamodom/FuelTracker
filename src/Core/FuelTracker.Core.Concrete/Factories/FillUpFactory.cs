using FuelTracker.Core.Abstract.Factories;
using FuelTracker.Core.Commands;
using FuelTracker.Core.Entities;

namespace FuelTracker.Core.Concrete.Factories
{
    public class FillUpFactory : IFillUpFactory
    {
        public FillUp Create(AddFillUpCommand command)
        {
            return new FillUp();
        }
    }
}