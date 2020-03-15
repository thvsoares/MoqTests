using System;
using Sample.Model;

namespace Sample.Repository
{
    public class AllSpecification<T> : ISpecification<T> where T: IEntity
    {
        public bool IsSatisfiedBy(T target) => true;
    }
}
