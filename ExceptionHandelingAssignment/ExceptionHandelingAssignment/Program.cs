using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandelingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask the user for their age
            Console.WriteLine("Hello! Please enter your age: ");
            int age = int.Parse(Console.ReadLine());

            //exceptions must be handled using “try/catch.”
            try
            {
                //display appropriate error messages if the user enters zero or negative numbers
                if (age <= 0) Console.WriteLine("Please pick a number greater than 0.");
            }
            catch(FormatException ex)
            {
                //display a general message if an exception was caused by anything else
               Console.WriteLine(ex.Message);
            }

            //display the year the user was born
            int difference = (2020 - age);
            Console.WriteLine("You were born in the year " + difference);

            Console.ReadLine();
        }
    }
}
