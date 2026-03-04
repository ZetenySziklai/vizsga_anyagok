using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_10_19_Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu, a = 0, b = 0;
            bool megadott = false;
            do
            {
                MenuKiiratasa();
                menu = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                switch (menu)
                {
                    case 1:
                        KetSzamMegadasa(ref a,ref b);
                        megadott = true;
                        break;
                    case 2:
                        Osszeadas(a,b,megadott);
                        break;
                    case 3:
                        Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
                        break;
                    case 0:
                        Console.WriteLine("kilépés");
                        break;
                    default:
                        Console.WriteLine();
                        break;
                }
                Console.WriteLine("A folytatáshoz nyomjon egy entert!");
                Console.ReadLine();
            } while (menu != 0);
        /* HF
         * Menü:
         * 1. Feltölt egy 11 elemű tömböt [1,100]
         * 2. Megadja a számok átlagát! (Vizsgálat, csak feltöltés után)
         * 3. Megadja a legnagyobb szám helyét! */
        }

        static void Osszeadas(int a, int b, bool megadott)
        {
            if (!megadott)
                Console.WriteLine("Nem adott meg számot! Válassza ki először az 1. menüpontot!");
            else
                Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        }

        static void KetSzamMegadasa(ref int a2, ref int b2)
        {
            Console.WriteLine("Adjon meg két számot:");
            Console.Write("Szám 1: ");
            a2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Szám 2: ");
            b2 = Convert.ToInt32(Console.ReadLine());
        }

        static void MenuKiiratasa()
        // static - main eljárásban tudjuk használni
        // void - visszatérési érték nélküli függvény
        {
            Console.Clear();
            Console.WriteLine("1. - Két szám megadása");
            Console.WriteLine("2. - A két szám összege");
            Console.WriteLine("3. - A két szám szorzata");
            Console.WriteLine("0. - Kilépés");
            Console.Write("Adjon meg egy menüpontot: ");
        }
    }
}
