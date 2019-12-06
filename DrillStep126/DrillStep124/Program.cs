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

            IQuittable Quit = new Employee();
            Quit.Quit();
            Employee employee = new Employee();

            employee.firstName = "Sample";
            employee.lastName = "Student";
            employee.sayName();
            Console.ReadLine();
        }
    }
}
