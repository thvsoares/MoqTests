using System;
using System.Collections.Generic;
using Sample.Repository;

namespace Sample.Model
{
    public class Course : IEntity
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<Class> Classes { get; set; }
    }
}
