using Ninject.Modules;

namespace FuelTracker.Storage.Core.DI.Ninject
{
    public class CoreStorageModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IRepository<>)).To(typeof(Repository<>)).InSingletonScope();
        }
    }
}