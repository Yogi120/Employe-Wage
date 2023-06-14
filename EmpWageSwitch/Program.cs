namespace EmpWageSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int Is_part_time = 1;
            const int Is_full_time_present = 2;
            
            int EmpWage = 0;
            int EmpHrs = 0;
            int Emp_rate_per_hrs = 20;

            
              
            Random random = new Random();
            int Empcheck = random.Next(0, 3);

            switch (Empcheck)
            {
                case Is_part_time:
                    EmpHrs = 4;
                    break;

                case Is_full_time_present:
                    EmpHrs = 8;
                    break;

                default:
                    EmpHrs = 0;
                    break;
            }
            EmpWage = EmpHrs * Emp_rate_per_hrs;
            Console.WriteLine("Employee Wage is "+ EmpWage);

        }
    }
}