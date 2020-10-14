using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandelingAssignment
{
    //display appropriate error messages if the user enters zero or negative numbers

    class NegativeException : Exception
    {
        public NegativeException() : base("Please don't enter a negative number.")
        {

        }
        public NegativeException(string Message) : base(Message)
        {

        }
    }
}

