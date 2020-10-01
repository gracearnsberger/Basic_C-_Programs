using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt the user to enter the current day of the week
            Console.WriteLine("Please enter the current day of the week: :)");
            string myString = Console.ReadLine();

            //assign the value to a variable of that enum data type you just created
            DaysOfTheWeek Day;

            //wrap the above statement in a try/catch block and have it print 
            //"Please enter an actual day of the week." to the console if an error occurs.
            try
            {
                Day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), myString);
                Console.WriteLine("Today it is: " + Day);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            Console.ReadLine();
        }

        //create an enum for the days of the week
        public enum DaysOfTheWeek
        {
            Monday, 
            Tuesday, 
            Wednesday, 
            Thursday, 
            Friday, 
            Saturday, 
            Sunday
        }
    }
}
