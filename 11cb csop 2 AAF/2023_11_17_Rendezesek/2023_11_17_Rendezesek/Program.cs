using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_11_17_Rendezesek
{
    class Program
    {
        static int[] t = new int[10];
        static void Main(string[] args)
        {
            Tombfeltoltes(t);
            TombKiiratas(t);
            Rendezes(t);
            TombKiiratas(t);

            Console.ReadLine();
        }

        static void Rendezes(int[] tomb)
        {
            //Ciklus I = 1 - től N - 1 - ig
            for (int i = 0; i < tomb.Length - 1; i++)
            {
                //Ciklus J = I + 1 - től N - ig
                for (int j = i + 1; j < tomb.Length; j++)
                {
                    //Ha X[I]> X[J] akkor Csere(X[I], X[J])
                    if (tomb[i] > tomb[j])
                    {
                        int csere = tomb[i];
                        tomb[i] = tomb[j];
                        tomb[j] = csere;
                    }

                }// Ciklus vége

            }//Ciklus vége
        }

        static void TombKiiratas(int[] tomb)
        {
            for (int i = 0; i < tomb.Length; i++)
                Console.Write(tomb[i] + " ");
            Console.WriteLine();
        }

        static void Tombfeltoltes(int[] tomb)
        {
            Random r = new Random();
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = r.Next(1, 100);
            }
        }

    }
}
