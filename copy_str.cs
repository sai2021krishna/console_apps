using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class copy_str
    {
        public static void cmp_str(string s1,string s2)
        {
            int l1 = s1.Length;
            //int l2 = s2.Length;
            string result = "NO";
            for(int i=0;i<l1;i++)
            {
                if (s2.Contains(s1[i]))
                {
                    result = "YES";
                    break;
                }
            }
            Console.WriteLine(result);
        }
        public static void main()
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            cmp_str(s1,s2);
            Console.ReadKey();
        }
    }
}
