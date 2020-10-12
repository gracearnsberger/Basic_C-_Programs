using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //prints the current date and time to the console
            Console.WriteLine(DateTime.Now);

            //asks the user for a number
            Console.WriteLine("Please enter a number: ");
            double userNumber = Convert.ToDouble(Console.ReadLine());

            //prints to the console the exact time it will be in X hours, X being the number the user above
            Console.WriteLine("You've entered " + userNumber + " hours. " + "The time will now be " +
                DateTime.Now.AddHours(userNumber));

            Console.ReadLine();
        }
    }
}
