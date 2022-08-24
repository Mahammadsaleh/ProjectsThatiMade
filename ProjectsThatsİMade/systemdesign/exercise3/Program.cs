using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double k, lamda, t, mu, p, sum, fact, func, pzero,prejected;
            Console.WriteLine("enter the count of communication lines: ");
            k = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the lamba: ");
            lamda = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the time: ");
            t = double.Parse(Console.ReadLine());
            
            mu = 1 / t;
            p = lamda /mu;
            Console.WriteLine("Intensity equal: "+p);
            sum = 1;
            fact = 1;
            for (int i = 1; i < k + 1; i++)
            {
                fact = fact * i;
                func = Math.Pow(p,i) / fact;
                sum = sum + func;
            }
            pzero = 1/sum;
            prejected = (Math.Pow(p, k) / fact) * pzero;
            Console.WriteLine("(Probability of failure) probability that all communication lines are busy (rejected app): " + prejected);
            Console.WriteLine("(The average proportion of time during which the telephone exchange is not loaded at all) Probabilty that the channel is free -- P0 equal: " + pzero);
           
            Console.ReadKey();
        }
    }
}
