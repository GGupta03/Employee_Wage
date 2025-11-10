using System;

namespace Employee_Wage.Usecase
{
    public class DailyWage
    {
        public void Execute()
        {
            int EMP_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;

            int empWage = 0;
            int empHrs = 0;

            Random random = new Random();
            int EMP_CHECK = random.Next(0, 2);

            if(EMP_CHECK == EMP_FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }

            empWage = empHrs * EMP_RATE_PER_HOUR;

            Console.WriteLine("Employee Wage :" + empWage);

        }
    }
}