using System;

namespace AhojSvete
{
    
    class TeplotyClass
    {

        static double PrevodTeplot(string stFtext)
        {
            double stF = double.Parse(stFtext);
            return Math.Round((stF - 32) * 5 / 9, 2);
        }
        
        public static void Teploty()
        {
            Console.WriteLine("Převod teploty");
            Console.WriteLine("--------------");
            Console.WriteLine();
            Console.WriteLine("Zadej teplotu ve °F:");


            Console.WriteLine($"Tak to je ve °C: {PrevodTeplot(Console.ReadLine())}");
        }
    }
}