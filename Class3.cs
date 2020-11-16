using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
namespace ConsoleApp1
{
    class Solution1
    {
        public class node
        {
            public int data;
            public node next;
            public node()
            {
            }

            public node(int d)
            {
                data = d;
                next = null;
            }
        }

        public class stack1
        {
            public node head1;
            public stack1()
            {
                head1 = null;
            }

            public void push(int x)
            {
                //stack1 temp = new stack1(x);

                node p = head1;
                node temp = new node(x);
                if (head1 == null)
                {
                    head1 = temp;
                }
                else
                {
                    while (p.next != null)
                    {
                        p = p.next;
                    }
                    p.next = temp;
                    p = temp;
                }
                
            }

            public void pop()
            {
                node p = head1;
                node pp = null;
                if (head1 == null)
                {
                    Console.WriteLine("empty");
                }
                else
                {
                    while (p.next != null)
                    {
                        pp = p;
                        p = p.next;
                    }
                    pp.next = null;
                }
            }

            public void display(stack1 head)
            {
                if (head == null)
                {
                    Console.WriteLine("empty");

                }
                
                else
                {
                    Console.WriteLine("inside display");
                    node p = head1;
                    while (p != null)
                    {
                        Console.WriteLine(p.data);
                        p = p.next;
                    }

                }

            }
        }

        //public class stack2
        //{
        //    public node head2;
        //    public stack2()
        //    {
        //        head2 = null;
        //    }
        //}

 

        public static void main()
        {
            //int x = 5;
            stack1 head = new stack1();
            stack1 s = new stack1();
            s.push(6);
            s.push(7);
            s.push(8);
            s.push(9);
            s.display(head);
            s.pop();
            s.display(head);
            Console.ReadKey();
        }

        
    }     
}


