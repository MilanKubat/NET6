﻿using System;

namespace AhojSvete
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine();
            SoucetATisk(5, 46);
            Console.WriteLine("Jméno v 5. pádě:");
            var jmeno = Console.ReadLine();

            Pozdrav(jmeno);

            int a = -20;
            int b = 30;
            Console.WriteLine($"{a}, {b}");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"{a}, {b}");
            //Console.BackgroundColor = Consolecolor.
            Console.WriteLine($"{a}, {b} větší je: {Porovnej(a,b)}" );
        }

        static void SoucetATisk (int a, int b)
        {
            Console.WriteLine("Součet čísla {0} a čísla {1} je {2}", a, b, a + b);
        }

        static void Pozdrav(string Jmeno)
        {
            if (Jmeno == "Milane")
                Console.WriteLine($"Vítej zpátky, {Jmeno}!");
            else
                Console.WriteLine($"Zdravím tě, {Jmeno}!");
        }

        static int Porovnej(int a, int b)
        {
            if (a == 155 || a == 255)
                return b;
            else if (a > b)
            { 
                return a; 
            }
            else
            {     
                return b;
            }
        }
    }
}
