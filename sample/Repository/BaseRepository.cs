using System;
using System.Collections.Generic;
using System.Linq;
using Sample.Model;

namespace Sample.Repository
{
    public abstract class BaseRepository<T> : IRepository<T> where T: Class, IEntity
    {
        protected HashSet<T> _data = new HashSet<T>();

        public long Add(T item)
        {
            if (!_data.Contains(item))
            {
                item.Id = _data.Max(s => s.Id) + 1;
                _data.Add (item);
            }
            return item.Id;
        }

        public IEnumerable<T> Get(ISpecification<T> spec)
        {
            return _data.Where(w => spec.IsSatisfiedBy(w));
        }

        public IEnumerable<TResult>
        Get<TResult>(ISpecification<T> spec, Func<T, TResult> projection)
        {
            return Get(spec).Select(s => projection(s));
        }

        public int Delete(ISpecification<T> spec)
        {
            return _data.RemoveWhere(p => spec.IsSatisfiedBy(p));
        }
    }
}
