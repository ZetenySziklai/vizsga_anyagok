using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_09_13_Random_Math
{
    class Program
    {
        static void Main(string[] args)
        {
            // Random - véletlen szám generálás

            Random r = new Random();
            /* r.Next() - int intervallumából
               r.Next(a) - [0,a[
               r.Next(a,b) - [a,b[
               r.NextDouble() - [0,1[*/
            Console.WriteLine("Egész [-20,30]: " + r.Next(-20,31));
            Console.WriteLine("Tört [0,1[: " + r.NextDouble());

            int a = r.Next(-10, 10);
            Console.WriteLine("Szám: " + a);
            Console.WriteLine("Abszolut érték: " + Math.Abs(a));
            Console.WriteLine("Gyökvonás: " + Math.Sqrt(a));
            Console.WriteLine("Hatványozás: köbre emelés: " + Math.Pow(a, 3));
            Console.WriteLine("Sin(a): " + Math.Sin(a));
            Console.WriteLine("Pi: " + Math.PI);
            Console.WriteLine("~Pi: " + Math.Ceiling(Math.PI)); // Felfele kerekítés
            Console.WriteLine("~Pi: " + Math.Floor(Math.PI)); // Lefele kerekítés
            Console.WriteLine("~Pi: " + Math.Round(Math.PI,1)); // Matematikai szabályoknak megfelelő kerekítés

            // HF [10,20] tört számot generálni megjelenítésben 2 tizedesjeggyel
            



            Console.ReadLine();
        }
    }
}
