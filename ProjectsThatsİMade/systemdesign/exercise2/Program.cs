using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double k, lamda, t, p, sum, fact, func, func2, pzero, m, downTime;
            Console.WriteLine("enter the count of communication lines: ");
            k = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter m:");
            m = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the lamba: ");
            lamda = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the time: ");
            t = double.Parse(Console.ReadLine());
           
            p = lamda * t;
            Console.WriteLine("Intensity equal: " + p);
            sum = 1;
            fact = 1;
            for (int i = 1; i < k + 1; i++)
            {
                fact = fact * i;
                func = Math.Pow(p, i) / fact;
                sum = sum + func;
            }
            func2 = (Math.Pow(p, k + 1) / (fact*(k-p))) * (1 - Math.Pow(p / k, m));
            pzero = 1 / (sum+func2);
            downTime = pzero * 60;
            Console.WriteLine("Probabilty that the channel is free -- P0 equal: " + pzero);
            Console.WriteLine("the downtime is " + downTime);
            Console.ReadKey(); 
        }
    }
}
