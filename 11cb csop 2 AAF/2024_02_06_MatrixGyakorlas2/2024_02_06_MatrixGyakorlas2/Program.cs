using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_02_06_MatrixGyakorlas2
{
    class Program
    {
        static int[,] matrix;
        static void Main(string[] args)
        {
            /* 1. [n,m]-es mátrix, amit a felhasználó ad meg. Töltse fel két jegyű számokkal és nullával úgy, hogy a nullát a felhasználó által bekért [0,100] valószínűség között generálja ki.
             * 2. Hány darab nulla van?
             * 3. Generáljon ki egy sorszámot, és adja meg a nullák számát a sorban!
             * 4. Van-e olyan oszlop ahol csak nulla van?
             * 5. Van-e olyan szám, aminek a szomszédjában csak nulla szerepel (átlósan is)?*/

            MatrixLetrehozasa(ref matrix);
            MatrixFeltoltes(matrix);
            MatrixKiiratas(matrix);
            Console.WriteLine("Nullák száma: " + NullakSzama(matrix));
            Feladat3();
            Feladat4();
            Console.ReadLine();
        }


        static void Feladat4()
        {
            if (Vane(matrix))
            {
                Console.WriteLine("van");
            }
            else
                Console.WriteLine("nincs");
        }

        static bool Vane(int[,] matrix)
        {
            int i = 0;
            while (i < matrix.GetLength(1) && !CsakNullaOszlopban(i))
                i++;
            return i < matrix.GetLength(1);
        }

        static bool CsakNullaOszlopban(int oszlopIndex)
        {
            int j = 0;
            while (j < matrix.GetLength(0) && matrix[j, oszlopIndex] == 0)
                j++;
            return j >= matrix.GetLength(0);
        }


        static void Feladat3()
        {
            Random r = new Random();
            int sorszam = r.Next(0, matrix.GetLength(1));
            Console.WriteLine("{0}. sorban {1} darab nulla van.",sorszam+1, SorbanNullak(matrix,sorszam) );
        }

        static int SorbanNullak(int[,] matrix, int sor)
        {
            int db = 0;
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                if (matrix[sor, i] == 0) db++;
            }
            return db;
        }

        static int NullakSzama(int[,] matrix)
        {
            int db = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(matrix[i,j] == 0) db++;
                }
            }
            return db;
        }

        static void MatrixKiiratas(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void MatrixLetrehozasa(ref int[,] matrix)
        {
            Console.Write("A mátrix sorainak száma: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("A mátrix oszloainak száma: ");
            int m = Convert.ToInt32(Console.ReadLine());
            matrix = new int[n, m];
        }

        static void MatrixFeltoltes(int[,] matrix)
        {
            Console.Write("A nullák megjelenésének valószínűsége: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Random r = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (r.Next(0, 100) < a)
                        matrix[i, j] = 0;
                    else
                        matrix[i, j] = r.Next(10, 100);
                }
            }
        }

    }
}
