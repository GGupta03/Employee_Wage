using System;

using Employee_Wage.Usecase;

namespace Employee_Wage
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeePresence employeePresence = new EmployeePresence();
            employeePresence.Execute();

            DailyWage dailyWage = new DailyWage();
            dailyWage.Execute();
        }
    }
}
