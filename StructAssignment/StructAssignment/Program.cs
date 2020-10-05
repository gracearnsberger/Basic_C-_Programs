using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //in the Main() method, create an object of data type Number and assign an amount to it.
            Number myNumber = new Number();
            myNumber.Amount = 52.26m;

            //print this amount to the console.
            Console.WriteLine(myNumber.Amount);
            Console.ReadLine();
        }
    }
}
