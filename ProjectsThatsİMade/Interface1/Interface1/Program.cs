using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1
{
    interface IShape
    {
        void name();
        int width();
        int height();
        int Area();
        int Perimetr();
    }

    class RightTriange: IShape
    {
        public void name()
        {
            Console.WriteLine("Triange");
        }
        public int width() { return 4; }
        public int height() { return 3; }
        public int Area() 
        {
            int result = width() * height() / 2;
            return result; 
        }
        public int Perimetr()
        {
            double hipotenuse = Math.Sqrt((width()*width()) + (height()*height()));
            int result = width()+height()+(int)hipotenuse;
            return result;
        }

    }

    internal class Program
    {
       
        static void Main(string[] args)
        {
           RightTriange rightTriange = new RightTriange();
            rightTriange.name();
            Console.WriteLine(rightTriange.Area());
            Console.WriteLine(rightTriange.Perimetr());
            Console.ReadKey();  
        }
    }
}
