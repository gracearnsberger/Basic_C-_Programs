using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    //create another class called Employee and have it inherit from the Person class.
    class Employee : Person, IQuittable
    {
        //implement the SayName() method inside of the Employee class.
        public override string SayName()
        {
            Console.WriteLine("Employee: ");
            return base.SayName();
        }

        //have your Employee class inherit that interface 
        public void Quit()
        {
            //implement the Quit() method
            Console.WriteLine("I'm quitting!!!");
        }
    }
}
