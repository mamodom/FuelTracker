namespace FuelTracker.DI.Ninject
{
    public interface IResolver
    {
        T Get<T>();
    }
}