using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int prod;
            int sum;
            int i;
            sum = 0;
            prod = 1;
            i = 1;
            for (;i <= 3;i=i+1)
            {
                sum = sum + i;   //0+1 1+2 3+3
                prod = prod * i;  //1*1 1*2 2*3
            }
            Console.WriteLine("Sum is " + sum);
            Console.WriteLine("Product is " + prod);
            //Random rand = new Random();
            //Console.WriteLine(rand.Next(1, 5));
            Console.ReadKey();


        }
    }
}
