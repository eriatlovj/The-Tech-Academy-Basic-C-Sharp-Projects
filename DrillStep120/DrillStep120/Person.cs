using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrillStep120
{
    public class Person
    {

        public List<string> Employee { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        public void sayName()
            {
            Console.WriteLine("Name: {0} {1}", firstName, lastName);
        }  
    }
}
