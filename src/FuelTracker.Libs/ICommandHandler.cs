namespace FuelTracker.Libs
{
    public interface ICommandHandler<T>
    {
        void Handle(T command);
    }
}