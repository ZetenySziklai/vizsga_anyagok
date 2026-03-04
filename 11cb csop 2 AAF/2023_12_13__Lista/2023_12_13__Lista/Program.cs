using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_12_13__Lista
{
    class Program
    {
        static List<int> szamok = new List<int>();
        static void Main(string[] args)
        {
            /* Lista
             * List<típus> lista_neve;
             * List<típus> lista_neve = new List<típus>();
             * lista_neve.Add(érték); - érték hozzáadása, lista végére kerül az elem.
             * lista_neve.Count - elemszám meghatározása
             * lista_neve.Remove(érték) - a listából az első olyan értéket, amivel megegyezik.
             * lista_neve.RemoveAt(index) - az adott indexen lévő értéket kitörli a listából. */

            //ListaAlapok();

            // 1. Eljárás: Feltölti a listát egy a felhasználó által bekért elemszámmal a számok [10,50] közöttiek legyenek!
            // 2. Eljárás: Hívjon meg egy ön által megírt függvényt, ami megadja a számok összegét!
            // 3. Eljárás: Hívjon meg egy ön által megírt függvényt, ami megadja a lekisebb szám indexét!
            // 4. Eljárás: Hívjon meg egy ön által megírt függvényt, ami megadja a paraméterben szereplő szám indexét, ha benne van a listában ha nincs akkor (-1)-et adjon vissza!
            // 5. Eljárás: Ami rendezi a lista elemeit csökkenő sorrendben!
            // 6. Van-e ismétlődő elem a listában. (működjön a nem rendezett listára is)
            // Extra: Függvény: Adja meg a számok móduszát 200 elemre nézve!


            Feltolteltes(szamok, 5);
            Kiiratas(szamok);
            Feladat2();
            Feladat3();
            Feladat4();
            Feladat5();
            Feladat6();

            Console.ReadLine();
        }

        static void Feladat6()
        {
            Console.WriteLine("6. feladat");
            if (VaneIsmetlodoElem(szamok))
                Console.WriteLine("Van benne ismétlődés");
            else
                Console.WriteLine("Nincs benne ismétlődés");
        }

        static bool VaneIsmetlodoElem(List<int> lista)
        {
            int i = 0;
            bool vane = false;
            while (i < lista.Count - 1 && !vane)
            {
                int j = i + 1;
                while (j < lista.Count && lista[i] != lista[j])
                    j++;
                if (j < lista.Count)
                    vane = true;
                else
                    i++;
            }
            return vane;
        }

        static void Feladat5()
        {
            Console.WriteLine("5. feladat");
            Console.WriteLine("A rendezett lista: ");
            ListaRendezese(szamok);
            Kiiratas(szamok);
        }

        static void ListaRendezese(List<int> szamok)
        {
            for (int i = 1; i < szamok.Count; i++)
            {
                for (int j = i ; j > 0; j--)
                {
                    if (szamok[j] < szamok[j-1])
                    {
                        int sv = szamok[j] ;
                        szamok[j] = szamok[j-1];
                        szamok[j-1] = sv;
                    }
                }
            }
        }

        static void Feladat4()
        {
            Console.WriteLine("4. feladat");
            int szam = 26;
            Console.WriteLine("Van-e {0} szám a listában: {1}" , szam, VaneListabanSzam(szamok, szam));
        }

        static int VaneListabanSzam(List<int> lista, int a)
        {
            int i = 0;
            while (i < lista.Count && lista[i] != a)
                i++;
            //bool vane = i < lista.Count;
            if (i < lista.Count)
                return i;
            else
                return -1;
        }

        static void Feladat3()
        {
            Console.WriteLine("3. feladat");
            int index = MinimumIndex(szamok);
            Console.WriteLine("A legkisebb szám helye: " + (index + 1));
        }

        static int MinimumIndex(List<int> lista)
        {
            int mini = 0;
            for (int i = 1; i < lista.Count; i++)
            {
                if (lista[i] < lista[mini])
                    mini = i;
            }
            return mini;
        }

        static void Feladat2()
        {
            Console.WriteLine("2. feladat");
            Console.WriteLine("A számok összege: " + ListaSum(szamok));
        }

        static int ListaSum(List<int> lista)
        {
            int osszeg = 0;
            for (int i = 0; i < lista.Count; i++)
                osszeg += lista[i];
            return osszeg;
        }

        static void Feltolteltes(List<int> lista, int n)
        {
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                lista.Add(r.Next(10, 51));
            }
        }


        static void ListaAlapok()
        {
            List<int> lista = new List<int>();
            lista.Add(2);
            Console.WriteLine("első elem: "+lista[0]);
            lista.Add(13);
            lista.Add(7);
            lista.Add(11);
            Console.WriteLine("a lista elemszáma: " + lista.Count);
            Console.WriteLine("a lista utolsó eleme: " + lista[lista.Count-1]);
            Kiiratas(lista);

            if (lista.Remove(13))
            {
                lista.Add(16);
            }
            Kiiratas(lista);

            lista.RemoveAt(3);
            Kiiratas(lista);

        }

        static void Kiiratas(List<int> lista)
        {
            for (int i = 0; i < lista.Count; i++)
                Console.Write(lista[i] + " ");
            Console.WriteLine();
        }

    }
}
