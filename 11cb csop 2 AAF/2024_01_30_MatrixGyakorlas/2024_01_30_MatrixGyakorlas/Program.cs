using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_01_30_MatrixGyakorlas
{
    class Program
    {
        static int[,] matrix = new int[4, 4];
        static void Main(string[] args)
        {
            /* 1. Töltsön fel egy 4x4-os mátrixot [1,20] közötti számokkal!
             * 2. FV: Adja meg a fő és mellék átlók szorzatának hányadosát!
             * 3. FV: Készítsen egy új mátrixot, aminek az első sorában eltárolja a sorok terjedelmét a másodikban pedig az oszlopok szórását!
             * 4. metódus: kérjen be a felhasználótól egy sor és egy oszlop számot és írassa ki az adott helyen lévő számok szomszédját (az átlós is szomszédnak számít)*/

            MatrixFeltoltes(matrix);
            MatrixKiir(matrix);
            Feladat2();
            Feladat3();
            Feladat4();

            Console.ReadLine();

        }

        static void Feladat4()
        {
            Console.Write("Adja meg a sor számát: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adja meg az oszlop számát: ");
            int m = Convert.ToInt32(Console.ReadLine());
            SzomszedokMegadasa(n-1,m-1);
        }

        static void SzomszedokMegadasa(int sor, int oszlop)
        {
            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    if((i!=0 || j!=0) && 
                        sor+i>=0 && oszlop+j>=0 && 
                        sor+i<matrix.GetLength(0) && oszlop+j < matrix.GetLength(1))
                        Console.Write(matrix[sor + i, oszlop + j] + " ");
                }
            }
        }

        static void Feladat3()
        {
            Console.WriteLine("3. feladat");
            int[,] statisztika = new int[2, matrix.GetLength(0)];
            List<int> sorokTerjedelme = SorokTerjedelme(matrix);
            List<int> oszlopokSzorasa = OszlopokSzorasa(matrix);

            for (int i = 0; i < statisztika.GetLength(1); i++)
            {
                statisztika[0, i] = sorokTerjedelme[i];
                statisztika[1, i] = oszlopokSzorasa[i];
            }
            MatrixKiir(statisztika);
        }

        static List<int> OszlopokSzorasa(int[,] matrix)
        {
            List<int> szorasok = new List<int>();
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                double szoras = Szoras(matrix, i);
                szorasok.Add((int)szoras);
            }
            return szorasok;
        }

        static double Szoras(int[,] matrix, int oszlop)
        {
            double osszeg = 0;
            double atlag = Atlag(matrix, oszlop);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                osszeg += Math.Pow(matrix[i, oszlop] - atlag, 2);
            }
            return Math.Sqrt(osszeg / matrix.GetLength(0));
        }

        static double Atlag(int[,] matrix, int oszlop)
        {
            double osszeg = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                osszeg += matrix[i, oszlop];
            }
            return osszeg / matrix.GetLength(0);
        }

        static List<int> SorokTerjedelme(int[,] matrix)
        {
            List<int> terjedelmek = new List<int>();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int terjedelem = Maximum(matrix, i) - Minimum(matrix, i);
                terjedelmek.Add(terjedelem);
            }
            return terjedelmek;
        }

        static int Minimum(int[,] matrix, int sor)
        {
            int mine = matrix[sor, 0];
            for (int i = 1; i < matrix.GetLength(1); i++)
            {
                if (mine > matrix[sor, i])
                    mine = matrix[sor, i];
            }
            return mine;
        }

        static int Maximum(int[,] matrix, int sor)
        {
            int maxe = matrix[sor, 0];
            for (int i = 1; i < matrix.GetLength(1); i++)
            {
                if (maxe < matrix[sor, i])
                    maxe = matrix[sor, i];
            }
            return maxe;
        }


        static void Feladat2()
        {
            Console.WriteLine("2. feladat");
            double hanyados = KetAtloHanyadosa(matrix);
            Console.WriteLine("A két átló szórzatának hányadosa: " + hanyados);
        }

        static double KetAtloHanyadosa(int[,] matrix)
        {
            double foatloSzorzata = 1;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                foatloSzorzata *= matrix[i, i];
            }

            double mellekatloSzorzata = 1;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int oszlop = matrix.GetLength(1) - i - 1;
                mellekatloSzorzata *= matrix[i, oszlop];
            }
            return foatloSzorzata / mellekatloSzorzata;
        }

        static void MatrixFeltoltes(int[,] matrix)
        {
            Random r = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = r.Next(1, 21);
                }
            }
        }

        static void MatrixKiir(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
