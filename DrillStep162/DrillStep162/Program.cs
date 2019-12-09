using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrillStep162
{
    class Program
    {
        static void Main(string[] args)
        {
            const string mathematics = "I'm bad in math.";
            var name = "J";

            Console.WriteLine("Hello, I'm  " + name + " and " + mathematics);
            name = name + "O";
            Console.WriteLine("Hello, I'm " + name + " and " + mathematics);

            Console.ReadLine();

            Person firstPerson = new Person("J", "O");
            var secondPerson = new Person("J.O.");
            
            Console.WriteLine(firstPerson.FirstName + " " + firstPerson.LastName);
            Console.WriteLine(secondPerson.FirstName + " " + secondPerson.LastName);

            Console.ReadLine();

        }
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }


            public Person(string firstName, string lastName)
            {
                FirstName = firstName;
                LastName = lastName;
            }

            public Person(string firstName) : this(firstName, "Jo")
            {

            }

        }
    }
}
