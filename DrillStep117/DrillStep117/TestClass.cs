using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrillStep117
{
    class TestClass
    {
        public static void MathMethod(int j, out int result)
        {
            result = j / 2;
        }

        public static void MathMethod(int i, int k, int l, out int sum)
        {
            sum = i + k + l; 
        }

        public static void Addition(out int m)
        {
            m = 20;
            m += m;
            Console.WriteLine("Here is the output method: " + m);
        }

    }
}
