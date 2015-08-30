using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace FuelTracker.Storage.Core
{
    public class Repository<T> : IRepository<T>
    {
        private readonly IEntitySet<T> _entities;

        public Repository(IEntitySet<T> entities)
        {
            _entities = entities;
        }


        public void Add(T obj) => _entities.Add(obj);

        public IEnumerator<T> GetEnumerator() => _entities.GetEnumerator();

        public Expression Expression => _entities.Expression;

        public Type ElementType => _entities.ElementType;

        public IQueryProvider Provider => _entities.Provider;

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}