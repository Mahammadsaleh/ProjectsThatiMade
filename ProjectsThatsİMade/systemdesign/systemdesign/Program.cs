using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace systemdesign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double k, lamda, t, alfa, p, sum, fact, func, pzero,prejected,downTime;
            Console.WriteLine("enter the count of communication lines: ");
            k = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the lamba: ");
            lamda = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the time: ");
            t = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the alfa: ");
            alfa = double.Parse(Console.ReadLine());
            p = lamda * t;
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
            downTime = pzero * 60;
            Console.WriteLine("Probabilty that the channel is free -- P0 equal: "+pzero);
            Console.WriteLine("probability that all communication lines are busy (rejected app): "+prejected);
            Console.WriteLine("the downtime is "+downTime);
            double relative, absolute,averageNumOfBusy,averageQSDownTime;
            relative = 1 - prejected;
            absolute = relative * lamda;
            averageNumOfBusy = p * relative;
            averageQSDownTime = prejected * t;
            Console.WriteLine("Relative throughput: "+relative);
            Console.WriteLine("Absolute throughput: "+absolute);
            Console.WriteLine("Average number of busy communication lines: "+averageNumOfBusy);
            Console.WriteLine("Average QS downtime: "+averageQSDownTime);
            Console.ReadKey();
        }
    }
}
