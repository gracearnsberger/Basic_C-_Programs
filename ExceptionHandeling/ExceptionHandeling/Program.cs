using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandeling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Create a list of integers.
                List<int> nums = new List<int>() { 45, 86, 95, 34, 12, 76, 81 };
                string answer;
                int num;

                //Ask the user for a number to divide each number in the list by.
                Console.WriteLine("Here is my list of numbers.");
                nums.ForEach(Console.WriteLine);
                Console.WriteLine("Please select a number to divide each number in the list by.");
                int chosenNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing the integers in the list by: " + chosenNumber);

                    //loop that takes each integer in the list, divides it by the number the user entered, and displays the result to the screen.
                    for (int x = 0; x < nums.Count; x++)
                    {
                        num = nums[x];
                        answer = Convert.ToString(num / chosenNumber);
                        Console.WriteLine(nums[x] + " divided by: " + chosenNumber + "equals: " + answer);
                    }
            }
            //proper error messages 
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number");
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                
            }
            //finish try/catch message
            Console.WriteLine("The program has finished the try/catch block.");
            Console.ReadLine();
        }
    }
}
