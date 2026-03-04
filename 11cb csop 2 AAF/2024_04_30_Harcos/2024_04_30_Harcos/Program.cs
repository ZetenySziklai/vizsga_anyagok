using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_04_30_Harcos
{
    class Program
    {
        /* HF Generálj ki 8 Harcost Kódnévvel és véletlen HP, DP-vel!
             * Kódnév: 5 db véletlen karakter, kis és nagybetűs
             * Hp: [1000,5000] között 00-ra végződjön.
             * DP: [50,200] 0-ra végződjön.
             * Kiesős harc! Ki a győztes?*/

        static void Main(string[] args)
        {
            Harcos h1 = new Harcos("Ironman", 1000, 120);
            Harcos h2 = new Harcos("Pacman", 500, 375);

            //Console.WriteLine(h1.Harcol(h2));
            //Console.WriteLine(h1.Harcol(h2));
            //Console.WriteLine(h1.Harcol(h2));
            do
            {
                Console.WriteLine(h1.ToString());
                Console.WriteLine(h2.ToString());
                Console.WriteLine();
            } while (!h1.Harcol(h2));
            Console.WriteLine(h1.ToString());
            Console.WriteLine(h2.ToString());
            Console.ReadLine();
        }
    }
}
