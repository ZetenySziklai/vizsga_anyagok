using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_01_10_ListaMetszetUnio
{
    class Program
    {
        static List<int> szamok1 = new List<int>();
        static List<int> szamok2 = new List<int>();
        static Random r = new Random();

        static void Main(string[] args)
        {
            /* Készítsen egy eljárást, aminek a paramétere egy egész szám és egy lista. Az eljárás töltse fel a paraméterben megadott listát a paraméterben megadott darabszámmal!
             * Készítsen egy eljárást, ami kigyűjti a két lista közös elemeit! (Metszet)
             * Készítsen egy eljárást, ami kigyűjti a két lista összes elemét! (Unio)
             * Módosítsa a lista feltöltést úgy, hogy csak egy szám egyszer szerepeljen a listában!
             */

            ListaFeltoltese(20, szamok1);
            ListaFeltoltese(17, szamok2);
            ListaKiir(szamok1);
            ListaKiir(szamok2);
            Metszet(szamok1, szamok2);

            Console.ReadLine();
        }

        static void Metszet(List<int> sz1, List<int> sz2)
        {
            List<int> metszet = new List<int>();
            for (int i = 0; i < sz1.Count; i++)
            {
                int a = sz1[i];
                if (BenneVanE(sz2, a))
                {
                    metszet.Add(a);
                }
            }
            ListaKiir(metszet);
        }

        static bool BenneVanE(List<int> lista, int a)
        {
            int i = 0;
            while (i < lista.Count && lista[i] != a)
            {
                i++;
            }
            return i < lista.Count;
        }

        static void ListaFeltoltese(int n, List<int> lista)
        {            
            for (int i = 0; i < n; i++)
            {
                lista.Add(r.Next(0, 25));
            }
        }

        static void ListaKiir(List<int> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                Console.Write(lista[i] + " ");
            }
            Console.WriteLine();
        }

    }
}
