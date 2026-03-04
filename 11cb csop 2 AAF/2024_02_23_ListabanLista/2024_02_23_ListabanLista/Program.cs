using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_02_23_ListabanLista
{
    class Program
    {
        static List<List<int>> listak = new List<List<int>>();
        static void Main(string[] args)
        {
            ListakFeltoltese();
            ListakKiiratasa();

            // FVek
            // Adja meg hányadik lista a leghosszabb!
            // Adja meg azt a listát, amelyik tartalmaz 13-al osztható számot! Ha nincs írja ki, hogy nincs!
            // Adja meg a legkisebb elem indexét! (sorát és elemszámát)

            Console.WriteLine("{0}. lista a leghosszabb", LeghosszabbListaIndexe()+1);

            int szam =51;
            int index = VaneOszthatoSzamIndex(szam);
            if (index>-1)
                Console.WriteLine("Van benne {0}-val osztható szám, a {1}. listában", szam, index+1);
            else
                Console.WriteLine("Nincs benne {0}-val osztható szám", szam);



            Console.ReadLine();
        }

        static int VaneOszthatoSzamIndex(int szam)
        {
            bool vane = false;
            int i = 0;
            while (i < listak.Count && !vane)
            {
                //Ez egy lista: listak[i]
                vane = VanListabanSzam(listak[i], szam);
                if (!vane)
                    i++;
            }
            if (vane)
                return i;
            else
                return -1;
        }

        static bool VanListabanSzam(List<int> lista, int szam)
        {
            int i = 0;
            while (i < lista.Count && lista[i] % szam != 0)
                i++;
            return i < lista.Count;
        }

        static int LeghosszabbListaIndexe()
        {
            int maxi = 0;
            for (int i = 1; i < listak.Count; i++)
            {
                if (listak[i].Count > listak[maxi].Count)
                    maxi = i;
            }
            return maxi;
        }

        static void ListakKiiratasa()
        {
            for (int i = 0; i < listak.Count; i++)
            {
                for (int j = 0; j < listak[i].Count; j++)
                {
                    Console.Write(listak[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void ListakFeltoltese()
        {
            Random r = new Random();
            int sor = 6;
            //int[] elemszam = new int[] { 4, 7, 1, 3, 12, 4 };
            for (int i = 0; i < sor; i++)
            {
                List<int> segedLista = new List<int>();
                int elemszam = r.Next(5,12);
                segedLista.Clear();
                for (int j = 0; j < elemszam; j++)
                {
                    segedLista.Add(r.Next(10,100));
                }
                listak.Add(segedLista);
            }

        }
    }
}
