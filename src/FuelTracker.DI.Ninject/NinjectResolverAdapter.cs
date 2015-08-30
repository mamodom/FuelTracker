using Ninject;

namespace FuelTracker.DI.Ninject
{
    public class NinjectResolverAdapter : IResolver
    {
        private readonly StandardKernel _standardKernel;

        public NinjectResolverAdapter(StandardKernel standardKernel)
        {
            _standardKernel = standardKernel;
        }

        public T Get<T>()
        {
            return _standardKernel.Get<T>();
        }
    }
}