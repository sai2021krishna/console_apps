using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static void GetCohortDetails(string co_name, int GC_count,string mode,string track, string curr_module)
        {
            if((mode=="OBL"||mode=="PARC"||mode=="obl"||mode=="parc")&&(track=="JAVA"|| track == "java" || track ==".Net"|| track == ".NET"|| track == ".net" || track == "dotnet" || track == "DOTNET"))
            {
                Console.WriteLine($"It is {co_name} with {GC_count} GenCs undergoing training for {track} thru {mode}. The current module of training is {curr_module}");
            }
            else
            {
                Console.WriteLine("invalid track or mode");
            }
        }
        static void main(string[] args)
        {
            Console.WriteLine("enter cohort name:");
            string c_name = Console.ReadLine();

            Console.WriteLine(" enter the gen c count:");
            int gc_cout = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter mode:");
            string m_ode= Console.ReadLine();

            Console.WriteLine("enter track:");
            string t_rack = Console.ReadLine();

            Console.WriteLine("enter current module:");
            string cur_module = Console.ReadLine();
            
            GetCohortDetails(GC_count: gc_cout, co_name: c_name,mode:m_ode, curr_module:cur_module,track:t_rack);

            Console.ReadKey();
        }
    }
}
