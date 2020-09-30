using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadAssignment
{
    //creat a class & a void method that outputs an integer. 
    class DivisionClass
    {
        //have the method divide the data passed to it by 2.
        //create a method with output parameters.
        public void Divide(int int1, out int Total)
        {
            int int2 = 2;
            Total = int1 / int2;
        }
    }
}
