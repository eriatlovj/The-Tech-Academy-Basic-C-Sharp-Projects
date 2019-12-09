using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DrillStep165
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter you age");
                bool validAnswer = false;
                int age = 0;

                while (validAnswer == false)
                {
                    validAnswer = int.TryParse(Console.ReadLine(), out age);
                    if (!validAnswer) Console.WriteLine("Enter your age. Please use a whole number.");
                }
                if (age < 0)
                {
                    throw new FormatException();
                }
                if (age == 0)
                {
                    throw new NullReferenceException();
                }

                DateTime currentTime = DateTime.Now;
                int currentYear = currentTime.Year;
                int birthYear = currentYear - age;


                Console.WriteLine("You were probably born in the year " + birthYear + " or maybe on " + (birthYear - 1) + " if you haven't had your birthday yet this year.");
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("You typed in a negative number. This is not a valid age. Please try again.");
                Console.ReadLine();
                return;

            }
            catch (Exception)
            {
                Console.WriteLine("Don't be embarassed. Please enter your real age.");
                Console.ReadLine();
                return;
            }
        }
    }
}
