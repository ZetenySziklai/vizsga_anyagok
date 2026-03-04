using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_02_14_MatrixDolgozat
{
    class Program
    {
        static int[,] haz;
        static void Main(string[] args)
        {
            HazMeghatarozas();
            MatrixFeltoltes();
            MatrixKiiratas();
            Feladat3();
            Feladat4();
            Feladat5();

            Console.ReadLine();
        }

        static void Feladat5()
        {
            Console.WriteLine("5. feladat");
            List<double> legkisebbek = LegkisebbLakasokEmeletenkent();
            for (int i = 0; i < legkisebbek.Count; i++)
            {
                Console.WriteLine("{0}. szint: {1} lakas", i + 1, legkisebbek[i]+1);
            }
        }

        static List<double> LegkisebbLakasokEmeletenkent()
        {
            List<double> lakasok = new List<double>();
            for (int i = 0; i < haz.GetLength(0); i++)
            {
                int mini = 0;
                for (int j = 1; j < haz.GetLength(1); j++)
                {
                    if (haz[i, j] < haz[i, mini])
                        mini = j;
                }
                lakasok.Add(mini);
            }
            return lakasok;
        }

        static void Feladat4()
        {
            Console.WriteLine("4. feladat");
            List<double> vizoraSzamok = VizoraAllasok();
            for (int i = 0; i < vizoraSzamok.Count; i++)
            {
                Console.WriteLine("{0}. lépcsőház: {1} m3",i+1,vizoraSzamok[i]);
            }
        }

        static List<double> VizoraAllasok()
        {
            List<double> allasok = new List<double>();

            for (int i = 0; i < haz.GetLength(1); i++)
            {
                double oraszam = 0;
                for (int j = 0; j < haz.GetLength(0); j++)
                {
                    oraszam += Math.Floor(Math.Sqrt(haz[j, i]) / 1.2); 
                }
                allasok.Add(oraszam);
            }

            return allasok;
        }

        static void Feladat3()
        {
            Console.WriteLine("3. feladat");
            double osszeg = LegkobmeterSzamitas();
            Console.WriteLine("A ház teljes gáz kiadása: "+osszeg);

        }

        static double LegkobmeterSzamitas()
        {
            double osszeg = 0;
            for (int i = 0; i < haz.GetLength(0); i++)
            {
                for (int j = 0; j < haz.GetLength(1); j++)
                {
                    osszeg += haz[i, j] * 2.6 * 300;
                }
            }
            return osszeg;
        }

        static void MatrixKiiratas()
        {
            for (int i = 0; i < haz.GetLength(0); i++)
            {
                for (int j = 0; j < haz.GetLength(1); j++)
                {
                    Console.Write(haz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void MatrixFeltoltes()
        {
            Random r = new Random();
            for (int i = 0; i < haz.GetLength(0); i++)
            {
                for (int j = 0; j < haz.GetLength(1); j++)
                {
                    if (j % 2 == 0)
                        haz[i, j] = r.Next(5, 10) * 10;
                    else
                        haz[i, j] = r.Next(8, 13) * 5;
                }
            }
        }

        static void HazMeghatarozas()
        {
            Console.Write("Adja meg a lépcsőházak számát: ");
            int lepcsohaz = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adja meg az emeletek számát: ");
            int emeletek = Convert.ToInt32(Console.ReadLine());
            //haz = new int[emeletek, lepcsohaz]
            haz = new int[emeletek,lepcsohaz];

        }
    }
}
