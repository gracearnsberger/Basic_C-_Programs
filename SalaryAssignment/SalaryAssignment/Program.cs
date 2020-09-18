using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Display The title
            Console.WriteLine("Anonymous Income Comparison Program");

            //Retrieve person 1's hourly rate & hours worked per week
            Console.WriteLine("Person 1:");
            Console.WriteLine("Hourly rate?");
            int hourRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int hoursWeek = Convert.ToInt32(Console.ReadLine());
            

            //Retrieve person 2's hourly rate & hours worked per week
            Console.WriteLine("Person 2:");
            Console.WriteLine("Hourly rate?");
            int hourRate2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int hoursWeek2 = Convert.ToInt32(Console.ReadLine());

            //Display the annual salary of person 1 to the console
            Console.WriteLine("Annual salary of Person 1:");
            int salary = hourRate * 52 * hoursWeek;
            Console.WriteLine(salary);
            Console.ReadLine();

            //Display the annual salary of person 2 to the console
            Console.WriteLine("Annual salary of Person 2:");
            int salary2 = hourRate2 * 52 * hoursWeek2;
            Console.WriteLine(salary2);
            Console.ReadLine();

            //Check if person 1 makes more salary than person 2 & display true or false to the console
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool higherSalary = salary > salary2;
            Console.WriteLine(higherSalary);
            Console.ReadLine();



        }
    }
}
