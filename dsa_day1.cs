using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class dsa_day1
    {
        //public static readonly Random _random = new Random();
        static public int Partition(int[] arr, int start, int end)
        {
            int temp = 0;
            int pivot = arr[start]; /*_random.Next(start, end);*/
            int pindex = start;
           for(int i=start+1;i<=end;i++)
            {
                if (arr[i] <= pivot)
                {
                    //swap(arr[i],arr[pindex]
                    temp = arr[i];
                    arr[i] = arr[pindex];
                    arr[pindex]=temp;
                    pindex++;
                }
            }
            //swap(arr[pindex],arr[pivot])
            temp = arr[pindex];
            arr[pindex] = arr[end];
            arr[end] = temp;

            return pindex;
        }
        static public void quickSort(int[] arr, int left, int right)
        {
            int partition;
            if (left < right)
            {
                partition = Partition(arr, left, right);
    
                    quickSort(arr, left, partition - 1);
                
                    quickSort(arr, partition + 1, right);
            }
        }

        public static void main()
        {
            
            int[] arr = new int[10];
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter the value at {0} index", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int min = arr.Min();
            int max = arr.Max();
            int count = arr.Length;
            int sum = arr.Sum();
            int avg = sum / count;

            Console.WriteLine("Addition pf all ={0}\nTotal Count ={1}\nAverage of all numbers ={2}\nLargest of all numbers ={3}\nsmallest of all numbers ={4} ",sum,count, avg,max, min);
            Console.WriteLine("unsorted array");
            foreach (int x in arr) { Console.WriteLine(x); }
            quickSort(arr, 0, 9);
            Console.WriteLine("sorted array");
            foreach (int x in arr) { Console.WriteLine(x); }
            Console.ReadKey();
        }
    }
}
