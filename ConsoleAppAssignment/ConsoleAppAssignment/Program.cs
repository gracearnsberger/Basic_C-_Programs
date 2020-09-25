using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //array of strings
            //Console.WriteLine("Array");
            //string[] candies = { "twix", "smarties", "m&m's", "gummy bears", "jelly beans", "swedish fish", "hershey's bar", "kit kat", "crunch bar", "mints" };

            ////ask for user input
            //Console.WriteLine("Enter some text to be added to the end of candies.");
            //string inputText = Console.ReadLine();

            //loop that iterates through each string in the array and adds the user's text input to the end of each string 
            //then prints off each string in the array on a separate line.
            //for (int i=0; i < candies.Length; i++)
            //{
            //    candies[i] = candies[i] + inputText;
            //}
            //foreach (string c in candies)
            //{
            //    Console.WriteLine(c);
            //}

            //Console.Read();


            //infinite loops
            //Console.WriteLine("Loops");
            //bool add = false;
            //int loopCount = 0;
            //using < and <= operators in loops
            //while (!add)
            //{
            //    if (loopCount < int.MaxValue / 100000000)
            //    {
            //        loopCount++;
            //        Console.WriteLine("This infinite loop is on loop number: " + loopCount);
            //    }
            //    else
            //    {
            //        add = true;
            //        Console.WriteLine("Applied fix. Infinite loop stopped at {0} loops", loopCount);
            //    }

            //}
            //add = false;
            //loopCount = 0;
            //while (!add)
            //{
            //    if (loopCount <= int.MaxValue / 100000000)
            //    {
            //        loopCount++;
            //        Console.WriteLine("This infinite loop is on loop number: " + loopCount);
            //    }
            //    else
            //    {
            //        add = true;
            //        Console.WriteLine("Applied fix.Infinite loop stopped at {0}loops", loopCount);
            //    }
            //}
            //Console.Read();

            //create unique strings list
            Console.WriteLine("colors list");
            List<string> colors = new List<string>() { "Pink", "Blue", "Orange", "Green", "Blue", "Yellow", "Black", "White", "Black", "Purple" };
            Console.WriteLine("Colors:");
            Console.WriteLine("Choose a color for indicies.");
            foreach (string c in colors)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine();
            //ask the user to input text to search for in the list & print index
            Console.WriteLine("Enter the name of your color");
            Console.WriteLine();
            string mColor = Console.ReadLine();

            int yNum = 0;
            bool yColor = false;
            List<int> yIndex = new List<int>();

            Console.WriteLine();

            foreach (string c in colors)
            {
                if (c.Equals(mColor))
                {
                    yIndex.Add(yNum);
                    yColor = true;
                }
                yNum++;
            }
            Console.ReadLine();

            //list of strings with two identical words
            //Console.WriteLine("List of pets");
            //List<string> pets = new List<string>() { "cat", "dog", "fish", "lizard", "bird", "dog", "chicken", "spider", "snake", "hamster" };
            //List<string> samePets = new List<string>();
            //StringBuilder indicies = new StringBuilder();
            ////iterates through the list and then displays the indices of the list that contain matching text on the screen.
            //StringBuilder petsDisplay = new StringBuilder("[");
            //foreach (string p in pets)
            //{
            //    petsDisplay.Append(" " + p + ",");
            //    if (samePets.Exists(x => x == p))
            //    {
            //        Console.WriteLine(p + " has already appeared in the list");
            //    }
            //    else
            //    {
            //        samePets.Add(p);
            //        Console.WriteLine(p + " has not appeared on the list before");
            //    }
            //}
            //petsDisplay.Length = (petsDisplay.Length - 1);
            //petsDisplay.Append("]");
            //Console.WriteLine("Pets List" + petsDisplay);
            //Console.Read();
        }
    }
}
