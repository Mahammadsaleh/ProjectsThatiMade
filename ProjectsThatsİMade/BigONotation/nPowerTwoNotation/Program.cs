using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nPowerTwoNotation
{
    internal class Program
    {
        //N Power2 notation
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 9, 6, 7, 5, 9 };
            int temp;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }
            Console.ReadKey();
        }
    }
}
