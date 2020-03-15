using System;
using Sample.Model;

namespace Sample.Repository
{
    public class ByIdSpecification<T> : ISpecification<T> where T: IEntity
    {
        public readonly long Id;
        public ByIdSpecification(long id) => Id = id;
        public bool IsSatisfiedBy(T target) => target.Id == Id;
    }
}
