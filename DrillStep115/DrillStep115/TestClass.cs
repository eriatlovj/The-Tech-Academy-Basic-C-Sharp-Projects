using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrillStep115
{
    class TestClass
    {
        public void TestMethod(int number1, int number2 = 20)
        {
            int result = number1 + number2;
            Console.WriteLine(result);
        }
    }
}
