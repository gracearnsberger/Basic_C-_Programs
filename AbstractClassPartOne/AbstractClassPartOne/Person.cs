using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassPartOne
{
    public abstract class Person
    {
        //create an abstract class called Person with two properties: 
        //string firstName and string lastName
        public string firstName { get; set; }
        public string lastName { get; set; }

        //give it the method SayName()
        public abstract void SayName();
    }
}
