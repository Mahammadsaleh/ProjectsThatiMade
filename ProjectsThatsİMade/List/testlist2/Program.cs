using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testlist2
{
    internal class Program
    {
        static void ShowElements(List<school> students)
        {
            Console.WriteLine();
            foreach (var item in students)
            {
                Console.WriteLine(item.stdName + "\t | " + item.stdAge + "\t | " + item.stdOverall);
            }
        }
        static void AddElements(List<school> students)
        {
            Console.WriteLine();
            Console.WriteLine("Enter the name ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the age ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the overall ");
            double overall = double.Parse(Console.ReadLine());
            school std = new school() { stdName = name, stdAge = age, stdOverall = overall };
            students.Add(std);

        }
        static void DeleteElements(List<school> students)
        {
            Console.WriteLine();
            Console.WriteLine("Enter the index of row ");
            int index = int.Parse(Console.ReadLine());
            students.Remove(students[index]);
        }
        static void Main(string[] args)
        {
            school std1 = new school() { stdName = "Saleh", stdAge = 20, stdOverall = 92.3 };
            school std2 = new school() { stdName = "Farid", stdAge = 19, stdOverall = 87.9 };
            school std3 = new school() { stdName = "Azer", stdAge = 18, stdOverall = 95.0 };
            List<school> students = new List<school>() { std1, std2, std3 };
            while (true)
            {
                Console.WriteLine("Which operation do you want to use?");
                Console.WriteLine("1.Add\n2.Remove\n3.Count number of element\n4.Show Table");
                ConsoleKeyInfo key;
                key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        AddElements(students);
                        break;

                    case ConsoleKey.D2:
                        DeleteElements(students);
                        break;

                    case ConsoleKey.D3:
                        Console.WriteLine();
                        Console.WriteLine("Number of students:" + students.Count);
                        break;

                    case ConsoleKey.D4:
                        ShowElements(students);
                        break;

                }
            }
            Console.ReadKey();
        }
        class school
        {
            public string stdName { get; set; }
            public int stdAge { get; set; }
            public double stdOverall { get; set; }
        }
    }

}
