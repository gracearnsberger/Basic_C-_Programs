using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReportProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Display The titles
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            //Ask for their name & display name
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Your name is: " + yourName);

            //Ask for their course & display the course
            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();
            Console.WriteLine("You're on Course: " + yourCourse);

            //Ask for their page number & display the number
            Console.WriteLine("What page number are you on?");
            string pageNumber = Console.ReadLine();
            int pgNum = Convert.ToInt32(pageNumber);
            Console.WriteLine("Your page number is: " + pageNumber);

            //Ask if they need help & display true or false value
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string courseHelp = Console.ReadLine();
            Console.WriteLine("You answered: " + courseHelp);

            //Ask about positive experiences & display back value
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string positiveExperiences = Console.ReadLine();
            Console.WriteLine("You answered: " + positiveExperiences);

            //Ask about feedback & display back value
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string otherFeedback = Console.ReadLine();
            Console.WriteLine("You answered: " + otherFeedback);

            //Ask how many hours they studied & display the number
            Console.WriteLine("How many hours did you study today?");
            string hoursWorked = Console.ReadLine();
            int courseTime = Convert.ToInt32(hoursWorked);
            Console.WriteLine("You studied this many hours: " + hoursWorked);

            //End of Program Message
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");

            Console.ReadLine();
        }
    }
}
