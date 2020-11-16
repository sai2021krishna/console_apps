using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class camel_snake
    {
        public static string To_camel_case(string s)
        {
            int in_int = 0;
            string ss = "";
            for(int i = 0; i < s.Length; i++)
            {
                if (s[i]=='_')
                {
                    i++;
                    in_int = Convert.ToInt32(s[i]);
                    in_int = in_int - 32;
                    ss = ss + Convert.ToChar(in_int);
                }
                else
                {
                    ss = ss+s[i];
                }
            }

            return ss;
        }
        public static string To_snake_case(string s)
        {
            string str = "";string ss = "";
            int in_int = 0;
            for(int i = 0; i < s.Length; i++)
            {
                in_int = Convert.ToInt32(s[i]);
                if (in_int >= 65 && in_int <= 90)
                {
                    in_int = in_int + 32;
                    ss ="_" + Convert.ToChar(in_int);
                }
                else
                {
                    ss = Convert.ToString(s[i]);
                }
                str = str + ss;
            }
            
            return str;
        }
        public static void main()
        {
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine("Enter the string you want to process:");
                string s = Console.ReadLine();
                string result = "";

                if (s.Contains("_"))
                {
                    result = To_camel_case(s);
                }
                else
                {
                    result = To_snake_case(s);
                }

                Console.WriteLine("\nprocessed to: {0}", result);
                Console.WriteLine("\n\n\n");
            }
            
            Console.ReadKey();
        }
    }
}
