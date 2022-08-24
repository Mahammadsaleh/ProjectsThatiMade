using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conus
{
    class Conus
    {
        double height;
        double radius;
        double l;
        double volume;
        double totalArea;
        double leteralArea;
        double baseSurfaceArea;
        public double BaseSurfaceArea()
        {
            baseSurfaceArea = Math.PI * Math.Pow(radius, 2);
            return baseSurfaceArea;
        }
        public double SlantHeight()
        {
            l = Math.Sqrt((radius * radius) + (height * height));
            return l;
        }
        
        public double Volume()
        {
            volume = (Math.PI * Math.Pow(radius, 2) *height)/3;
            return volume;
        }
        public double LeteralArea()
        {
            leteralArea = Math.PI * radius * l;
            return leteralArea;    
        }
        public double ToltalArea()
        {
            totalArea =(Math.PI * radius * l) + (Math.PI * Math.Pow(radius, 2));
            return totalArea;
        }
        public Conus(double height, double radius)
        {
            this.height = height;
            this.radius = radius;
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("enter radius:");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("enter height:");
            double height = double.Parse(Console.ReadLine());
            Conus conus1 = new Conus(height, radius);
            Console.WriteLine($"Slant height: {conus1.SlantHeight()}\nLeteral Area: {conus1.LeteralArea()}\nVolume: {conus1.Volume()}\nTotal area: {conus1.ToltalArea()}\nBase surface area: {conus1.BaseSurfaceArea()}  ");
            Console.ReadKey();
        } 
    }
}
