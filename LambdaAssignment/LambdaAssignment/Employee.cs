using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    //Define employee information
    class Employee
    {
        public int empID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        public Employee(int ID, string FN, string LN)
        {
            empID = ID;
            firstName = FN;
            lastName = LN;
        }
    }
}
