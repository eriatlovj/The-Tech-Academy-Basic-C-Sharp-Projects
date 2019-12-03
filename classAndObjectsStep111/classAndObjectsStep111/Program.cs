using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classAndObjectsStep111
{
    class Program
    {
        static void Main(string[] args)
        {
            mathClass math1 = new mathClass();

            Console.WriteLine("Please provide a number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            userInput = math1.MathMethod1(userInput);

            Console.WriteLine("Running Math Method 1 to add 15, your number becomes " + userInput);
            Console.ReadLine();
            userInput = math1.MathMethod2(userInput);
            Console.WriteLine("Running Math Method 2 to multiply by 4, your number becomes " + userInput);
            Console.ReadLine();
            userInput = math1.MathMethod3(userInput);
            Console.WriteLine("Running Math Method 3 to subtract by 8, your number approximately becomes " + userInput);
            Console.ReadLine();

        }
    }
}
