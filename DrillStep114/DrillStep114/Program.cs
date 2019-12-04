using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrillStep114
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass testClass = new TestClass();

            int userInteger = 21;
            double userDecimal = 0.3125;
            string userString = "160";

            userInteger = testClass.testMethod(userInteger);

            userDecimal = testClass.testMethod(userDecimal);

            userString = testClass.testMethod(userString);

            Console.WriteLine("The values returned are: " + userInteger + ", " + userDecimal + " and " + userString);
            Console.ReadLine();

        }
    }
}
