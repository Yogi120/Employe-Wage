namespace EmpPartTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int EmpWage = 0;
            int EmpHrs = 0;
            int Emp_rate_per_hrs = 20;
            int Emp_part_time_present = 1;
            int Emp_full_time_presnt = 2;
            Random random = new Random();
            int EmpCheck = random.Next(0, 3);

            if (EmpCheck == Emp_part_time_present)
            {
                EmpHrs = 4;
            }

            else if (EmpCheck == Emp_full_time_presnt)
            {
                EmpHrs = 8;
            }

            else
            {

                EmpHrs = 0;
            }

            EmpWage = EmpHrs * Emp_rate_per_hrs;
            Console.WriteLine("Employee Wage is " + EmpWage);

        }
    }
}