using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nNotation
{
    internal class Program
    {
        public static int findMax(int[] arr)
        {
            if (arr.Length == 0)
            {
                throw new Exception("Array is empty");
            }
            int max = int.MinValue;
            foreach (var i in arr)
            {
                if (i > max)
                {
                    max = i;
                }
            }
            return max;
        }

        public static void Main()
        {
            // Linear notation (n)
            int[] arr = { 8, 3, 5, -1, 2 };
            Console.WriteLine("Maximum number is " + findMax(arr));
        }
    }
}
