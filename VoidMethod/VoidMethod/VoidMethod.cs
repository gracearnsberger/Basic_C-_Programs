using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    //in your class create a void method that takes two integers as parameters. 
    //have the method do a math operation on the first integer and display the second integer to the screen.
    public class VoidMethod
    {
        public void MultiplyNumber(int int1, int int2)
        {
            int Answer = int1 * int2;
            Console.WriteLine(Answer);
        }
    }
}
