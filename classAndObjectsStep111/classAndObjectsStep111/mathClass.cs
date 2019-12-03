using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classAndObjectsStep111
{
    class mathClass
    {
        public mathClass()
        {
            Value = 1;
        }

        public int MathMethod1(int userInput)
        {
            userInput = userInput + 15;

            return userInput;
        }

        public int MathMethod2(int userInput)
        {
            userInput = userInput * 4;

            return userInput;
        }

        public int MathMethod3(int userInput)
        {
            userInput = userInput - 8;

            return userInput;
        }
        public int Value { get; set; }
    }
}
