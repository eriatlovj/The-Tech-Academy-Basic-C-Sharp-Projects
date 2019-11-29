using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileStatementStep94
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Count from 10 to 100: ");
            int i = 10;
            while (i <= 100)
            {
                Console.WriteLine("Count: "+ i);
                i++;
                Console.ReadLine();
            }
        }
    }
}
