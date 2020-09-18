using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuoteAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Display the title
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            //Retrieve package weight & if it is > 50, end the program
            Console.WriteLine("Hello! Please enter the weight of your package:");
            int pkgWeight = Convert.ToInt32(Console.ReadLine());
            if (pkgWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else if (pkgWeight < 50)
            {
                //Retrieve package width, height, and length
                Console.WriteLine("What is the width of your package?");
                int pkgWidth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the height of your package?");
                int pkgHeight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the length of your package?");
                int pkgLength = Convert.ToInt32(Console.ReadLine());
                int dimensionsTotal = pkgWidth + pkgHeight + pkgLength;
                int preQuote = pkgWidth * pkgHeight * pkgLength;
                int finalQuote = (preQuote * pkgWeight) / 100;
                if (dimensionsTotal > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else if (dimensionsTotal <= 50)
                {
                    Console.WriteLine("Your estimated total for shipping this package is: " + finalQuote + "Thank you!");
                }
            }
            Console.ReadLine();
        }
    }
}
