using System.Collections.Generic;
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
            kernel.Bind<IQueryHandler<ListFillUpQuery, IEnumerable<FillUpPresenter>>>().To<ListFillUpQueryHandler>();

            kernel.Bind<IFillUpFactory>().To<FillUpFactory>();
            kernel.Bind<IFillUpPresenterFactory>().To<FillUpPresenterFactory>();

            kernel.Load<InMemoryStorageModule>();

            return new NinjectResolverAdapter(kernel);
        }
    }
}