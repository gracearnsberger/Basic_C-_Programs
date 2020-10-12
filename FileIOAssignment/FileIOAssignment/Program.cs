using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIOAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //styling for the console :)
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.DarkGreen;

            //asks the user for a number
            Console.WriteLine("Please enter a number: ");
            string num = string.Format(Console.ReadLine());

            //log that number to a text file
            File.WriteAllText(@"C:\G\numberlog.txt", num);

            //prints the text file back to the user
            string display = File.ReadAllText(@"C:\G\numberlog.txt");
            Console.WriteLine(display);

            Console.ReadLine();
        }
    }
}
