using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Solution
    {
        public static void main()
        {
            int type = 0;
            int q = 0;
            int val = 0;
            int temp = 0;
            
            int temp2 = 0;

            Stack<int> s1 = new Stack<int>();
            s1.Push(0);
            Stack<int> s2 = new Stack<int>();
            s2.Push(0);

            Console.WriteLine("enter the value of q:");
            q = Convert.ToInt32(Console.ReadLine());

            int l = q / 2;
            int[] k = new int[l];

            for (int i = 0; i < q; i++)
            {
                Console.WriteLine("enter the value of type:");
                type = Convert.ToInt32(Console.ReadLine());

                if (type == 1)
                {
                    Console.WriteLine("enter the value to be inserted:");
                    val = Convert.ToInt32(Console.ReadLine());
                    s1.Push(val);
                }

                else if (type==2)
                {
                    temp = s1.Pop();
                    while (temp != 0)
                    {
                        Console.WriteLine("entering stack 2 {0}",temp);
                        s2.Push(temp);
                        
                        temp= s1.Pop();
                    }
                    s1.Push(0);
                    s2.Pop();
                    temp2 = s2.Pop();
                    while (temp2 != 0)
                    {
                        Console.WriteLine("entering stack 1 {0}",temp2);
                        s1.Push(temp2);
                        temp2 = s2.Pop();
                    }
                    s2.Push(0);
                }
                //else
                //{
                //    Console.WriteLine("inside print");
                //    temp = s1.Pop();
                //    while (temp != 0)
                //    {
                //        Console.WriteLine("entering stack 2 {0}", temp);
                //        Console.WriteLine(temp + "->");
                //        s2.Push(temp);
                //        temp = s1.Pop();

                //    }
                //    s1.Push(0);

                //    temp2 = s2.Pop();
                //    while (temp2 != 0)
                //    {
                //        Console.WriteLine("entering stack 1 {0}", temp2);
                //        s1.Push(temp2);
                //        temp2 = s2.Pop();
                //    }
                //    s2.Push(0);

                //}

                else
                {
                    temp = s1.Pop();
                    while (temp != 0)
                    {
                        //Console.WriteLine("entering stack 2 {0}", temp);
                        //Console.WriteLine("at the top="+temp);
                        s2.Push(temp);
                        temp = s1.Pop();

                    }
                    s1.Push(0);

                    temp2 = s2.Pop();
                    k[l] = temp2;
                    while (temp2 != 0)
                    {
                        //Console.WriteLine("entering stack 1 {0}", temp2);
                        s1.Push(temp2);
                        temp2 = s2.Pop();
                    }
                    s2.Push(0);
                    Console.WriteLine(k);
                }

            }


            Console.ReadKey();
        }

    }
    
   
}
