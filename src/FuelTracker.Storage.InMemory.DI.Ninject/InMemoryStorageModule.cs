using FuelTracker.Storage.Core;
using FuelTracker.Storage.Core.DI.Ninject;
using Ninject;
using Ninject.Modules;

namespace FuelTracker.Storage.InMemory.DI.Ninject
{
    public class InMemoryStorageModule : NinjectModule
    {
        public override void Load()
        {
            Kernel.Load<CoreStorageModule>();
            Bind(typeof (IEntitySet<>)).To(typeof (InMemoryEntitySet<>));
        }
    }
}