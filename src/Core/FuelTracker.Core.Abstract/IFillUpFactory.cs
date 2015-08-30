using FuelTracker.Core.Commands;
using FuelTracker.Core.Entities;
using FuelTracker.Libs;

namespace FuelTracker.Core.Abstract
{
    public interface IFillUpFactory : IFactory<AddFillUpCommand,FillUp>
    {
    }
}