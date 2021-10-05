using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhojSvete
{
    class Cviceni
    {
        static public void Generace()
        {
            Console.WriteLine("Zadej rok narození");
            int rok = int.Parse(Console.ReadLine());
            if (rok < 1946) Console.WriteLine("Patříš do generace veteránů.");
            else if (rok < 1965) Console.WriteLine("Patříš do generace Baby Boomers.");
            else if (rok < 1981 ) Console.WriteLine("Patříš do generace Generation X.");
            else if (rok < 1997) Console.WriteLine("Patříš do generace Millenials.");
            else if (rok < 2013) Console.WriteLine("Patříš do generace Generation Z.");
            else Console.WriteLine("Patříš do generace Generation Alpha.");

        }
    }
}
