using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scientificnotiation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal h = Decimal.Parse("3.26873163612001E-10",System.Globalization.NumberStyles.Float | System.Globalization.NumberStyles.AllowExponent,System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine(h);
            Console.ReadLine(); 
        }
    }
}
