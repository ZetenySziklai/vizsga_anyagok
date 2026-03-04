using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_02_15_MatrixToList
{
    class Program
    {
        static double[,] matrix = new double[6, 6];
        static double[,] matrix2 = new double[4, 9];
        static List<double> lista = new List<double>();
        static void Main(string[] args)
        {
            /* Tölts fel egy 6x6-os mátrixot [10,99] közötti véletlen számmal!
             * Vedd ki az elemek gyökét egy listába!
             * Helyezd vissza egy 4x9-es mátrixba a lista elemeit!
             * A felhasználó csak a listát látja! 
             * A felhasználó adja meg, hányadik elemet szeretné lekérni a listából. Add meg, hogy az az indexű elem, hányadik sor, hányadik oszlopában van a mátrixban.
               Van egy k darabú lista. Hogyan tesszük be a legszükebb  nxm-es mátrixba!
               19 elemű lista -> 4x5 -ös mátrixba
               26 elemű lista -> 5x6 -os mátrixba
             */

            MatrixFeltoltes();
            MatrixKiiratas(matrix);
            MatrixToList(matrix, lista);
            ListaKiiratas(lista);
            //ListToMatrix(lista, matrix2);
            //MatrixKiiratas(matrix2);

            Feladat();

            Console.ReadLine();
        }

        static void Feladat()
        {
            Console.Write("Adja meg hányadik elemet szeretné elhelyezni a mátrixba ([1-{0}]: ", lista.Count);
            int index = Convert.ToInt32(Console.ReadLine()) - 1;
            int sor = index / matrix.GetLength(1);
            int oszlop = index % matrix.GetLength(1);
            Console.WriteLine("({0};{1}) - {2}",sor+1,oszlop+1,matrix[sor,oszlop]);
        }

        static void ListToMatrix(List<double> lista, double[,] m)
        {
            int k = 0;
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    m[i, j] = lista[k];
                    k++;
                }
            }
        }

        static void ListaKiiratas(List<double> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                Console.Write(Math.Round(lista[i],2) + " ");
            }
            Console.WriteLine("\n");
        }

        static void MatrixToList(double[,] m, List<double> lista)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    lista.Add(Math.Sqrt(m[i, j]));
                }
            }
        }

        static void MatrixKiiratas(double[,] m)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    Console.Write(m[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static void MatrixFeltoltes()
        {
            Random r = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = r.Next(10, 100);
                }
            }
        }
    }
}
