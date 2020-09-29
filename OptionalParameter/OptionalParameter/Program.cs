using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate the class.
            PerformMath operation = new PerformMath();

            //ask the user to input two numbers, one at a time. let them know they need not enter anything for the second number.
            Console.WriteLine("Enter a number. You may enter a second number " +
                "if you would like or you may leave the second space blank.");

            //call the method in the class, passing in the one or two numbers entered.
            int int1 = Convert.ToInt32(Console.ReadLine());
            string input = Console.ReadLine();
            int int2;

            if (input == "")
            {
                int int3 = operation.MyMath(int1);
                Console.WriteLine("Here is your final number after the math operations were performed: " + int3);
            }
            else
            {
                int2 = Convert.ToInt32(input);
                int int3 = operation.MyMath(int1, int2);
                Console.WriteLine("Here is your final number after the math operations were performed: " + int3);
            }
            Console.ReadLine();
        }
    }
}
