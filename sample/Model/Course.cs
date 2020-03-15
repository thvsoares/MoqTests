using System;
using System.Collections.Generic;

namespace Sample.Model
{
    public class Course
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<Class> Classes { get; set; }
    }
}
