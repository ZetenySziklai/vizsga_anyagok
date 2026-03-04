using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_11_08_Metodusok
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Metódusok
             * fuggvenyek, eljárások, (konstruktor)
             * Függvények - Van visszatérési érték (return)
             * Eljárások - Függvény, aminek nincs visszatérési értéke.
               A main eljárásban csak eljárás meghívások lehetnek és billentyűzetre várás.
             */

            Feladat1();
            Console.WriteLine(Feladat2());

            Feladat3();

            Console.ReadLine();
        }

        static void Feladat3()
        {
            int a = 12;
            int b = 13;
            Kiiratas(a,b);
            Console.WriteLine("A két szám összege: " 
                +Osszeg(a,b));
        }

        static int Osszeg(int szam1, int szam2)
        {
            return szam1 + szam2;
        }

        static void Kiiratas(int szam1, int szam2)
        {
            Console.WriteLine("szam1 = {0}", szam1);
            Console.WriteLine("szam2 = {0}", szam2);
        }

        static void Feladat1()//eljárás
        {
            Console.WriteLine("Ez egy eljárás");
        }

        static string Feladat2()
        {
            return "Ez egy visszatérési értékkel rendelkező függvény";
        }

    }
}
