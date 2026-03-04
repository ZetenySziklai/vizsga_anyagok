using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_11_23_Metszet
{
    class Program
    {
        static int[] tomb = new int[13];
        static int[] tomb2 = new int[17];
        static int[] metszet;
        static int[] unio;
        static Random r = new Random();
        static void Main(string[] args)
        {
            TombFeltoltes(tomb);
            TombFeltoltes(tomb2);
            TombKiiratas(tomb);
            TombKiiratas(tomb2);
            Metszet(tomb, tomb2);
            TombKiiratas(metszet);
            Unio(tomb, tomb2);
            TombKiiratas(unio);

            Console.ReadLine();
        }

        static void Unio(int[] tomb1, int[] tomb2)
        {
            unio = new int[tomb1.Length+tomb2.Length];
            for (int i = 0; i < tomb1.Length; i++)
                unio[i] = tomb1[i];
            int k = tomb1.Length;
            for (int i = 0; i < tomb2.Length; i++)
            {
                if (!BenneVanE(unio, tomb2[i]))
                {
                    unio[k] = tomb2[i];
                    k++;
                }
            }
        }

        static void Metszet(int[] tomb1, int[] tomb2)
        {
            // Létrehozunk egy tömböt, aminek a hossza a kisebb tömb hosszával egyenlő
            int n = 0;
            if (tomb1.Length < tomb2.Length)
                n = tomb1.Length;
            else
                n = tomb2.Length;
            metszet = new int[n];
            // Metszet - a közös elemek kiszedése
            int k = 0;
            for (int i = 0; i < tomb1.Length; i++)
            {
                int a = tomb1[i];
                /*int j = 0;
                while (j < tomb2.Length && tomb2[j] != a)
                    j++;
                if (j < tomb2.Length)
                {
                    metszet[k] = a;
                    k++;
                }*/
                if (BenneVanE(tomb2, a))
                {
                    metszet[k] = a;
                    k++;
                }
            }

        }

        static void TombKiiratas(int[] tomb)
        {
            for (int i = 0; i < tomb.Length; i++)
                Console.Write(tomb[i] + " ");
            Console.WriteLine();
        }

        static void TombFeltoltes(int[] tomb)
        {
            int k = 0; //a kigenerált számok darabszámát mutatja.
            while (k < tomb.Length)
            {
                int a = r.Next(10, 31);
                //Eldöntés tétele - Megnézzük, hogy benne van-e a kigenerált szám a tömbbe!
                int j = 0;
                while (j < k && tomb[j] != a)
                    j++;
                if (j >= k)
                {
                    //Ha nincs benne a tömbbe a szám, akkor beleteszem, figyelve a tömb indexének változásra
                    tomb[k] = a;
                    k++;
                }
            }
        }

        static bool BenneVanE(int[] tomb, int a)
        {
            int i = 0;
            while (i < tomb.Length && tomb[i] != a)
            {
                i++;
            }
            bool vane = i < tomb.Length;
            return vane;
            //return i<tomb.Length;
        }
    }
}
