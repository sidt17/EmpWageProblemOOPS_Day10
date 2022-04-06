using System;

namespace EmployeeWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderArray obj = new EmpWageBuilderArray();
            obj.addCompanyEmpWage("Reliance", 15, 8, 8);

            obj.addCompanyEmpWage("Dmart", 10, 6, 20);
            obj.ComputeEmpWage();
        }
    }
}
