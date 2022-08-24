using System;
class HelloWorld
{
    static void Main()
    {
        Console.Write("How many times you want to retry this loop:");
        double n = Int32.Parse(Console.ReadLine());
        for (int i = 0; i <= n; i++)
        {
            Console.Write("Enter X:");
            double X = Int32.Parse(Console.ReadLine());
            Console.Write("Enter Y:");
            double Y = Int32.Parse(Console.ReadLine());
            Console.Write("Enter I(Color Depth):");
            double I = Int32.Parse(Console.ReadLine());
            double ans = X * Y * I;
            double ans2 = ans / 8;
            if (ans2 / 1024 >= 1)
            {
                double ans3 = ans2 / 1024;
                if (ans3 / 1024 >= 1)
                {
                    double ans4 = ans3 / 1024;
                    if (ans4 / 1024 >= 1)
                    {
                        double ans5 = ans4 / 1024;
                        Console.Write("Answer is:{0}GB", ans5);
                    }
                    else
                    {
                        Console.Write("Answer is:{0}MB", ans4);
                    }
                }
                else
                {
                    Console.Write("Answer is:{0}KB", ans3);
                }
            }
            else
            {
                Console.Write("Answer is:{0}bytes", ans2);
            }
            Console.Write("\n");
        }
    }
}