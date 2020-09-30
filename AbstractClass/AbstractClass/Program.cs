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
            //Employee employee = new Employee() { firstName = "Sample", lastName = "Student" };

            //call the SayName() method on the object.
            //employee.SayName();

            //use polymorphism to create an object of type IQuittable and call the Quit() method on it.
            IQuittable newEmployee = new Employee();
            newEmployee.Quit();
            Console.ReadLine();
        }
    }
}
