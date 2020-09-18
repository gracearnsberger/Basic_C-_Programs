using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarQualificationApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask for their age 
            Console.WriteLine("What is your age?");
            int yourAge = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            //Ask if they've gotten a DUI 
            Console.WriteLine("Have you ever had a DUI ?");
            bool anyDUI = Convert.ToBoolean(Console.ReadLine());
            Console.ReadLine();

            //Ask how many speeding tickets
            Console.WriteLine("How many speeding tickets do you have?");
            int anyTickets = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            //check if they qualify
            bool qualify = (yourAge >= 15 && !anyDUI && anyTickets <= 3);
            Console.WriteLine("Qualified?");
            Console.WriteLine(qualify);
            Console.Read();
        }
    }
}
