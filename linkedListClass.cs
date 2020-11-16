using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  
    class linkedListClass
    {
        
        class node
        {
            public int data { get; set; }
            public node next { get; set; }

            public node(int value)
            {
                data = value;
                next = null;
            }
        }
        class linkedList
        {
            public node head { get; set; }
            public node tail { get; set; }
            public node ptr { get; set; }
            public node L2ptr { get; set; }
            public node preptr { get; set; }
            public node L2preptr { get; set; }
            public linkedList()
            {
                this.head = null;
                this.tail = null;
                this.ptr = null;
                this.L2ptr = null;
                this.preptr = null;
                this.L2preptr = null;

            }
            //public void insertNode(int val)
            //{
            //    node n = new node(val);
            //    if (this.head == null)
            //    {
            //        this.head = n;
            //        //this.current = n;
            //    }
            //    else
            //    {
            //        this.current = this.head;
            //        while (this.current.next != null)
            //        {
            //            this.current = this.current.next;
            //        }
            //        this.current.next = n;
            //    }
                
            //    Console.WriteLine("data entered!!");
            //}
            public void insertNode(int val)
            {
                node n = new node(val);
                if (this.head == null)
                {
                    this.head = n;
                    this.tail = n;
                }
                else
                {
                    this.tail.next = n;
                    this.tail = n; 
                }

                Console.WriteLine("data entered!!");
            }
            public void search()
            {

            }
            public void delete()
            {

            }

            public void merge(linkedList l)
            {
                //int c = 0;
                ptr = this.head;
                L2ptr = l.head;
                node n = new node(0);
                if (this.head.data <= l.head.data)
                {
                    while(ptr.next!=null && L2ptr.next != null)
                    {
                        while (ptr.data <= L2ptr.data)
                        {
                            preptr = ptr;
                            ptr = ptr.next;
                        }
                        n.next = preptr.next;
                        n.data = L2ptr.data;
                        preptr = n;
                        L2ptr = L2ptr.next;
                    }
                    
                }
            }
            public void display()
            {
                linkedList ptr = new linkedList();
                this.ptr = this.head;
                if (this.head == null)
                {
                    Console.WriteLine("--------linked list empty--------");
                }
                else
                {
                    while (this.ptr.next != null)
                    {
                        Console.Write(this.ptr.data + "-->");
                        this.ptr = this.ptr.next;
                    }
                    Console.Write(this.ptr.data);
                }
            }
        }
         
        
        public static void Main()
        {
            linkedList l1 = new linkedList();
            linkedList l2 = new linkedList();
            Console.WriteLine("enter 1 to add data to linked list");
            int x = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("enter the value to be entered");
                int val = Convert.ToInt32(Console.ReadLine());

                l1.insertNode(val);
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("enter the value to be entered");
                int val = Convert.ToInt32(Console.ReadLine());

                l2.insertNode(val);
            }
            l1.display();
            l2.display();
            l1.merge(l2);
            l1.display();
            Console.ReadKey();
        }
    }
}
