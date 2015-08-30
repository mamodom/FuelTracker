namespace FuelTracker.Libs
{
    public interface IQueryHandler<in TQuery, out TResponse>
    {
        TResponse Handle(TQuery query);
    }
}