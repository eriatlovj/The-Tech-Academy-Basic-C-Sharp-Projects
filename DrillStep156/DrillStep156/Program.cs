using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrillStep156
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentTime = DateTime.Now;
            Console.WriteLine("Current time is: " + currentTime);
            Console.WriteLine("Provide a number equivalent to a number of hours to be added to the current time.");
            int additionalHours = Convert.ToInt32(Console.ReadLine());

            DateTime addedToCurrentTime = currentTime.AddHours(additionalHours);
            Console.WriteLine("The updated time is: " + addedToCurrentTime);

            Console.ReadLine();
        }
    }
}
