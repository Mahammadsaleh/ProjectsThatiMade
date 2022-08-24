using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            int r = 6;
            for(int i = 0; i < r; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("***");


            for (int i = 0; i < r-3; i++)
            {
                Console.Write(" ");
            }
            Console.Write("*");
            for (int i = 0; i < r+1; i++)
            {
                Console.Write(" ");
            }
            Console.Write("*");
            Console.WriteLine();
            for (int i = 0; i < r - 5; i++)
            {
                Console.Write(" ");
            }
            Console.Write("*");
            for (int i = 0; i < r+5; i++)
            {
                Console.Write(" ");
            }
            Console.Write("*");
            Console.WriteLine();
            for (int i = 0; i < r - 5; i++)
            {
                Console.Write(" ");
            }
            Console.Write("*");
            for (int i = 0; i < r + 5; i++)
            {
                Console.Write(" ");
            }
            Console.Write("*");
            Console.WriteLine();
            for (int i = 0; i < r - 3; i++)
            {
                Console.Write(" ");
            }
            Console.Write("*");
            for (int i = 0; i < r + 1; i++)
            {
                Console.Write(" ");
            }
            Console.Write("*");
            Console.WriteLine();
            for (int i = 0; i < r; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("***");

            Console.ReadKey();
        }
    }
}
