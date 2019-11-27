using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperatorsStep67
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program: ");

            Console.WriteLine("Person 1:");
            int hourlyRatePerson1;
            Console.WriteLine("Input hourly rate: ");
            hourlyRatePerson1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Hourly Rate: " + hourlyRatePerson1);
            Console.WriteLine("Hours worked per week: " + 40);
            Console.ReadLine();

            Console.WriteLine("Person 2:");
            int hourlyRatePerson2;
            Console.WriteLine("Input hourly rate: ");
            hourlyRatePerson2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Hourly Rate: " + hourlyRatePerson2);
            Console.WriteLine("Hours worked per week: " + 40);
            Console.ReadLine();

            Console.WriteLine("Weekly salary of Person 1: " + hourlyRatePerson1 * 40);
            Console.WriteLine("Weekly salary of Person 2: " + hourlyRatePerson2 * 40);

            bool TrueOrFalse = hourlyRatePerson1 > hourlyRatePerson2;
            Console.WriteLine("Does Person 1 make more money than Person 2?" + TrueOrFalse.ToString());

            Console.ReadLine();











        }
    }
}
