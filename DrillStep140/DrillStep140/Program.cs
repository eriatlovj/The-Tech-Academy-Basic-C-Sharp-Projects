using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrillStep140
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee() { firstName = "Joe", lastName = "Black", ID = 01 });
            employees.Add(new Employee() { firstName = "Goku", lastName = "Son", ID = 02 });
            employees.Add(new Employee() { firstName = "Gohan", lastName = "Son", ID = 03 });
            employees.Add(new Employee() { firstName = "Majin", lastName = "Buu", ID = 04 });
            employees.Add(new Employee() { firstName = "Joe", lastName = "White", ID = 05 });
            employees.Add(new Employee() { firstName = "Goten", lastName = "Son", ID = 06 });
            employees.Add(new Employee() { firstName = "Yusuke", lastName = "Urameshi", ID = 07 });
            employees.Add(new Employee() { firstName = "Ray", lastName = "Amuro", ID = 08 });
            employees.Add(new Employee() { firstName = "Heero", lastName = "Yuy", ID = 09 });
            employees.Add(new Employee() { firstName = "Joe", lastName = "Smith", ID = 10 });

            foreach(Employee person in employees)
            {
                if (person.firstName == "Joe")
                {
                    Console.WriteLine(person.firstName + " " + person.lastName + " ID number: " + person.ID);
                }
            }
            
            Console.ReadLine();

            List<Employee> lambdaList = employees.Where(x => x.firstName == "Joe").ToList();
            foreach (Employee person in lambdaList)
            {
                Console.WriteLine(person.firstName + " " + person.lastName + " ID number: " + person.ID);
            }

            Console.ReadLine();

            List<Employee> lambdaListID = employees.Where(x => x.ID > 5).ToList();
            foreach (Employee person in lambdaListID)
            {
                Console.WriteLine(person.firstName + " " + person.lastName + " ID number: " + person.ID);
            }

            Console.ReadLine();

        }
    }
}
