
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrillStep154
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type in any number that you desire.");
            int textLog = Convert.ToInt32(Console.ReadLine());
            File.WriteAllText("C:\\Users\\Camille\\source\\repos\\log.txt", Convert.ToString(textLog));
            File.ReadAllText("C:\\Users\\Camille\\source\\repos\\log.txt");
            using (StreamReader file = File.OpenText("C:\\Users\\Camille\\source\\repos\\log.txt"))
            {
                Console.WriteLine("Your desired number, " + file.ReadLine() + ", has been logged in to the text file.");
            }
            Console.ReadLine();
        }
    }
}