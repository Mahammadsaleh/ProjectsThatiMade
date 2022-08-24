using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentT
{
    class Student<T>
    {
        public T Id { get; set; } 
        public string Name { get; set; }
        public int Age { get; set; }
        public T Gpa { get; set; }
        public T GroupNum { get; set; } 
        public Student(T ıd, string name, int age, T gpa, T groupNum)
        {
            Id = ıd;
            Name = name;
            Age = age;
            Gpa = gpa;
            GroupNum = groupNum;
        }   
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student<int> saleh = new Student<int>(123, "Saleh", 12, 90,5);
            Student<string> ferid = new Student<string>("a123", "Ferid", 12,"A","5b");
            int salehId=saleh.Id;
            int feridId=saleh.Id;
        }
    }
}
