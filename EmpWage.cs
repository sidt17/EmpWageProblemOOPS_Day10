using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    
    public class EmpWage
    {
        public void computeWage(string company, int EmpWagePerHour, int MaxDays, int MaxHrs)
        {
            const int IS_PART_TIME = 1;
            const int IS_FULL_TIME = 2;
            int EmpWage = 0;
            int EmpHrs = 0;
            int EmpDays = 0;
            Random rand = new Random();
            while (EmpDays <= MaxDays && EmpHrs <= MaxHrs)
            {
                int key = rand.Next(0, 3);
                switch (key)
                {
                    case IS_PART_TIME:
                        EmpHrs = EmpHrs + 4;
                        EmpDays++;
                        break;

                    case IS_FULL_TIME:
                        EmpHrs = EmpHrs + 8;
                        EmpDays++;
                        break;

                    default:
                        EmpHrs = 0;
                        EmpDays++;
                        break;
                }

            }

            EmpWage = EmpHrs * EmpWagePerHour;
            Console.WriteLine("Employee wage is " + EmpWage + " for company " + company);

        }




    }
}
