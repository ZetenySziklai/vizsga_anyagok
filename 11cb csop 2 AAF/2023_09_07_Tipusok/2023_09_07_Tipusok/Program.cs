using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_09_07_Tipusok
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Változók és típusok");

            /* Elemi Típusok
             * Számok:
             *   int - egész (4B)
             *   byte, short, long - egész
             *   double - tört (lebegőpontos számok)
             *   float - tört
             * Szöveg
             *   string - karakterlánc - "szöveg"
             * karakter
             *   char - 1 db karakter érték - 'c'
             * logikai
             *   bool - boolen - true, false
             */
            // Változók deklarálása - létrehozása, definiálása
            // típus változó_név;
            // inicializálás - kezdőérték adása
            // típus változó_név = érték;

            //Egész szám
            int a;
            //int a = 13;
            a = 13;
            Console.WriteLine("Egész szám: "+a);

            //Tört szám
            double tort = 21.4;
            // kezdőértéknél: 21.4
            // kiíratásnál: 21,4
            // bekérésnél: 21,4

            Console.WriteLine("Tört szám: "+tort);

            // Konkatenálás - szövegek összefűzése
            // Plusz operátor (összeg jel)
            // szöveg + szöveg vagy szöveg + érték

            // Szöveg
            string sz = "beégetett adat";

            // Karakter
            char c = 'h';

            // Logikai
            bool logikai = true; // false

            //Házi feladat a változók kiíratása megadott szöveggel összefűzve


            //Operátorok
            // aritmetikai
            int b = 11;
            int d = 21;
            Console.WriteLine(b + " " + d);
            Console.WriteLine("Összeadás: "+(b+d));
            Console.WriteLine("Kivonás: "+(b-d));
            Console.WriteLine("Szorzás: "+b*d);
            Console.WriteLine("Osztás: "+b/d);
            Console.WriteLine("Maradék: "+b%d);
            // b += 1; b = b + 1; b++;
            //b++;
            //++b;
            Console.WriteLine("Értéknövelő: "+ ++b);
            Console.WriteLine("Értéknövelő: " + b);
            //d -=1; d = d - 1;
            d--;
            Console.WriteLine("Értékcsökkentő: "+d);

            // +=, -=, *=, /=, %=

            //Logikai operátorok
            //és - and - && (altGr + c)
            //vagy - or - || (altGr + w)
            //not - !

            // Bitenkénti műveletek: és &, vagy |,
            // xor ^, not ~
            // xor - kizáró vagy

            Console.WriteLine("46 & 25 = " + (46 & 25));

            // Relációk
            // ==, !=, <, <=, >, >=

            //random, math


            Console.ReadLine();
        }
    }
}
