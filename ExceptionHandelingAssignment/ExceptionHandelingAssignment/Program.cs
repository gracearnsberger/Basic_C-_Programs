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
            int age = 0;
            bool isValid = false;
            while (!isValid)
            {
                //exceptions must be handled using “try/catch.”
                try
                {
                    Console.WriteLine("Hello! Please enter your age: ");
                    age = Convert.ToInt32(Console.ReadLine());

                    if (age == 0)
                    {
                        throw new ZeroException();
                    }
                    else if (age < 0)
                    {
                        throw new NegativeException();
                    }
                    isValid = true;
                }

                //display a general message if an exception was caused by anything else
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a whole number");
                }
                catch (NegativeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (ZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Please enter a reasonable number.");
                    Console.WriteLine(ex.Message);
                }

            }
            //display the year the user was born
            int difference = (2020 - age);
            Console.WriteLine("You were born in the year " + difference);

            Console.ReadLine();

        }
    }
}