using System;

namespace Kalkulačka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ahoj, Tohle je Jednoduchá Kalkulačka");
            Console.WriteLine("Napiš první číslo");
            //uděláme proměnné
            string cislo1 = Console.ReadLine();
            double a = Convert.ToDouble(cislo1);
            Console.WriteLine("Napiš druhé číslo");
            string cislo2 = Console.ReadLine();
            double b = Convert.ToDouble(cislo2);
            //zadáme co proměnné budou dělat
            double c;
            double d;
            double e;
            double f;
            c = a + b;
            d = a - b;
            e = a * b;
            f = a / b;
            //vypíšeme proměnné
            Console.WriteLine("Zde jsou výsledky");
            Console.WriteLine("Scítání" + c);
            Console.WriteLine("Odčítaní" + d);
            Console.WriteLine("Násobení" + e);
            Console.WriteLine("Dělení" + f);
            Console.WriteLine("Děkuji za použití ");
            //ukončíme program
            Console.ReadKey();








        }
    }
}
