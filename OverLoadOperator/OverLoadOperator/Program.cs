using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoadOperator
{
    //overload the "==" operator so it checks if two Employee objects are equal by comparing their Id property.
    class Program : Employee
    {
        static void Main(string[] args)
        {
            Employee employeeOne = new Employee() { Id = 1, Name = "Joe" };
            Employee employeeTwo = new Employee() { Id = 1, Name = "Michael" };

            bool sameId = employeeOne == employeeTwo;

            Console.WriteLine("Do " + employeeOne.Name + " and " + employeeTwo.Name + "'s Id's match? " + sameId);
            Console.ReadLine();
        }
    }
}
