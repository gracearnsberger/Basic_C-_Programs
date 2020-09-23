using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAssignmet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Concatenate 3 strings
            string name = "grace!";
            string greeting = "Hello! ";
            string middle = "my name is ";

            string str = greeting + middle + name;

            //Converted a string to uppercase letters
            string state = "Colorado";
            state = state.ToUpper();


            //Used StringBuilder to build a paragraph of text, one sentence at a time.
            StringBuilder sb = new StringBuilder();

            sb.Append("\t My name is grace. ");
            sb.Append("I am from Denver Colorado. ");
            sb.Append("But I also lived in Austin. ");
            sb.Append("\n I work as an office manager for a startup software company. ");
            sb.Append("I want to make it as a software engineer. ");
            sb.Append("And maybe one day move to Europe. ");

            Console.WriteLine(str);
            Console.WriteLine(state);
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
