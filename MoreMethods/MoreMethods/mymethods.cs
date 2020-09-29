using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreMethods
{
    public class MyMethods
    {
        //in a class, create a method that will take in an integer
        public int OperationOne(int int1)
        {
            int int2 = 6;
            var Total = int1 * int2;
            return Total;
        }
        //second method with the same name that will take in a decimal, create a different math operation for it
        public int OperationOne(decimal int1)
        {
            decimal int2 = 0.05m;
            var Answer = Convert.ToInt32(int1 - int2);
            return Answer;
        }
        //third method to the class, with the same name, that will take in a string & do a different math operation to it.
        public int OperationOne(string string1)
        {
            int int3 = 4;
            int int4 = Convert.ToInt32(string1);
            int number = int4 + int3;
            return number;
        }
    }
}
