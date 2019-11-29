using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingDrillStep92
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight: ");
            int PackageWeight = Convert.ToInt32(Console.ReadLine());

            if (PackageWeight >= 51)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.");
                Console.ReadLine();
                return;
            }

            Console.ReadLine();
            Console.WriteLine("Please enter the package width: ");
            int PackageWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package height: ");
            int PackageHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package length: ");
            int PackageLength = Convert.ToInt32(Console.ReadLine());

            int total = PackageHeight + PackageWidth + PackageLength;
            if (total >= 51)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                return;
            }

            else

            {
                Console.WriteLine();
            }

            Console.ReadLine();
            int ShippingTotal1 = total * PackageWeight;
            int ShippingTotal2 = ShippingTotal1 % 100;
            {
                Console.WriteLine("Your estimated total for shipping this package is: $" + ShippingTotal2);
            }

            Console.WriteLine("Thank you.");
            Console.ReadLine();
        }
    }
}
