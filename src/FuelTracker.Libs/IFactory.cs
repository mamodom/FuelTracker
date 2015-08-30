namespace FuelTracker.Libs
{
    public interface IFactory<in T, out T1>
    {
        T1 Create(T command);
    }
}