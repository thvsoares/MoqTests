using System;
using Sample.Model;

namespace Sample.Repository
{
    public class ByIdSpecification : ISpecification<IEntity>
    {
        private readonly long _id;
        public ByIdSpecification(long id) => _id = id;
        public bool IsSatisfiedBy(IEntity target) => target.Id == _id;
    }
}
