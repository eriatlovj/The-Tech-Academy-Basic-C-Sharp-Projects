﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrillStep124
{
    class Employee : Person, IQuittable
    {
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
