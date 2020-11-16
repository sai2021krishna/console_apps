using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class queueWithStack
    {
        public static void main()
        {
            Stack<int> s1 = new Stack<int>();
            Stack<int> s2 = new Stack<int>();

            int temp;int x;int popped;int peek; int action;

            do
            {
                Console.WriteLine("\n\nEnter 1 to PUSH\nEnter 2 tp POP\nEnter 3 to PEEK\n------Enter 007 to Terminate------");
                action = Convert.ToInt32(Console.ReadLine());

                if (s2.Count == 0)
                {
                    while (s1.Count != 0)
                    {
                        temp = s1.Peek();
                        s2.Push(temp);
                        s1.Pop();
                    }
                }
                if(s2.Count == 0 && (action==2 || action == 3))
                {
                    Console.WriteLine("--------Action cannot be processed--------\n--------Queue is empty--------\n\n");
                    continue;
                }
                else
                {
                    if (action == 1)
                    {
                        Console.WriteLine("Enter the value to PUSH");
                        x = Convert.ToInt32(Console.ReadLine());
                        s1.Push(x);
                    }
                    else if (action == 2)
                    {
                            popped = s2.Peek();
                            Console.WriteLine("Value popped is : {0}\n\n", popped);
                            s2.Pop();
                    }
                    else if (action == 3)
                    {
                            peek = s2.Peek();
                            Console.WriteLine("Value next in Queue is : {0}\n\n", peek); 
                    }
                    else
                    {
                        if (action != 007) 
                        {
                            Console.WriteLine("Wrong Input");
                            continue;
                        }
                        Console.WriteLine("Valar Morgulis!!! Action termination Initiated");
                        break; 
                    }
                }
                
            }
            while (action != 007);

            Console.ReadKey();
        }
    }
}
