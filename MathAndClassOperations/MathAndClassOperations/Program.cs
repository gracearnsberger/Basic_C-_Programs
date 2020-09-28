using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndClassOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask the user what number they want to do the math operations on.
            Console.WriteLine("Please enter a number(#) of your choice. :) ");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = 2;
            int Total;
            Methods myFunction = new Methods();

            //call each method in turn, passing the user input to the method. 
            //and display the returned integer to the screen

            Total = myFunction.division(x, y);
            Console.WriteLine("The total of " + x + " divided by " + y + " equals " + Total);
            Total = myFunction.multiplication(x, y);
            Console.WriteLine("The total of " + x + " multiplied by " + y + " equals " + Total);
            Total = myFunction.addition(x, y);
            Console.WriteLine("The total of " + x + " added to " + y + " equals " + Total);
            Console.WriteLine("Thanks for using my calculator!");
            Console.ReadLine();


            
        }
    }
}
