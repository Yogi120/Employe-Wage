using System.Runtime.InteropServices;

namespace EmpWage20Mo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Monthly_wage;
            const int Is_full_time = 2;
            const int Is_part_time = 1;
            int Emp_rate_per_hrs = 20;
            int Total_working_days = 20;

            int EmpWage = 0;
            int EmpHrs = 0;

            Random random = new Random();
            int EmpCheck = random.Next(0, 3);

            switch (EmpCheck)
            {
                case Is_part_time:
                    EmpHrs = 4;
                    break;
                case Is_full_time:
                    EmpHrs = 8;
                    break;
                default:
                    EmpHrs = 0;
                    break;
            }
            EmpWage = EmpHrs * Emp_rate_per_hrs;
            Monthly_wage = EmpWage * Total_working_days;
            Console.WriteLine("Wage for a Month is: " + Monthly_wage);
        }
    }
}