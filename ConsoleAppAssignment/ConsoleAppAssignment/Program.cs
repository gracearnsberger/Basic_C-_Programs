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
            //====================== PART ONE START ======================//
            //create a one-dimensional array of strings.
            //string[] colorArray = new string[10] { "black", "blue", "green", "yellow", "orange", "pink", "green", "brown", "teal", "purple" };

            //ask the user to input some text.
            //Console.WriteLine("Please enter some text to be added to the end of the colors: ");
            //string x = Console.ReadLine();
            //int y;

            // A loop that iterates through each string in the array and adds the user's text input to the end of each string.
            //then create a loop that prints off each string in the array on a separate line.
            //for(y = 0; y < colorArray.Length; y++)
            //{
            //    colorArray.SetValue(colorArray.GetValue(y) + x, y);
            //    Console.WriteLine(colorArray.GetValue(y));
            //}
            //Console.ReadLine();
            //====================== PART ONE END ======================//


            //====================== PART TWO START ======================//
            //create an infinite loop.
            //while (2==2)
            //{
            //    Console.WriteLine("Infinite Loop!!!!!!!!!!! :D");
            //}

            //fix the infinite loop so that it will execute properly.
            //int myNum = 15;
            //while (myNum != 4)
            //{
            //    myNum--;
            //    Console.WriteLine(myNum);
            //}
            //Console.ReadLine();
            //====================== PART TWO END ======================//


            //====================== PART THREE START ======================//
            //create a loop where the comparison to continue iterating the loop is a “<” operator.
            //int addition = 6;
            //while (addition < 30)
            //{
            //    addition = addition + 6;
            //    Console.WriteLine(addition);
            //}
            //Console.ReadLine();

            //create a loop where the comparison to continue iterating the loop is a “<=” operator.
            //int orEqual = 4;
            //while (orEqual <= 40)
            //{
            //    orEqual = orEqual + 4;
            //    Console.WriteLine(orEqual);
            //}
            //Console.ReadLine();
            //====================== PART THREE END ======================//


            //====================== PART FOUR START ======================//
            //create a list of strings where each item in the list is unique.
            //List<string> holidays = new List<string>() { "halloween", "christmas", "thanksgiving", "valentines day", "labor day", "fourth of july" };
            //bool found = false;
            //int i; 

            //ask the user to input text to search for in the list.
            //Console.WriteLine("Enter the name of a Holiday to see if it's on the list: ");
            //string inputHoliday = Console.ReadLine().ToLower();

            //add code to the loop that tells a user if they put in text that isn’t in the list.
            //while (!holidays.Contains(inputHoliday))
            //{
            //    Console.WriteLine("Sorry but the holiday you entered was not found on my list.");
            //    Console.Write("Enter the name of a holiday to see if it's on my list: ");
            //    inputHoliday = Console.ReadLine().ToLower();
            //}

            //add code to the loop that stops it from executing once a match has been found.
            //foreach (string holiday in holidays)
            //{
            //    if (holiday == inputHoliday)
            //    {
            //        Console.WriteLine("{holiday} is on my list!");
            //        break;
            //    }
            //}

            //create a loop that iterates through the list and then displays the index 
            //of the list that contains matching text on the screen.
            //for (i = 0; i < holidays.Count; i++)
            //{
            //    if (holidays[i].Contains(inputHoliday))
            //    {
            //        Console.WriteLine("{0}: {1}", i, holidays[i]);
            //        found = true;
            //    }
            //}
            //Console.ReadLine();
            //====================== PART FOUR END ======================//


            //====================== PART FIVE START ======================//
            //create a list of strings that has at least two identical strings in the list. 
            //List<string> videoGames = new List<string>() { "fortnite", "sims", "minecraft", "mortal kombat", "minecraft" };

            //ask the user to select text to search for in the list.
            //Console.WriteLine("Enter a video game to see if it's on my list and how many times it's on there: ");
            //string userGame = Console.ReadLine().ToLower();

            //add code to the loop that tells a user if they put in text that isn’t in the list.
            //while (!videoGames.Contains(userGame))
            //{
            //    Console.WriteLine($"Sorry but the game {userGame}, is not on my list.");
            //    userGame = Console.ReadLine().ToLower();
            //}

            //create a loop that iterates through the list and displays 
            //the indices of the list that contain matching text on the screen.
            //for (int i = 0; i < videoGames.Count; i++)
            //{
            //    if (videoGames[i] == userGame)
            //    {
            //        Console.WriteLine($"The game {userGame}, is on my list at the index {i}");
            //    }
            //}
            //Console.ReadLine();

            //====================== PART FIVE END ======================//



            //====================== PART SIX START ======================//
            //create a list of strings that has at least two identical strings in the list.
            //List<string> seasons = new List<string>() { "fall", "winter", "autumn", "spring", "summer" };

            //create a foreach loop that evaluates each item in the list, and displays a message 
            //showing the string and whether or not it has already appeared in the list.
            //foreach (string season in seasons)
            //{
            //    if (seasons.Contains(season))
            //    {
            //        Console.WriteLine($"{season}: Found in List ", season);
            //    }

            //    else
            //    {
            //        Console.WriteLine($"{season}: Not found in List ", season);
            //    }
            //}
            //Console.ReadLine();
            //====================== PART SIX END ======================//
        }
    }
}

