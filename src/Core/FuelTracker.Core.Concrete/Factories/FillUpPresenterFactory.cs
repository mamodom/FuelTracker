using FuelTracker.Core.Abstract.Factories;
using FuelTracker.Core.Commands;
using FuelTracker.Core.Entities;

namespace FuelTracker.Core.Concrete.Factories
{
    public class FillUpPresenterFactory : IFillUpPresenterFactory
    {
        public FillUpPresenter Create(FillUp obj)
        {
            return new FillUpPresenter(obj);
        }
    }
}