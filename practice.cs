using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class practice
    {
        public static void main(string[] args)
        {
            //Console.WriteLine("Enter the string:");
            //string s = Console.ReadLine();
            //List<char> singl = new List<char>();
            //string n= " ";

            //List<string> sp = s.Split(' ').ToList();

            //foreach(char value in s)
            //{
            //    if (singl.Contains(value)&& !n.Contains(value))
            //    {
            //        if(value.Equals(" "))
            //        {
            //            continue;
            //        }
            //        else
            //        {
            //            n = n+ value + " ";
            //        }

            //    }
            //    else
            //    {
            //        singl.Add(value);
            //    }
            //}
            //Console.WriteLine(n);
            Console.WriteLine("Enter the string:");
            string s = Console.ReadLine();
            IDictionary<char, int> dict = new Dictionary<char, int>();
            foreach(char val in s)
            {
                if (dict.ContainsKey(val))
                {
                    dict[val]++;
                }
                else
                {
                    dict.Add(val, 1);
                }
            }
            
            Console.WriteLine(dict.FirstOrDefault(x=>x.Value==(dict.Values.Max())).Key);
            
            Console.ReadKey();
        }
    }
}
