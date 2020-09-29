using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate and initialize an Employee object with a first name of "Sample" and a last name of "Student".
            Employee firstEmployee = new Employee() { FirstName = "Sample", LastName = "Student" };
            //call the superclass method SayName() on the Employee object.
            firstEmployee.SayName();
            Console.ReadLine();
        }
    }
}
