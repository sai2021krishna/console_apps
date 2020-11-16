using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class insertion_sort
    {
        public static void sort(int[] a)
        {
            int s = 0;
            int value = 0;
            int len = a.Length;
            for(int i = 1; i < len; i++)
            {
                value = a[i];
                s = 0;
                for (int j = (i - 1); j >= 0 && s != 1;)
                {
                    if (value < a[j])
                    {
                        a[j+1] = a[j];
                        j--;
                        a[j + 1] = value;
                    }
                    else
                    {
                        s = 1;
                    }
                }
            }
        }
        public static void array_disp(int[] a)
        {
            int len = a.Length;
            for(int i = 0; i < len; i++)
            {
                Console.Write(a[i] + "  ");
            }
            Console.WriteLine();
        }
        public static void main()
        {
            int e = 0;
            Console.WriteLine("Enter the no. of elements you wish to insert:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the element you wish to insert:");
                e = Convert.ToInt32(Console.ReadLine());
                arr[i]=e;
            }
            Console.Write("Unsorted Array:");
            array_disp(arr);

            Console.Write("Sorted Array:");
            sort(arr);
            array_disp(arr);

            Console.ReadKey();
        }
    }
}
