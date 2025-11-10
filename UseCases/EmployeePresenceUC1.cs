using System;

namespace Employee_Wage.Usecase
{
    public class EmployeePresence
    {
        public void Execute()
        {
            Random random = new Random();
            int EMP_CHECK = random.Next(0, 2);

            switch (EMP_CHECK)
            {
                case 0:
                    Console.WriteLine("Employee is Absent");
                    break;

                case 1:
                    Console.WriteLine("Employee is Present");
                    break;
            }
        }
    }
}
