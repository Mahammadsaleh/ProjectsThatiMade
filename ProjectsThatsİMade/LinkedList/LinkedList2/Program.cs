using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList2
{
    internal class Program
    {
        public class ListElement
        {
            public ListElement next;
            public ListElement prev;
            
            public int data;
        }

        public class LinkedList
        {
            private ListElement head;
            public int counter = 0;
            public void printAllNodes()
            {
                ListElement current = head;
                while (current != null)
                {
                    Console.WriteLine(current.data);
                    current = current.next;
                }
            }

            public void AddFirst(int data)
            {
                ListElement toAdd = new ListElement();
                toAdd.data = data;
                toAdd.next = head;

                toAdd.prev = null;
                //if(head != null)
                //{
                //    head.prev = toAdd;
                //}

                head = toAdd;
                counter++;
            }
            public void AddLast(int data)
            {
                if (head == null)
                {
                    head = new ListElement();
                   
                    //head.prev = head;
                    
                    head.data = data;
                    head.next = null;
                    counter++;
                }
                else
                {
                    ListElement toAdd = new ListElement();
                    toAdd.data = data;

                    ListElement current = head;
                    while (current.next != null)
                    {
                        current = current.next;
                    }

                    current.next = toAdd;
                    counter++;
                }
            }
            public void RemoveStart()
            {
                if (counter > 0)
                {
                    head = head.next;
                    head.prev = null;
                    counter--;
                }
                else
                {
                    Console.WriteLine("No element exist in this linked list.");
                }
            }                                                    
            public void RemoveEnd()                                               
            {
                if (counter > 0)
                {
                    ListElement prevElement = new ListElement();
                    ListElement current = head;
                    while (current.next != null)
                    {
                        prevElement = current;
                        current = current.next;
                    }
                    prevElement.next = null;
                }
                else
                {
                    Console.WriteLine("No element exist in this linked list.");
                }
            }
            public void ReverseLinkedList()
            {
                ListElement prev = null;
                ListElement current = head;
                ListElement temp = null;
                while (current != null)
                {
                    temp = current.next;
                    current.next = prev;
                    prev = current;
                    current = temp;
                }
                head = prev;
            }
        }

         
       
        static void Main(string[] args)
        {
            Console.WriteLine("Add First:");
            LinkedList myList1 = new LinkedList();

            myList1.AddFirst(1);
            myList1.AddFirst(2);
            myList1.AddFirst(3);
            myList1.RemoveStart();

            //myList1.ReverseLinkedList();
            //myList1.RemoveEnd();

            myList1.printAllNodes();
            Console.WriteLine();
            //Console.WriteLine("Add Last:");
            //LinkedList myList2 = new LinkedList();
            //myList2.AddLast(1);
            //myList2.AddLast(2);
            //myList2.AddLast(3);
  
            Console.WriteLine(" ");
            LinkedList<int> myList3 = new LinkedList<int>();
            myList3.AddFirst(1);
            myList3.AddFirst(2);
            myList3.AddFirst(3);
            myList3.RemoveFirst();
            //myList3.RemoveLast();

            foreach (int i in myList3)
            {
                Console.WriteLine(i);
            }
            
            Console.ReadLine();
        }
        
    }
}
