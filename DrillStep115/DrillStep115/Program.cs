using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrillStep115
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass Example = new TestClass();
            Console.WriteLine("Please type a whole number.");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please type in a new whole number or you may just leave it blank.");
            string number2 = Console.ReadLine();
            if (number2 == "")
            {
                Example.TestMethod(number1);
            }
            else 
            {
                int int2 = Convert.ToInt32(number2);
                Example.TestMethod(number1, int2);
            }
            Console.ReadLine();
        }
    }
}
