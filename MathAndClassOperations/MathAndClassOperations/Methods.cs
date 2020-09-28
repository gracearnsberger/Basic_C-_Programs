using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndClassOperations
{
    public class Methods
    {
        //create 3 methods, which will take one integer parameter in and return an integer
        //method 1, division
        public int division(int int1, int int2)
        {
            var Total = int1 / int2;
            return Total;
        }
        //method 2, multiplication
        public int multiplication(int int1, int int2)
        {
            var Total = int1 * int2;
            return Total;
        }
        //method 3, addition
        public int addition(int int1, int int2)
        {
            var Total = int1 + int2;
            return Total;
        }
    }
}
