using System.Collections.Generic;
using FuelTracker.Core.Abstract.Factories;
using FuelTracker.Core.Commands;
using FuelTracker.Core.Concrete.Factories;
using FuelTracker.Core.Concrete.Handlers;
using FuelTracker.Libs;
using FuelTracker.Libs.Extensions;
using FuelTracker.Storage.InMemory.DI.Ninject;
using Ninject;

namespace FuelTracker.DI.Ninject
{
    public static class ResolverFactory
    {
        public static IResolver Create() =>
            new StandardKernel()
                .Tap(RegisterServices)
                .Then(kernel => new NinjectResolverAdapter(kernel));

        public static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<ICommandHandler<AddFillUpCommand>>().To<AddFillUpCommandHandler>();
            kernel.Bind<IQueryHandler<ListFillUpQuery, IEnumerable<FillUpPresenter>>>().To<ListFillUpQueryHandler>();

            kernel.Bind<IFillUpFactory>().To<FillUpFactory>();
            kernel.Bind<IFillUpPresenterFactory>().To<FillUpPresenterFactory>();

            kernel.Load<InMemoryStorageModule>();
        }
    }
}