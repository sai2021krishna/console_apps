using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class node
     {
        public node left { get; set; }
        public int data { get; set; }
        public node right { get; set; }

        public node(int n)
        {
                left = null;
                data = n;
                right = null;
        }
     }
     class trees_basics
     {
        public node root { get; set; }
        public node ptr { get; set; }
        public node temp { get; set; }
        public trees_basics()
        {
           root = null;
           ptr = null;
            temp = null;
        }

        public void insert_node(node root, int data)
        {
            node n = new node(data);
            int s = 0;
            ptr = root;
            if (root == null)
            {
                root = n;   
            }
           else
           {
                while (s != 1)
                {
                    if (data<ptr.data)
                    {
                        
                        if (ptr.left == null)
                        {
                            ptr.left = n;
                            s++;   
                        }
                        else
                        {
                            ptr = ptr.left;
                        }
                    }
                    else
                    {
                        if (ptr.right == null)
                        {
                            ptr.right = n;
                            s++;
                        }
                        else
                        {
                            ptr = ptr.right;  
                        }
                    }
                }  
           }
            Console.WriteLine("--------data inserted--------");
        }
        public static void main()
        {
            Console.WriteLine("Enter the number you want to insert:");
            int num = Convert.ToInt32(Console.ReadLine());
            trees_basics new_ob = new trees_basics();
            new_ob.insert_node(new_ob.root,num);
            Console.ReadKey();
        }
     }   
}
