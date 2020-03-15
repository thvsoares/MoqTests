using System;
using Sample.Repository;

namespace Sample.Model
{
    public class Class : IEntity
    {
        public long Id { get; set; }

        public String Name { get; set; }
    }
}
