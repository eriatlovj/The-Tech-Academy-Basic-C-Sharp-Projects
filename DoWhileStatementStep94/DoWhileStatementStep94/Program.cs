using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileStatementStep94
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Counting from 10 to 100...");
            int num = 10;
            Console.ReadLine();
            do

            {
                Console.WriteLine("Value of num: " + num);
                num++;
            }

            while (num <= 100);
            Console.ReadLine();
        }
    }
}
