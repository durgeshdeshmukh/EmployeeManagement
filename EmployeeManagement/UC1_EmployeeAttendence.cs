using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    internal class UC1_EmployeeAttendence
    {
        public static void EmployeeAttendence()
        {
            int IS_FULL_TIME = 1;
            Random random = new Random();
            int empcheck = random.Next(0, 2);
            if(empcheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}
