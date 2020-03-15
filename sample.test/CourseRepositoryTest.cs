using System.Collections.Generic;
using NUnit.Framework;
using Sample.Model;
using Sample.Repository;

namespace Sample.Test
{
    public class CourseRepositoryTest
    {
        private CourseRepository _Subject;

        [SetUp]
        public void Setup()
        {
            _Subject = new CourseRepository();
            _Subject
                .Add(new Course()
                {
                    Name = "Angular",
                    Classes =
                        new List<Class>()
                        {
                            new Class() { Id = 11, Name = "Directives" },
                            new Class() { Id = 12, Name = "Reactive Forms" }
                        }
                });
            _Subject
                .Add(new Course()
                {
                    Name = "Docker",
                    Classes =
                        new List<Class>()
                        {
                            new Class() { Id = 11, Name = "Containers" },
                            new Class() { Id = 12, Name = "Swarm" }
                        }
                });
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}
