using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrillStep124
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee<string> thingsString = new Employee<string>();
            thingsString.Things = new List<string>();
            thingsString.Things.Add("Thing One");
            thingsString.Things.Add("Thing Two");
            thingsString.Things.Add("Thing Three");

            Employee<int> IntThings = new Employee<int>();
            IntThings.Things = new List<int>();
            IntThings.Things.Add(1);
            IntThings.Things.Add(2);
            IntThings.Things.Add(3);

            foreach (string Items in thingsString.Things)
            {
                Console.WriteLine(Items);
                Console.ReadLine();
            }

            foreach (int Item in IntThings.Things)
            {
                Console.WriteLine(Item);
                Console.ReadLine();
            }



            //Employee employee = new Employee();
            //employee.firstName = "Sample";
            //employee.lastName = "Student";
            //employee.sayName();
            //Console.ReadLine();
        }
    }
}
