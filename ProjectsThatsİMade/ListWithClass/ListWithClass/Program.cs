using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListWithClass
{
    internal class Program
    {
        class ListElement<T>
        {   
            public ListElement<T> next;
            public T Data { get; set; }
            public ListElement(T el)
            {
                this.Data = el;
            }
        }
        //class MyList<T>
        //{
        //    public ListElement<T[]> arr;
        //    public void Add(T[] item)
        //    {
        //        arr = new ListElement<T[]>();
        //        arr.Data = item;
        //        arr.next = new ListElement<T[]>();
        //        arr.next.Data = item;
        //    }
        //}
        class MyList<T>
        {
            public ListElement<T>[] arr;
            ListElement<T> fitstElement;
            int currentIndex=0;
            int count = 0;
            public MyList()
            {

            }
            public void Add(T item)
            {
                if (count == 0)
                {
                    fitstElement = new ListElement<T>(item);
                    currentIndex = 0;
                    count++;
                }
                else
                {
                    ListElement<T> ele = new ListElement<T>(item);
                    currentIndex++;
                    count++;    
                }


                //ListElement<T> element = new ListElement<T>(item);
                //if (arr.Length == 0)
                //{
                //    arr = new ListElement<T>[] {element};
                //}
             
            }
            public ListElement<T> IndexOf(int index)
            {
                ListElement<T> ele = fitstElement;
                for (int i = 0; i <= index; i++)
                {
                    ele = ele.next;
                }
                return ele;

            }
        }

        static void Main(string[] args)
        {


            ListElement<int> list = new ListElement<int>(1);
            MyList<int> list2 = new MyList<int>();
            list2.Add(2);
            list2.Add(3);   
            list2.Add(4);

            Console.ReadKey();
         


        }
    }
}
