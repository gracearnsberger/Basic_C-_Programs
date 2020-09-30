using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //inside the Main() method, instantiate an Employee object with firstName "Sample" and lastName "Student". 
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student" };

            //call the SayName() method on the object.
            employee.SayName();
            Console.ReadLine();
        }
    }
}
