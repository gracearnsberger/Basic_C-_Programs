using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandelingAssignment
{
    //display appropriate error messages if the user enters zero or negative numbers

    class ZeroException : Exception
    {
            public ZeroException() : base("Please don't enter 0.")
            {

            }
            public ZeroException(string Message) : base(Message)
            {

            }
    }
}

