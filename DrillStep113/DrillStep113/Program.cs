using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrillStep113
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass testClass = new TestClass();
            int parameter1 = 20;
            int parameter2 = 40;
            testClass.voidMethod(parameter1, parameter2);
            Console.ReadLine();
        }
    }
}
