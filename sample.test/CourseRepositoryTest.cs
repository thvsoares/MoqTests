using System.Collections.Generic;
using System.Linq;
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
        public void AddItem()
        {
            var course = new Course() { Name = "Unit Testing" };
            _Subject.Add (course);
            Assert.AreNotEqual(0, course.Id);
            Assert
                .AreEqual(3,
                _Subject.Get(new AllSpecification<Course>()).Count());
        }
    }
}
