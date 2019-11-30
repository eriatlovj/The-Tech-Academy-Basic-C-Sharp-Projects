using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayStringsStep100
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Select an index from 0 to 4. \nThen, the console will display the equivalent value of that index.");
                string[] stringArray = { "cat", "dog", "mouse", "fish", "turtle" };
                int string1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The value of that index is: " + stringArray[string1]);
                Console.ReadLine();

                Console.WriteLine("Select an index from 0 to 4. \nThen, the console will display the equivalent value of that index.");
                int[] numArray = { 5, 21, 19, 86, 12 };
                int input = int.Parse(Console.ReadLine());
                Console.WriteLine("The value of that index is: " + numArray[input]);
                Console.ReadLine();

                Console.WriteLine("Select an index from 0 to 3. \nThen, the console will display the equivalent value of that index.");
                List<string> list1 = new List<string>() { "John", "Paul", "George", "Ringo" };
                int list2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The value of that index is: " + list1[list2]);
                Console.ReadLine();

            }

            catch (System.IndexOutOfRangeException)

            {
                Console.WriteLine("Selected index does not exist.");
            }

            Console.ReadLine();

        }
    }
}
