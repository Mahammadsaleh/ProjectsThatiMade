using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalFunc
{
    internal class Program
    {
        public static void Main()
        {
            void ProdValue(int a, int b)
            {
                Console.WriteLine("Value of a is: " + a);
                Console.WriteLine("Value of b is: " + b);
                Console.WriteLine("Product of a and b is: {0}", a * b);
                Console.WriteLine();
            }

            // Calling Local function
            ProdValue(20, 40);
     
            List<int> numbers = new List<int>() {36, 71, 12, 15, 29, 18, 27, 17, 9, 34};
            Console.Write("The list : ");
            foreach (var value in numbers)
            {
                Console.Write("{0} ", value);
            }
            Console.WriteLine();

            var square = numbers.FindAll(x => x%2==0);

            foreach (var value in square)
            {
                Console.Write("{0} ", value);
            }
    
            Console.ReadKey();
        }

       
    }
}
