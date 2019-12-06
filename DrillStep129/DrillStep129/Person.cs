using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrillStep129
{
    public abstract class Person
    {
        public int Id { get; set; }


        public abstract void SayName();

        public static bool operator ==(Person person1, Person person2)
        {
            return (person1.Id == person2.Id);
        }

        public static bool operator !=(Person person1, Person person2)
        {
            return (person1.Id != person2.Id);
        }
    }
}
