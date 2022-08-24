using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Names
{

    // declaring enum
    public enum name
    {
        Mahammad,
        Abbas
    }

    public void FindName(name s1)
    {
        if (s1 == 0)
        {
            Console.WriteLine("This is name" );
        }
        else
        {
            Console.WriteLine("This is surname" );
        }
    }
}

class Program
{

    // Main Method
    static void Main(string[] args)
    {

        Names a1 = new Names();
        a1.FindName(Names.name.Mahammad);
        a1.FindName(Names.name.Abbas);
        Console.ReadKey();
    }
}

