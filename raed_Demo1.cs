using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class read_Demo1
    {
        public static void main()
        {
            string file_path = @"c:\data\demo1.txt";

            if (File.Exists(file_path))
            {
                string[] str = File.ReadAllLines(file_path);

                foreach (string line in str)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("File Does not Exists.");
            }
            
            Console.ReadKey();
        }
    }
}
