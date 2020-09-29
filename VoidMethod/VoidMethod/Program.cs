using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //call the method in the class, passing in two numbers.
            VoidMethod calc = new VoidMethod();
            calc.num(2, 4);
            Console.ReadLine();
        }
    }
}
