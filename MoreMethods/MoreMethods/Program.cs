using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate the class and call the one method, passing in an integer. Display the result to the screen.
            int x = 2;
            int Total;
            MyMethods intFunction = new MyMethods();
            Total = intFunction.OperationOne(x);
            Console.WriteLine("6 times 2 is: ");
            Console.WriteLine(Total);

            //instantiate the class and call the second method, passing in a decimal. Display the result to the screen.
            decimal y = 23.25m;
            int Answer;
            MyMethods decimalFunction = new MyMethods();
            Answer = decimalFunction.OperationOne(y);
            Console.WriteLine("23.25 minus 0.05 is: ");
            Console.WriteLine(Answer);

            //instantiate the class and call the third method, passing in a string that equates to an integer. Display the result to the screen.
            string z;
            int number;
            MyMethods stringFunction = new MyMethods();
            Console.WriteLine("Enter a number");
            z = Console.ReadLine();
            Console.WriteLine(z + " plus 4 is: ");
            number = stringFunction.OperationOne(z);
            Console.WriteLine(number);

            Console.ReadLine();
        }
    }
}
