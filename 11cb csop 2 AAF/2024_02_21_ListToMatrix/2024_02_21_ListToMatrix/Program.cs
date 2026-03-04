using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_02_21_ListToMatrix
{
    class Program
    {
        static List<int> lista = new List<int>();
        static void Main(string[] args)
        {
            ListaFeltoltes();
            ListaKiir();
            MatrixLetrehoz();


            Console.ReadLine();
        }

        static void MatrixLetrehoz()
        {
            int n = lista.Count;
            int sor = (int)Math.Floor(Math.Sqrt(n));
            int oszlop = (int)Math.Ceiling((double)n / sor);
            int[,] matrix = new int[sor,oszlop];

            MatrixFeltoltes(matrix);
            MatrixKiiratas(matrix);
        }

        static void MatrixKiiratas(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j]+" ");
                }
                Console.WriteLine();
            }
        }

        static void MatrixFeltoltes(int[,] matrix)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                int sor = i / matrix.GetLength(1);
                int oszlop = i % matrix.GetLength(1);
                matrix[sor, oszlop] = lista[i];
            }


            /*int k = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (k < lista.Count)
                    {
                        matrix[i, j] = lista[k];
                        k++;
                    }
                    //else
                        //matrix[i, j] = 0;
                }
            }*/


        }

        static void ListaKiir()
        {
            Console.WriteLine("Lista elemszáma: "+lista.Count);
            for (int i = 0; i < lista.Count; i++)
                Console.Write(lista[i]+" ");
        }

        static void ListaFeltoltes()
        {
            Random r = new Random();
            int n = r.Next(15, 100);
            for (int i = 0; i < n; i++)
            {
                lista.Add(r.Next(10,100));
            }
        }
    }
}
