using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAssignment
{
    class Program
    {
        static void Main()
        {
            //instantiate an Employee object with type "string" as its generic parameter. //added dynamic method
            //assign a list of strings as the property value of Things.
            Employee<dynamic> employee1 = new Employee<dynamic>();
            employee1.things = new List<dynamic>() { "My", "name", "is", "gracie", "arnsberger" };


            //instantiate an Employee object with type "int" as its generic parameter. 
            //assign a list of integers as the property value of Things.
            Employee<dynamic> employee2 = new Employee<dynamic>();
            employee2.things = new List<dynamic>() { 24, 56, 36, 86, 46};


            //create a loop that prints all of the Things to the Console.
            var Staff = new List<List<dynamic>>();
            Staff.Add(employee1.things);
            Staff.Add(employee2.things);

            foreach (List<dynamic> emp in Staff)
            {
                foreach(dynamic x in emp)
                {
                    Console.WriteLine(x);
                }
            }
            Console.ReadLine();
        }
    }
}
