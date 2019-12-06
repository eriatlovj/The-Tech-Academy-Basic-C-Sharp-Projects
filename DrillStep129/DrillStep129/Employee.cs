using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrillStep129
{
    class Employee : Person, IQuittable
    {
        public int ID;
        public int ID1;

        public static bool operator ==(Employee ID, Employee ID1)
        {
            bool isEqual = ID == ID1;
            return true;
        }
        public static bool operator !=(Employee ID, Employee ID1)
        {
            bool notEqual = ID != ID1;
            return false;
        }

        public override void sayName()
        {
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
        }

        public void Quit()
        {

        }
}
}