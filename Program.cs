using System;

namespace EmployeeWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWage obj1 = new EmpWage();
            obj1.computeWage("Cognizant", 20, 20, 100);
            obj1.computeWage("HCL", 22, 25, 100);
            obj1.computeWage("Cognizant", 20, 20, 100);
        }
    }
}
