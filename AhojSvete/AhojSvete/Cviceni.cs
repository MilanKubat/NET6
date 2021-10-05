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

        static public void Dny()
        {
            Console.WriteLine("Zadej číslo dne");
            string den;
            int cislo = int.Parse(Console.ReadLine());

            switch (cislo)
            {
                case 1:
                    den = "Pondělí";
                    break;
                case 2:
                    den = "Úterý";
                    break;
                case 3:
                    den = "Středa";
                    break;
                case 4:
                    den = "Čtvrtek";
                    break;
                case 5:
                    den = "Pátek";
                    break;
                case 6:
                case 7:
                    den = "VOLNO!";
                    break;
                default:
                    den = "Takový den neexistuje!";
                    break;
            }
            Console.WriteLine($"{cislo} odpovídá dnu v týdnu: {den}");
        }

        static public void Cykly()
        {
            int cislo = 0;
            while (cislo == cislo / 2 * 2)
            {
                Console.WriteLine("Zadej číslo");
                cislo = int.Parse(Console.ReadLine());
                Console.WriteLine(cislo);
            }

        }
    }
}
