using System;

namespace Sample.Repository
{
    public interface ISpecification<T> where T : IEntity
    {
        bool IsSatisfiedBy(T target);
    }
}
