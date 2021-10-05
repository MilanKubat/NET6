using System;

namespace AhojSvete
{
    class Program : TeplotyClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine();
            //SoucetATisk(5, 46);
            //Console.WriteLine("Jméno v 5. pádě:");
            //var jmeno = Console.ReadLine();

            //Pozdrav(jmeno);

            //TeplotyClass.Teploty();
            //Cviceni.Generace();
            //Cviceni.Dny();
            //Cviceni.Cykly();
            //Cviceni.SoucetRady();
            
            /*int a = -20;
            int b = 30;
            Console.WriteLine($"{a}, {b}");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"{a}, {b}");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"{a}, {b} větší je: {Porovnej(a,b)}" );*/
            
            
            
            Osoba O1 = new Osoba();
            Osoba O2 = new Osoba("Alice", "Nováková",36);

            O1.Jmeno = "Adam";
            O1.Prijmeni = "Novák";
            O1.Vek = 30;

            Console.WriteLine(O1);
            Console.WriteLine(O2);




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
