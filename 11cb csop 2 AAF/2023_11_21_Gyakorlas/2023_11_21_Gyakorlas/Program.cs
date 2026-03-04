using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_11_21_Gyakorlas
{
    class Program
    {
        static int[] szamok = new int[23];

        static void Main(string[] args)
        {
            // Töltsön fel egy tömböt az első 23 darab 7tel osztható számmal!
            // Majd keverje össze a tömb elemeit egy ön által választott algoritmussal!

            Tombfeltoltes(szamok);
            Tombkiiratas(szamok);
            Keveres(szamok);
            Tombkiiratas(szamok);

            Console.ReadLine();
        }

        static void Keveres(int[] tomb)
        {
            Random r = new Random();
            for (int i = 0; i < 200; i++)
            {
                int a = r.Next(0, tomb.Length);
                int b = r.Next(0, tomb.Length);
                Csere(ref tomb[a], ref tomb[b]);
                // tomb[a] érték típusú változó, az eljárás lefutása után, ha nem használok ref-et akkor nem a megváltoztatott értékkel dolgozik tovább.

                //Számold meg hány olyan csere történi, amikor a számot önmagával cseréli ki!
                
                // Házi feladat!Készítsen egy eljárást, ami feltölt egy 13 elemű tömböt [10,30] közötti számokkal úgy, hogy minden értékből csak egy legyen!

            }
        }

        static void Csere(ref int szam1, ref int szam2)
        {
            int sv = szam1;
            szam1 = szam2;
            szam2 = sv;
        }

        // Házi feladat a csere folyamatot kitenni külön eljárásba. Cserélje meg a két számot!

        static void Tombkiiratas(int[] tomb)
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write(tomb[i] + " ");
            }
            Console.WriteLine();
        }

        static void Tombfeltoltes(int[] tomb)
        {
            //int k = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = i * 7;
                //tomb[i] = k;
                //k += 7;
            }
        }

    }
}
