using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrillStep117
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in an integer to be divided by 2.");
            int i = Convert.ToInt32(Console.ReadLine());

            TestClass.MathMethod(i, out int j);
            Console.WriteLine("Your Integer divided by 2 is equals to: " + j);
            Console.ReadLine();

            Console.WriteLine("Type in two more integers.");
            int k = Convert.ToInt32(Console.ReadLine());
            int l = Convert.ToInt32(Console.ReadLine());
            TestClass.MathMethod(i,k,l, out int sum);
            Console.WriteLine("The sum of all numbers are: " + sum);
            Console.ReadLine();

            TestClass.Addition(out int m);
            Console.ReadLine();
        }
    }
}
