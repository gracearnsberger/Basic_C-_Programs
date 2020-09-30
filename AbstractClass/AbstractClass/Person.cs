using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    //create an abstract class called Person 
    public abstract class Person
    {
        //two properties: string firstName and string lastName
        public string firstName;
        public string lastName;

        //give it the method SayName()
        public virtual string SayName()
        {
            Console.WriteLine("Name: {0} {1}", firstName, lastName);
            return null;
        }
    }
}
