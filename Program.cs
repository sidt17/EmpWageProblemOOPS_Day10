using System;

namespace EmployeeWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWage obj1 = new EmpWage();
            obj1.Total("Cognizant", 20, 20, 100);
            obj1.Total("HCL", 22, 25, 100);
            obj1.Total("Cognizant", 20, 20, 100);
        }
    }
}
