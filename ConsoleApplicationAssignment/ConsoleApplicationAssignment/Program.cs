using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //multiply entered number by 50 & dislay result to console
            Console.WriteLine("Enter a number and I will mutiply it by 50.");
            int numOriginal = Convert.ToInt32(Console.ReadLine());
            int numFifty = numOriginal * 50;
            Console.WriteLine("Your number times 50 is: " + numFifty);
            Console.ReadLine();

            //add 25 to entered number & dislay result to console
            Console.WriteLine("Enter a number and I will add 25 to it.");
            int yourNum = Convert.ToInt32(Console.ReadLine());
            int numTwenty = yourNum + 25;
            Console.WriteLine("Your number plus 25 is: " + numTwenty);
            Console.ReadLine();

            //divide entered number by 12.5 & dislay result to console
            Console.WriteLine("Enter a number and I will divide it by 12.5.");
            int myNum = Convert.ToInt32(Console.ReadLine());
            double quotient = myNum / 12.5;
            Console.WriteLine("Your number divided by 12.5 is: " + quotient);
            Console.ReadLine();

            //check if entered number is > 50 & dislay true or false to console
            Console.WriteLine("Enter a number and I will see if it is greater than 50.");
            int theirNum = Convert.ToInt32(Console.ReadLine());
            bool isGreater = theirNum > 50;
            Console.WriteLine(isGreater);
            Console.ReadLine();

            //divide entered number by 7 & dislay result and remainder to console
            Console.WriteLine("Enter a number and I will divide it by 7 and display the remainder");
            int givenNum = Convert.ToInt32(Console.ReadLine());
            int remainder = givenNum % 7;
            Console.WriteLine("Your remainder divided by 7 is: " + remainder);
            Console.ReadLine();
        }   
    }
}
