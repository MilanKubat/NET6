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
            Pozdrav("Milane");

            int a = 20;
            int b = 30;
            Console.WriteLine($"{a}, {b}");
            int c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine($"{a}, {b}");

        }

        static void SoucetATisk (int a, int b)
        {
            Console.WriteLine("Součet čísla {0} a čísla {1} je {2}", a, b, a + b);
        }

        static void Pozdrav(string Jmeno)
        {
            Console.WriteLine($"Zdravím tě, {Jmeno}!");
        }
    }
}
