using Ninject;

namespace FuelTracker.DI.Ninject
{
    public class NinjectResolverAdapter : IResolver
    {
        private readonly IKernel _standardKernel;

        public NinjectResolverAdapter(IKernel standardKernel)
        {
            _standardKernel = standardKernel;
        }

        public T Get<T>()
        {
            return _standardKernel.Get<T>();
        }
    }
}