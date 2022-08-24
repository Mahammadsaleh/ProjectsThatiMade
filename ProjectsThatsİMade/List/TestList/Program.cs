using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestList
{
    internal class Program
    {
        class MyList
        {
            public string name;
            public int age;
            public int salary;
            //public MyList(string name, int age, int salary)
            //{
            //    this.name = name;
            //    this.age = age;
            //    this.salary = salary;

            //}

        }
        static void Main(string[] args)
        {
            //MyList customer1 = new MyList()
            //{
            //    name = "Sourabh",
            //    age = 31,
            //    salary = 1200
            //};
            //MyList[] customers = new MyList[2];
            //customers[0] = customer1;
            //Console.WriteLine(" Name={0}, Age={1}, Salary={2} ", customer1.name, customer1.age, customer1.salary);
            //Console.ReadKey();

            List<MyList> Employee = new List<MyList>()
            {
               new MyList{ name="Mahammad", age = 21,salary =1200 },
               new MyList{ name="Kanan", age = 22,salary =1300 }
            };

            foreach (var item in Employee)
            {
                Console.WriteLine("Name={0}, Age={1}, Salary={2} ", item.name, item.age, item.salary);
            }
            Console.ReadKey();
        }
    }
    }
