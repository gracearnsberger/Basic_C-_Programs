using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstantsAssignment
{
    public class Person
    {
        //chain two constructors together
        public string myName { get; set; }
        public int myID { get; set; }
        public Person(string name) : this(name, 0){}
        public Person(string name1, int ID1)
        {
            myID = ID1;
            myName = name1;
        }
    }
}