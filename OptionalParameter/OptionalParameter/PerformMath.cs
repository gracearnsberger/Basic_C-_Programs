using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameter
{
    class PerformMath
    {
        //in your class, create a method that takes two integers as parameters. make one of them optional. have the method do a math operation. then display the result.
        public int MyMath(int int1, int int2 = 10)
        {
            return int1 + int2;
        }
    }
}
