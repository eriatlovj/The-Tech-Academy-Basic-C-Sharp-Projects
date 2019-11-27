using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicStep75
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age? ");
            int x;

            x = Convert.ToInt32(Console.ReadLine());
            bool TrueOrFalse = x >= 15;

            string DUI = null;
            Console.WriteLine("Have you ever had a DUI?");
            DUI = Console.ReadLine();
            if (DUI == "no")
            {
                Console.WriteLine("False");
            }
            else if (DUI == "yes")
            {
                Console.WriteLine("");
            }

            Console.WriteLine("How many speeding tickets do you have? ");
            int y;

            y = Convert.ToInt32(Console.ReadLine());
            bool YesOrNo = y <= 3;

            Console.ReadLine();

            if (x >= 15)
                if (DUI == "no")
                    if (y <= 3)
                    {
                        Console.WriteLine("Applicant is qualified.");
                    }

                    else if (y >= 3)
                    {
                        Console.WriteLine("Applicant is not qualified.");
                    }

                    else if (DUI == "yes")
                    {
                        Console.WriteLine("Applicant is not qualified.");
                    }

            if (x < 15)
            {
                Console.WriteLine("Applicant is not qualified.");
            }

            Console.ReadLine();

        }
    }
}
