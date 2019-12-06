using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrillStep131
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> ThingsString = new Employee<string>();
            ThingsString.Things = new List<string>();
            ThingsString.Things.Add("Thing one");
            ThingsString.Things.Add("Thing two");
            ThingsString.Things.Add("Thing three");

            Employee<int> IntThings = new Employee<int>();
            IntThings.Things = new List<int>();
            IntThings.Things.Add(3);
            IntThings.Things.Add(2);
            IntThings.Things.Add(1);

            foreach (string Item1 in ThingsString.Things)
            {
                Console.WriteLine(Item1);
                Console.ReadLine();
            }

            foreach (int Item2 in IntThings.Things)
            {
                Console.WriteLine(Item2);
                Console.ReadLine();
            }

        }
    }
}
