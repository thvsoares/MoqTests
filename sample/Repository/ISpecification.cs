using System;

namespace Sample.Repository
{
    public interface ISpecification<T> where T : class
    {
        bool IsSatisfiedBy(T target);
    }
}
