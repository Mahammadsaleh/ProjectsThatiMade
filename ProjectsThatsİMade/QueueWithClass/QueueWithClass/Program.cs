using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueWithClass
{
    internal class Program
    {
        public class LinkedListNode
        {
            public int data;
            public LinkedListNode next;
            public LinkedListNode(int data)
            {
                this.data = data;
                this.next = null;
            }
        }
        public class Queue
        {
            LinkedListNode front;
            LinkedListNode back;
            public int counter = 0;
            public int counterForPeek = 0;
            public Queue()
            {
                front = null;
                back = null;
            }
            
            public void Enqueue(int data)
            {
                LinkedListNode newElement = new LinkedListNode(data);
                if (front == null)
                {
                    front = back = newElement;
                    return;
                }
                back.next = newElement;
                back = newElement;
                counter++;
            }
            public int DeQueue()
            {
                int peek = -1;
                if (front != null)
                {
                    peek = front.data;
                    front = front.next;
                }
                counter--;
                return peek;
            }
            public int PrintWithQueue()
            {
                if (front != null)
                {
                    if(counterForPeek >= 1) 
                    {
                        front = front.next;
                    }
                    counterForPeek++;
                    return front.data;
                }
                return 0;
            }
            public int GetPeek()
            {
                if (front != null)
                {
                    return front.data;
                }
                return -1;
            }

        }

        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue(40);
            queue.Enqueue(45);
            queue.Enqueue(50);
            //while (queue.counter >= 0)
            //{
            //    Console.WriteLine(queue.DeQueue());
            //}
            Console.WriteLine(queue.GetPeek());
            Console.WriteLine(queue.GetPeek());

            Console.ReadKey();
        }
    }
}
