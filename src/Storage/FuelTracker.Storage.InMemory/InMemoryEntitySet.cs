using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using FuelTracker.Storage.Core;

namespace FuelTracker.Storage.InMemory
{
    public class InMemoryEntitySet<T> : IEntitySet<T>
    {
        private readonly IQueryable<T> _queryable;
        private readonly ICollection<T> _collection;

        public InMemoryEntitySet()
        {
            _collection = new List<T>();
            _queryable = _collection.AsQueryable();
        }

        public void Add(T entity) => _collection.Add(entity);

        public Expression Expression => _queryable.Expression;

        public Type ElementType => _queryable.ElementType;

        public IQueryProvider Provider => _queryable.Provider;

        public IEnumerator<T> GetEnumerator() => _queryable.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}