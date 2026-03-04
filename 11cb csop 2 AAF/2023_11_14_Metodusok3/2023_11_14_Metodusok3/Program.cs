using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_11_14_Metodusok3
{
    class Program
    {

        static int[] tomb1;
        static int[] tomb2;
        static Random r = new Random();

        static void Main(string[] args)
        {
            /* Töltsön fel két [10,99] közötti véletlen számú tömböt [1,200] közötti számokkal, ehhez írjon egy tömbfeltöltés eljárást, úgy a folyamat függjön egy bemeneti tömb értékétől!
             * Írjon egy függvényt, amit kiszámolja egy tömb átlagát! (kerekítés nélkül) Majd írassa ki a tömbök átlagát 2 tizedesjegyre kerekítve!
             * Írjon egy megszámlálás metódust, ami megadja hány darab átlagtó kisebb szám van!*/


            Feladat1();



            Console.ReadLine();
        }

        static void Feladat1()
        {
            //Random r = new Random();
            int db1 = r.Next(10, 100);
            tomb1 = new int[db1];
            int db2 = r.Next(10, 100);
            tomb2 = new int[db2];

            Tombfeltoltes(tomb1);
            Tombfeltoltes(tomb2);

            TombKiir(tomb1);
            TombKiir(tomb2);
        }

        static void TombKiir(int[] tomb)
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write(tomb[i] + " ");
            }
            Console.WriteLine();
        }

        static void Tombfeltoltes(int[] tomb)
        {            
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = r.Next(1, 201);
            }
        }
    }
}
