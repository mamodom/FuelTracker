using FuelTracker.Core.Abstract.Factories;
using FuelTracker.Core.Commands;
using FuelTracker.Core.Concrete.Factories;
using FuelTracker.Core.Concrete.Handlers;
using FuelTracker.Libs;
using FuelTracker.Storage.InMemory.DI.Ninject;
using Ninject;

namespace FuelTracker.DI.Ninject
{
    public class ResolverFactory
    {
        public static IResolver Create()
        {
            var kernel = new StandardKernel();

            kernel.Bind<ICommandHandler<AddFillUpCommand>>().To<AddFillUpCommandHandler>();

            kernel.Bind<IFillUpFactory>().To<FillUpFactory>();

            kernel.Load<InMemoryStorageModule>();

            return new NinjectResolverAdapter(kernel);
        }
    }
}