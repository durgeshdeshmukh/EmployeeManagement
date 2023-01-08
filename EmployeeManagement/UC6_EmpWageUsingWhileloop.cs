using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    internal class UC6_EmpWageUsingWhileloop
    {
        //const, readonly
        public const int IS_PART_TIME = 1;
        //public readonly int Test=12;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_HRS_IN_MONTH = 100;
        public static void EmpWageFor20Days()
        {
            //variables
            int empHrs = 0;
            int empWage = 0;
            int totalEmpHrs = 0;
            int totalEmpWage = 0;   
            int totalWorkingDays = 0;
            //computation
            while (totalEmpHrs < MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs = totalEmpHrs + empHrs; //totalEmpHrs+=empHrs;
                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalEmpWage = totalEmpWage + empWage;
                Console.WriteLine("Day# : "+ (totalWorkingDays) + " Emp Wage is " + empWage);
            }
            Console.WriteLine("Total Emp Wage for the month is : " + totalEmpWage);
        }
    }
}
