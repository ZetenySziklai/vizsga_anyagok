using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_01_11_GyakorlasKockadobas
{
    class Program
    {
        static List<int> kockadobasok = new List<int>();
        static int[] statisztika = new int[6];

        static void Main(string[] args)
        {
            /* Szimuláljunk egy kockadobást és nézzük meg, hogy tényleg egyenlő valószínűséggel dobjuk ki a számokat!
             * Metódus: Feltölt egy n elemű listát kockadobással (6 oldalú kocka)!
             * Metódus: Egy szám hányszor fordult elő a dobások alkalmával!
             * Feladat1: 10 dobásonként, hogyan alakulnak a számok! 
             * Feladat2: Készítsen egy diagrammot a megjelenítéshez!*/


            ListaFeltoltes();
            //StatisztikaKeszites();
            //TombKiiratas();

            KoordinataRendszer();
            Szimulalas();

            // HF Másik diagram, mási intervallummal

            Console.ReadLine();

        }

        static void Szimulalas()
        {
            List<int> aktDobasok = new List<int>();
            // végignézzük az összes dobást egyesével
            for (int i = 0; i < kockadobasok.Count; i++)
            {
                aktDobasok.Add(kockadobasok[i]);
                if (i % 10 == 0)
                {
                    //1000 ms = 1 sec;
                    System.Threading.Thread.Sleep(100);
                    Console.Clear();
                    int[] aktStat = StatisztikaKeszites(aktDobasok);
                    TombKiiratas(aktStat);
                    KoordinataRendszer();
                    DiagramAbrazolas(aktStat);
                }
            }
        }

        static void DiagramAbrazolas(int[] aktStat)
        {
            int maxe = Maximum(aktStat);
            int mine = Minimum(aktStat);
            //double intervall = (double)maxe / 10;
            double intervall = (double)(maxe-mine) / 10;
            for (int j = 0; j < 6; j++)
            {
                //double db = (aktStat[j] ) / intervall + 1;
                double db = (aktStat[j] -mine ) / intervall + 1;
                for (int i = 0; i < db; i++)
                {
                    Console.SetCursorPosition(7 + (j * 2), 14 - i);
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Write(" ");
                }
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }

        static void DiagramAbrazolas()
        {
            int maxe = Maximum();
            int mine = Minimum();
            double intervall =(double) (maxe - mine) / 10;
            for (int j = 0; j < 6; j++)
            {
                //int db = statisztika[j];
                double db = (statisztika[j]-mine)/intervall+1;
                for (int i = 0; i < db; i++)
                {
                    Console.SetCursorPosition(7+(j*2), 14 - i);
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Write(" ");
                }
            }

            /*int egyesDb = statisztika[0];
            for (int i = 0; i < egyesDb; i++)
            {
                Console.SetCursorPosition(7, 14-i);
                Console.Write("X");
            }
            int kettesDb = statisztika[1];
            for (int i = 0; i < kettesDb; i++)
            {
                Console.SetCursorPosition(9, 14 - i);
                Console.Write("X");
            }*/
        }

        static int Minimum(int[] aktStat)
        {
            int me = aktStat[0];
            for (int i = 1; i < aktStat.Length; i++)
                if (me > aktStat[i])
                    me = aktStat[i];
            return me;
        }
        static int Minimum()
        {
            int me = statisztika[0];
            for (int i = 1; i < statisztika.Length; i++)
                if (me > statisztika[i])
                    me = statisztika[i];
            return me;
        }

        static int Maximum(int[] aktStat)
        {
            int me = aktStat[0];
            for (int i = 1; i < aktStat.Length; i++)
                if (me < aktStat[i])
                    me = aktStat[i];
            return me;
        }
        static int Maximum()
        {
            int me = statisztika[0];
            for (int i = 1; i < statisztika.Length; i++)
                if (me < statisztika[i])
                    me = statisztika[i];
            return me;
        }

        static void KoordinataRendszer()
        {
            Random r = new Random();
            // y - vertikális tengely
            for (int i = 0; i < 10; i++)
            {
                Console.SetCursorPosition(5,5+i);
                Console.Write("|");
            }
            // x - horizontális tengely
            for (int i = 0; i < 20; i++)
            {
                Console.SetCursorPosition(i, 15);
                Console.Write("-");
            }
            // x tengely megjelölése
            for (int i = 1; i < 7; i++)
            {
                Console.SetCursorPosition(5 + (i * 2), 16);
                Console.Write(i);
            }

        }

        static void TombKiiratas(int[] aktStat)
        {
            for (int i = 0; i < aktStat.Length; i++)
                Console.Write(aktStat[i] + " ");
        }

        static void TombKiiratas()
        {
            for (int i = 0; i < statisztika.Length; i++)
                Console.Write(statisztika[i] + " ");
        }

        static int[] StatisztikaKeszites(List<int> aktDobasok)
        {
            int[] aktStatisztika = new int[6];
            for (int i = 0; i < aktDobasok.Count; i++)
            {
                int index = aktDobasok[i] - 1;
                aktStatisztika[index]++;
            }
            return aktStatisztika;
        }

        static void StatisztikaKeszites()
        {
            // 123456
            // 012345
            for (int i = 0; i < kockadobasok.Count; i++)
            {
                int index = kockadobasok[i] - 1;
                statisztika[index]++;
            }
        }

        static void ListaFeltoltes()
        {
            Console.Write("Adja meg hány dobást szimuláljunk: ");
            int n = Convert.ToInt32(Console.ReadLine());
            DobasokGeneralasa(n);
        }

        static void DobasokGeneralasa(int n)
        {
            Random r = new Random();
            for (int i = 0; i < n; i++)
                kockadobasok.Add(r.Next(1, 7));
        }
    }
}
