using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_10_12_Tomb
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Tömb - Array
             * típus[] tömb_név; - deklarálás, létrehozás
             * típus[] tömb_név = new típus[elemszám]; - példányosítás
             * pl.
             * int[] szamok = new int[11];
             * string[] honapok = new int[12];
             * 
             * int[] szamok = new int[]{1,5,2,4,3,5,6,2,3,4};
             * string[] napok = new string[]{"hétfő",  "kedd", "szerda",...};
             */
            

            // Töltsön fel egy 100 elemű tömböt [1,6] közötti
            // véletlen számokkal!

            Random r = new Random();
            int[] szamok = new int[100];
            for (int i = 0; i < szamok.Length; i++)
            {
                /*int rnd = r.Next(1, 7);
                szamok[i] = rnd;*/
                szamok[i] = r.Next(1, 7);
            }
            //Console.WriteLine(szamok);
            for (int i = 0; i < szamok.Length; i++)
            {
                Console.Write(szamok[i] + " ");
            }

            int db = 0;
            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i] == 5)
                {
                    db++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("{0} db 5ös szám van.", db);

     
            Console.WriteLine("Adjon meg egy számot 1-6 között");
            int bekertSzam = Convert.ToInt32(Console.ReadLine());
            while (bekertSzam < 1 || bekertSzam>6)
            {
                Console.WriteLine("Rossz számot adott meg. Ajon egy újat 1-6 között: ");
                bekertSzam = Convert.ToInt32(Console.ReadLine());
            }

            db = 0;
            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i] == bekertSzam)
                    db++;
            }
            Console.WriteLine("{0} számból {1} darab van.", bekertSzam, db);
            // Kíváncsiak vagyunk az összes értékre
            // Írassa ki egymás alá az összes dobott érték darabszámát!

            // Hf egy ciklussal és egy változóval old meg!
            // HF 26-33

            Console.ReadLine();
        }
    }
}
