using System.Linq;

namespace FuelTracker.Storage.Core
{
    public interface IEntitySet<T> : IQueryable<T>
    {
        void Add(T entity);
    }
}