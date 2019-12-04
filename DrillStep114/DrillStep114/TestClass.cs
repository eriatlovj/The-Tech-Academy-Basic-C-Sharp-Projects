using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrillStep114
{
    class TestClass
    {
        public int testMethod(int userInteger)
        {
            userInteger = userInteger + 10;
            return userInteger;
        }

        public double testMethod(double userDecimal)
        {
            userDecimal = userDecimal * 4;
            return userDecimal;
        }
        public string testMethod(string userString)
        {
            int temp = Convert.ToInt32(userString);
            temp = temp / 2;

            userString = Convert.ToString(temp);

            return userString;
        }


    }
}
