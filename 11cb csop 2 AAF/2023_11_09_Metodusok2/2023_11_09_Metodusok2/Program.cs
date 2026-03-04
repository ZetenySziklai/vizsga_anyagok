using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_11_09_Metodusok2
{
    class Program
    {
        static string szoveg;

        static void Main(string[] args)
        {
            SzovegBekerese();
            FeladatA();
            FeladatB();
            FeladatC();

            Console.ReadLine();
        }

        static void FeladatC()
        {
            Console.WriteLine("Adja meg hány darab számmal dolgozzunk: ");
            int n = Convert.ToInt32(Console.ReadLine());
            //int[] tomb = new int[n];
            //Tombfeltoltes(tomb, n);
            int[] tomb = TombFeltoltes(n);
            TombKiiratas(tomb);
        }

        static void TombKiiratas(int[] tomb)
        {
            for (int i = 0; i < tomb.Length; i++)
                Console.Write(tomb[i] + " ");
            Console.WriteLine();
        }

        static void Tombfeltoltes(int[] tomb , int n)
        {
            Random r = new Random();
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = r.Next(10, 101);
            }
        }

        static int[] TombFeltoltes(int db)
        {
            int[] t = new int[db];
            Random r = new Random();
            for (int i = 0; i < db; i++)
                t[i] = r.Next(10, 101);
            return t;
        }

        static void FeladatB()
        {
            Console.WriteLine("\nA szöveg megfordítva: ");
            string megforditott = SzovegMegforditas(szoveg);
            Console.WriteLine(megforditott);
        }

        static string SzovegMegforditas(string szoveg)
        {
            string ujszoveg = "";
            for (int i = 0; i < szoveg.Length; i++)
            {
                //ujszoveg = szoveg[i] + ujszoveg;,
                ujszoveg += szoveg[szoveg.Length - i - 1];
            }
            return ujszoveg;
        }

        static void FeladatA()
        {
            Console.WriteLine("\nA szöveg szóköz nélkül: ");
            string szokoztelenitett = Szokoztelenites(szoveg);
            Console.WriteLine(szokoztelenitett);
        }

        static string Szokoztelenites(string szoveg)
        {
            string ujszoveg = "";
            for (int i = 0; i < szoveg.Length; i++)
            {
                if (szoveg[i] != ' ')
                    ujszoveg += szoveg[i];
            }
            return ujszoveg;
        }

        static void SzovegBekerese()
        {
            Console.WriteLine("Adjon meg egy szöveget, az átalakításokhoz: ");
            szoveg = Console.ReadLine();
        }
    }
}
