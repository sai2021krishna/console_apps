using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class1
    {
        public static void GetOrderDetails(string s_name,string p_name,int odr_qty=1,bool is_returnable=true)
        {
            Console.WriteLine($"Here is the order detail – {odr_qty} number of {p_name} by {s_name} is ordered. It’s returnable status is {is_returnable}"); 
        }
        static void main(string[] args)
        {
            Console.WriteLine("enter seller name:");
            string s_name = Console.ReadLine();

            Console.WriteLine("enter product name:");
            string pname = Console.ReadLine();

            Console.WriteLine(" enter quantity:");
            int qty = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("is retrunable:");
            bool m_ode = Convert.ToBoolean( Console.ReadLine());


            GetOrderDetails(s_name,pname,qty,m_ode);

            Console.WriteLine("optional parameter demo:");

            GetOrderDetails(s_name, pname);

            int? s = null;
            if (s is null)
            {
                Console.WriteLine("\n \n ********NULLABLE demo******** \n \n \n \n S is null");
            }

            Console.ReadKey();
        }
    }
}
