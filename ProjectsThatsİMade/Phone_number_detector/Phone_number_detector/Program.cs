using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_number_detector
{
    internal class Program
    {
        public static string PhoneNumberEntering2ndPhase(string[,] operatorInAze)
        {
            Console.WriteLine("Please enter your phone number.");
            string phoneNumber = Console.ReadLine();
            for (int i = 0; i < operatorInAze.Length-1; i++)
            {
                if (phoneNumber.StartsWith(operatorInAze[i, 0]))
                {
                    Console.WriteLine(operatorInAze[i, 1]);
                    break;
                }
            }
            return phoneNumber;
        }
        static void Main(string[] args)
        {
            string phoneNumber="";
            string[,] operatorInAze = new string[,]
            {
                {"050", "Azercell"},
                {"051", "Azercell"},
                {"055", "Bakcell"},
                {"099", "Bakcell"},
                {"070", "Nar"},
                {"077", "Nar"},
            };
            Console.WriteLine("Firstly enter your country code");
            string countryCode = Console.ReadLine();
            switch (countryCode)
            {
                case "+994":
                    Console.WriteLine("Your Region is Azerbaijan");
                    phoneNumber=PhoneNumberEntering2ndPhase(operatorInAze);
                    break;
                case "+90":
                    Console.WriteLine("Your Region is Turkey");
                    break;

            }
            string finalNum = string.Concat(countryCode,phoneNumber);
            Console.WriteLine("your final num is: "+finalNum);
            Console.ReadKey();
        }

        
        
    }
}
