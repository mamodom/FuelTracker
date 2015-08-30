using FuelTracker.Core.Commands;
using FuelTracker.Core.Entities;
using FuelTracker.Libs;

namespace FuelTracker.Core.Abstract.Factories
{
    public interface IFillUpPresenterFactory : IFactory<FillUp,FillUpPresenter>
    {
    }
}