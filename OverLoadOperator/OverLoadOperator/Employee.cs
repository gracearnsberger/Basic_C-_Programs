using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoadOperator
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //overload the "==" operator so it checks if two Employee objects are equal by comparing their Id property.
        public static bool operator == (Employee employeeOne, Employee employeeTwo)
        {
            if (employeeOne.Id == employeeTwo.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator != (Employee employeeOne, Employee employeeTwo)
        {
            if (employeeOne.Id != employeeTwo.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
