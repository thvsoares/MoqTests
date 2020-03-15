using System;
using System.Collections.Generic;

namespace Sample.Repository
{
    public interface IRepository<T> where T : class
    {
        long Add(T item);

        IEnumerable<T> Get(ISpecification<T> spec);

        IEnumerable<TResult>
        Get<TResult>(
            ISpecification<T> spec, Func<T, TResult> projection
        );

        int Delete(ISpecification<T> spec);
    }
}
