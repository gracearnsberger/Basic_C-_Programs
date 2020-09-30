using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadAssignment
{
    //declare a class to be static.
    static class NewClass
    {
        //updated output method
        public static string string1;
        public static string Divide()
        {
            string1 = "Thanks for using my calculator! :)";
            return string1; 
        }
    }
}
