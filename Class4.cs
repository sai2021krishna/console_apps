using System;
using System.Collections.Generic;
using System.IO;
class Solution2
{

    static void main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

        int type = 0;
        int q = 0;
        int val = 0;
        int temp = 0;
        
        int temp2 = 0;

        Stack<int> s1 = new Stack<int>();
        s1.Push(0);
        Stack<int> s2 = new Stack<int>();
        s2.Push(0);

        q = Convert.ToInt32(Console.ReadLine());
        int l = q / 2;
        int[] k = new int[l];
        l = 0;

        if (q >= 1 && q <= 100000)
        {
            for (int i = 0; i < q; i++)
            {
                Console.WriteLine();
                //type=Convert.ToInt32(Console.Read());
                string[] arr = (Console.ReadLine()).Split(' ');
                
                if (type <= 0 || type >= 4) { break; }
                else
                {
                    if (type == 1)
                    {
                        //val=Convert.ToInt32(Console.ReadLine());
                        val = int.Parse(arr[1]);
                        if (val <= 0 || val >= 1000000001) { break; }
                        else
                        {
                            s1.Push(val);
                        }
                    }
                    else if (type == 2)
                    {
                        temp = s1.Pop();
                        while (temp != 0)
                        {

                            s2.Push(temp);

                            temp = s1.Pop();
                        }
                        s1.Push(0);
                        s2.Pop();
                        temp2 = s2.Pop();
                        while (temp2 != 0)
                        {

                            s1.Push(temp2);
                            temp2 = s2.Pop();
                        }
                        s2.Push(0);
                    }
                    else
                    {

                        temp = s1.Pop();
                        while (temp != 0)
                        {

                            s2.Push(temp);
                            temp = s1.Pop();

                        }
                        s1.Push(0);

                        temp2 = s2.Pop();
                        k[l] = temp2; l++;
                        while (temp2 != 0)
                        {

                            s1.Push(temp2);
                            temp2 = s2.Pop();
                        }
                        s2.Push(0);
                        Console.WriteLine(k);
                    }
                }


            }

        }

        for (int j = 0; j < l; j++)
        {
            Console.WriteLine(k[j]);

        }

    }
}