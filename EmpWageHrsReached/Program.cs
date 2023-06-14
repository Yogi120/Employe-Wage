namespace EmpWageHrsReached
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Monthly_wage;
            const int Is_full_time = 2;
            const int Is_part_time = 1;
            int Emp_rate_per_hrs = 20;
            int Num_of_working_days = 2;
            int Max_Hrs_in_month = 10;

            int EmpHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            while(totalEmpHrs <= Max_Hrs_in_month && totalWorkingDays < Num_of_working_days)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
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
                totalEmpHrs += EmpHrs;
                Console.WriteLine("Day:" + totalWorkingDays + " Emp Hrs : " + EmpHrs);


            }
            int totalEmpWage = totalEmpHrs * Emp_rate_per_hrs;
            Console.WriteLine("Total Emp Wage : " + totalEmpWage);
        }
    }
}