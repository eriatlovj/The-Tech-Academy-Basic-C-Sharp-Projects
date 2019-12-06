using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrillStep129
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
            employee.ID = 1;

            employee.firstName1 = "Sample";
            employee.lastName1 = "Student";
            employee.ID1 = 2;
            employee.sayName();
            Console.ReadLine();

            if (employee.ID == employee.ID1)
            {
                Console.WriteLine(true);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(false);
                Console.ReadLine();
            }
        }
    }
}
