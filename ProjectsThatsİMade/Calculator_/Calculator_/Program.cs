using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_
{
    internal class Program
    {
        #region Metods
        static double TriangleP(double a, double b, double c)
        {

            double p = a + b + c;
            return p;   
        }
        static double TriangleA(double a, double b, double c)
        {
            double p = a + b + c;
            double area =Math.Sqrt(p*(p-a)*(p-b)*(p-c));
            return area;
        }
        static double RectangleP(double a, double b)
        {

            double p = (2*a)+(2*b);
            return p;
        }
        static double RectangleA(double a, double b)
        {

            double area = a*b;
            return area;
        }
        static double CircleA(double r)
        {

            double area = Math.PI * Math.Pow(r, 2);
            return area;
        }
        static double CircleP(double r)
        {

            double perimetr = 2*Math.PI* r;
            return perimetr;
        }
        static double SphereA(double r)
        {

            double area = 4*Math.PI*Math.Pow(r,2);
            return area;
        }
        static double SphereV(double r,double h)
        {

            double volume = (4/3) * Math.PI * Math.Pow(r, 3);
            return volume;
        }
        static double ConusA(double r, double h)
        {

            double area = Math.PI * r * (r*h);
            return area;
        }
         static double ConusV(double r,double h)
        {

            double volume = Math.PI * Math.Pow(r, 2) * (h / 3);
            return volume;
        }

        static double PyramidV(double a, double b, double h)
        {

            double volume = a * b * h / 3;
            return volume;
        }

        static double PyramidA(double a, double b, double h, double apofem)
        {

            double p = (a + b) / 2;
            double area = p * apofem / 2 + a * b;
            return area;
        }
        static double PyramidA(double p1, double p2, double h)
        {

            double area = ((p1 + p2) * h) / 2;
            return area;
        }
        static double ParalelipedA(double a, double b,double h)
        {

            double area = 2*(a*b* + a*h + b*h);
            return area;
        }
        static double ParalelipedV(double a, double b,double h)
        {

            double volume = a * b * h;
            return volume;
        }
        #endregion
        static void Main(string[] args)
        {
            Console.WriteLine("Which one you want to calculate");
            Console.WriteLine("1 Area");
            Console.WriteLine("2 Volume");
            Console.WriteLine("3 Go back");
        start1:
            int choose = int.Parse(Console.ReadLine());

            if (choose==1)
            {
                Console.WriteLine("enter the sides a and b");
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("enter the height of figure");
                double h = double.Parse(Console.ReadLine());
                Console.WriteLine($"Area of Paraleiped: {ParalelipedA(a, b, h)}");
                Console.ReadKey();
               
            }

            if (choose == 2)
            {
                Console.WriteLine("enter the sides a and b");
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("enter the height of figure");
                double h = double.Parse(Console.ReadLine());
                Console.WriteLine($"Volume of Paraleiped: {ParalelipedV(a, b, h)}");
                Console.ReadKey();
                

            }
            if(choose==3)
            {
                goto start1;
            }

        }
    }
}
