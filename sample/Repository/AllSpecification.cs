using System;
using Sample.Model;

namespace Sample.Repository
{
    public class AllSpecification : ISpecification<IEntity>
    {
        public bool IsSatisfiedBy(IEntity target) => true;
    }
}
