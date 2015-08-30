using FuelTracker.Core.Commands;
using FuelTracker.Core.Concrete;
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

            kernel.Load<InMemoryStorageModule>();

            return new NinjectResolverAdapter(kernel);
        }
    }
}