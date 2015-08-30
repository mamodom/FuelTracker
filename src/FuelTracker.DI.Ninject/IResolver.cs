namespace FuelTracker.DI.Ninject
{
    public interface IResolver
    {
        T GetInstance<T>();
    }
}