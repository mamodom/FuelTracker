using System.Linq;

namespace FuelTracker.Storage.Core
{
    public interface IRepository<T> : IQueryable<T>
    {
        void Add(T obj);
    }
}