using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstantsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a const variable
            const string myString = " my project!";
            Person person = new Person("Grace");

            //create a variable using the keyword "var"
            var myGreeting = "Welcome to " + myString;
            Console.WriteLine(myGreeting);
            Console.WriteLine("{0}, your magic ID # is {1}", person.myName, person.myID);
            Console.ReadLine();

        }
    }
  
}
