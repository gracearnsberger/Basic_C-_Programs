using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignmentFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            //define array 
            //string[] sodas = { "Fanta", "Coke", "Sprite", "Root Beer" };
            //Console.WriteLine("Enter an index number to choose your soda: ");
            //int input = Convert.ToInt32(Console.ReadLine());

            ////if statement for if the index is out of range
            //if (input>sodas.Length)
            //{
            //    Console.WriteLine("Please choose a number inside of the array such as 1-4.");
            //    Console.ReadLine();
            //}

            //Console.WriteLine("The soda at index number: " + input + " is " + sodas[input]);
            //Console.ReadLine();

            //define int array
            //int[] intArray = { 30, 22, 12, 100 };
            //Console.WriteLine("Pick an index number to get your number.");
            //int input2 = Convert.ToInt32(Console.ReadLine());

            ////if statement for if the index is out of range
            //if (input2>intArray.Length)
            //{
            //    Console.WriteLine("You have chosen an index number out of range. Choose 1-4.");
            //    Console.ReadLine();
            //}

            //Console.WriteLine("The integer at index number" + input2 + " is " + intArray[input2]);
            //Console.ReadLine();

            //create list of strings
            List<string> stringList = new List<string>() { "Denver", "Colorado Springs", "Aspen" };
            Console.WriteLine("Enter an index number to get your Colorado city.");
            int input3 = Convert.ToInt32(Console.ReadLine());

            //if statement for if the index is out of range
            if (input3 > stringList.Count)
            {
                Console.WriteLine("You have picked a number that is out range. Pick a number 1-3.");
                Console.ReadLine();
            }
            Console.WriteLine("The city at index number is: " + input3 + " is " + stringList[input3]);
            Console.ReadLine();
        }
    }
    }
}
