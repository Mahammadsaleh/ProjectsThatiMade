using System;
using System.Collections.Generic;

namespace List
{
    internal class Program
    {
        class MyList
        {
            public string name;
            public int age;
            public int salary;
            public MyList(string name, int age, int salary)
            {
                this.name = name;
                this.age = age;
                this.salary = salary;
            }
        }

        static void Main(string[] args)
        {

            List<MyList> Employees = new List<MyList>();

            Employees.Add(new MyList("Farid", 35, 1500));
            Employees.Add(new MyList("Mahammad", 23, 1300));
            Employees.Add(new MyList("Kanan", 34, 1500));
            Console.WriteLine("This is employee table:");
            ShowElements(Employees);
            Console.WriteLine("\n");
            while (Employees.Count > 0)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Press 1 to adding employee to the table");
                Console.WriteLine("Press 2 to delete employee");
                Console.WriteLine("Press 3 to finding index of employee to the table");
                ConsoleKeyInfo key;
                key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        AddElements(Employees);
                        ShowElements(Employees);
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        DeleteElements(Employees);
                        ShowElements(Employees);
                        break ;
                    case ConsoleKey.D3:
                        Console.Clear();
                        FindIndex(Employees);
                        break;

                }
                Console.WriteLine("Number of employee exist:" + Employees.Count);
            }
            Console.ReadKey();
        }
        static void AddElements(List<MyList> Employess)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Enter the name ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the age ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the salary ");
            int salary = int.Parse(Console.ReadLine());
            Employess.Add(new MyList(name, age, salary));
        }
        private static void FindIndex(List<MyList> Employees)
        {
            Console.WriteLine("\n");
            Console.Write("Enter the name for finding index of employee: ");
            string name = Console.ReadLine();
            int findIndex = Employees.FindIndex(x => x.name == name);
            Console.WriteLine($"{name}'s index:{findIndex + 1}");
        }

        static void DeleteElements(List<MyList> students)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Delete employee what you want");
            Console.WriteLine("Enter the index that which will delete");
            int index = int.Parse(Console.ReadLine());
            index = index - 1;
            students.Remove(students[index]);
        }
        private static void ShowElements(List<MyList> Employees)
        {
            Console.WriteLine("\n");
            foreach (var employee in Employees)
            {
                Console.WriteLine("Name={0}  | Age={1}  | Salary={2}", employee.name, employee.age, employee.salary);
            }
        }
    }
}
