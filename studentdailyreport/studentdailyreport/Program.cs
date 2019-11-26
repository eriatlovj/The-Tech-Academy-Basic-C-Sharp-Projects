using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentdailyreport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What course are you on?");
            string whatCourseAreYouOn = Console.ReadLine();

            Console.WriteLine("What page number are you on?");
            string whatPageNumberAreYouOn = Console.ReadLine();
            int pageNum = Convert.ToInt32(whatPageNumberAreYouOn);
            int total = pageNum + 0;

            Console.WriteLine("Do you need help with anything? Please answer \"True\" or \"False\".");
            string TrueOrFalse = Console.ReadLine();

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string positiveExperience = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string studyHours = Console.ReadLine();

            int hours = Convert.ToInt32(studyHours);
            int hour = hours + 0;

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();



        }
    }
}
