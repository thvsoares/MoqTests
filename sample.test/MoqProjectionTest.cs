using System;
using System.Collections.Generic;
using System.Linq;
using Moq;
using NUnit.Framework;
using Sample.Model;
using Sample.Repository;

namespace Sample.Test
{
    public class MoqProjectionTest
    {
        private Mock<IRepository<Course>> _Subject;

        private IEnumerable<Course> _Data;

        [SetUp]
        public void Setup()
        {
            _Subject = new Mock<IRepository<Course>>();
        }

        [Test]
        public void GetItemById()
        {
            _Subject
                .Setup(s =>
                    s.Get(It.Is<ByIdSpecification<Course>>(e => e.Id == 1)))
                .Verifiable();

            _Subject.Object.Get(new ByIdSpecification<Course>(1));

            _Subject.Verify();
        }

        [Test]
        public void GetItemByIdWithAnonimousProjection()
        {
            _Subject
                .Setup(s =>
                    s
                        .Get(It.Is<ByIdSpecification<Course>>(e => e.Id == 1),
                        It.IsAny<Func<Course, It.IsAnyType>>()))
                .Verifiable();

            _Subject.Object.Get(new ByIdSpecification<Course>(1), p => new { p.Id, p.Name, CountClasses = p.Classes?.Count() ?? 0});

            _Subject.Verify();
        }
    }
}
