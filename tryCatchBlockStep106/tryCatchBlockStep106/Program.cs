using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryCatchBlockStep106
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listNumber= new List<int>();
            int[] numbers = {8, 24, 34, 23, 45};
            listNumber.AddRange(numbers);

            try
            {
                Console.WriteLine("Please type a number and it will be used to divide the numbers listed above.");
                int userNumber = Convert.ToInt32(Console.ReadLine());
                int result = 0;

                foreach (int number in listNumber)
                {
                    result = number / userNumber;
                    Console.WriteLine(result);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("That is not a number. Please try again.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Please do not use the number zero.");
            }
            catch (Exception)
            {
                Console.WriteLine("Sorry. Something went wrong.");
            }

            Console.ReadLine();
        }
    }
}
