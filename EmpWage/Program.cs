using System.ComponentModel.Design;

namespace EmpWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int emp_full_time_present = 1;
            int empHrs = 0;
            int empWage = 0;
            int emp_Rate_per_hrs = 20;

            Random random = new Random();
            int empCheck = random.Next(0, 2);

            if (empCheck == emp_full_time_present)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }

            empWage = empHrs * emp_Rate_per_hrs;
            Console.WriteLine("Employee Wage: " + empWage);
        }
    }
}