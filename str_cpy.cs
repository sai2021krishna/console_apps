using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class str_cpy
    {
        public static void main()
        {
            string s1 = Console.ReadLine();

            List<char> lis = new List<char> { };
            int cost = 0;
            for(int i = 0; i < s1.Length; i++)
            {
                if (!lis.Contains(s1[i]))
                {
                    lis.Add(s1[i]);
                    cost++;
                }
            }

            Console.WriteLine("cost={0}", cost);
            Console.ReadKey();

        }
    }
}
