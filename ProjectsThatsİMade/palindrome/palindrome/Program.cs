using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, reverse, sum = 0, test;
            Console.Write("Enter the Number: ");
            num = int.Parse(Console.ReadLine());
            test = num;
            while (num > 0)
            {
                reverse = num % 10;  // 121 % 10 =1  12%10 = 2  1
                sum = (sum * 10) + reverse; // sum=1 sum= 12  120+1
                num = num / 10; // num= 12 num= 1 n=0
            }
            if (test == sum)
                Console.Write("Number is Palindrome.");
            else
                Console.Write("Number is not Palindrome");
            Console.ReadKey();
        }
    }
}
