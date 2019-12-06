using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrillStep131
{
    class Employee<T> : Person, IQuittable
    {
        public List<T> Things;

        public void Quit()
        { 
        
        }
    }
}
