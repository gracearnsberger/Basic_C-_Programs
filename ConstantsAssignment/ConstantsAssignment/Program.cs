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
            const string myName = "Grace";
            Person person = new Person("Grace");
            //create a variable using the keyword "var"
            var myBirthday = "January 22nd";
            Console.WriteLine("My name is " + myName +  ". My birthday is " + myBirthday);
            Console.ReadLine();

        }
    }
    //chain two constructors together
    public class Person
    {
        public Person(string name) : this(name, 100)
        {

        }
        public Person(string name, int age)
        {
            age = age;
            name = name;
        }
    }
}
