using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Date_of_Joining
    {
        public static void main()
        {
            DateTime d = DateTime.Today;
            Console.WriteLine(d);
            DateTime join;
            int months=0;
            int diff_years = 0;

            Console.WriteLine("enter your Date Of Joining:");
            join = Convert.ToDateTime(Console.ReadLine());
            int j_year = Convert.ToInt32(join.Year);
            int cur_year= Convert.ToInt32(d.Year);

            int j_month = Convert.ToInt32(join.Month);
            int cur_month = Convert.ToInt32(d.Month);

            int j_day = Convert.ToInt32(join.Day);
            int cur_day = Convert.ToInt32(d.Day);

            diff_years = cur_year - j_year;

            if (j_month > cur_month)
            {
                diff_years = diff_years - 1;
                months = 12 - (j_month - cur_month);
            }
            else
            {
                months = cur_month - j_month;
            }
            Console.WriteLine("You have been in this company for {0} Years and {1} months", diff_years, months);
            Console.ReadKey();
        }
    }
}
