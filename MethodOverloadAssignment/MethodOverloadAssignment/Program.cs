using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadAssignment
{
    //declare a class to be static.
    static class Program
    {
        static void Main(string[] args)
        {
            //in the Main() method, instantiate that class.
            DivisionClass divi = new DivisionClass();

            // Have the user enter a number.
            Console.WriteLine("Please enter a number to be divided by 2: ");
            int intU = Int32.Parse(Console.ReadLine());

            //call the method on that number & display the output to the screen.
            divi.divide(intU, out int Total);
            Total = intU / 2;
            Console.WriteLine(Total);
            Console.ReadLine();

            Subtract(8, 3);
        }

        //overload a method 
        public static void Subtract(int num1, int num2)
        {
            Console.WriteLine("Sum = {0}", num1 - num2);
        }
        public static void Subtract(int num1, int num2, int num3)
        {
            Console.WriteLine("Sum = {0}", num1 - num3);
        }
        public static void Subtract(int num1, int num2, int num3, int num4)
        {
            Console.WriteLine("Sum = {0}", num1 - num4);
        }

    }
}
