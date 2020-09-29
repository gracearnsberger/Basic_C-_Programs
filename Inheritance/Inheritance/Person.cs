using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //create a class called Person 
    public class Person
    {
        //give it two properties each of data type string.
        //one called FirstName, the other LastName.
        public string FirstName;
        public string LastName;

        //give the class a void method called SayName() that takes no parameters 
        //and simply writes the person's full name to the console in the format of: "Name: [full name]".
        public void SayName()
        {
            Console.WriteLine("Name:{0} {1}", FirstName, LastName);
        }
    }


}
