using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    
    public class EmpWage
    {
        public void Wage()
        {
         int IS_PART_TIME = 1;
         int IS_FULL_TIME = 2;
        int EMP_RATE_PER_HOUR = 20;
         int NUM_OF_WORKING_DAYS = 20;
         int MAX_HRS_IN_MONTH = 100;
         int empHrs = 0, totalempHrs = 0, totalWorkingDays = 0, empWage = 0;
          
            while (totalempHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < MAX_HRS_IN_MONTH)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case 1:
                        empHrs = 4;
                        empWage = 80;
                        break;
                    case 2:
                        empHrs = 8;
                        empWage = 160;
                        break;
                    default:
                        empHrs = 0;
                        empWage = 0;
                        break;
                }
                totalempHrs += empHrs;
                Console.WriteLine("Day " + totalWorkingDays + " Employee Wage : " + empWage);
            }
            int totalEmpWage = totalempHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Employee wage : " + totalEmpWage);
        }
    }
}
