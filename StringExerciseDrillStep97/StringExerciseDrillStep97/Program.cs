using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExerciseDrillStep97
{
    class Program
    {
        static void Main(string[] args)
        {
            string UserName = "Egg man";
            string UserName2 = "Walrus";
            UserName = UserName.ToUpper();
            UserName2 = UserName2.ToUpper();
            string dateString = DateTime.Today.ToShortDateString();
            string str = "Hello " + UserName + ". " + "Hi " + UserName2 + ". Today is " + dateString + ". " + "It's almost the end of the month.";
            Console.WriteLine(str);

            StringBuilder sb = new StringBuilder();
            sb.Append("I am the egg man.");
            sb.AppendLine(" They are the egg men.");
            sb.AppendLine("I am the walrus.");
            sb.AppendLine("Goo goo g'joob.");
            Console.WriteLine(sb);

            Console.ReadLine();

        }
    }
}
