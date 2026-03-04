using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_10_17_Gyakorlas
{
    class Program
    {
        static void Main(string[] args)
        {
            //A szöveg felét fordítsd meg és tedd a második fele után

            //szoveg = Geza aludni megy.
            //ujszoveg = dni megyula azeG

            // Generálj ki 13 db páros 7tel osztható számot [10,999] között
            // Add meg a számok átlagát! - 14-gyel osztható számok

            string szoveg = "Geza aludni megy";
            string forditottFele = "";
            string masodikFele = "";

            // szoveg[0] - 'G' - 103
            // szoveg[0] + 2 -> 'I'
            // szam = 97 -> (char)szam -> Convert.ToChar(szam) - 'a'
            // (int)szoveg[0] 

            for (int i = szoveg.Length /2-1; i >= 0; i--)
            {
                forditottFele += szoveg[i];
            }
            Console.WriteLine(forditottFele);

            for (int i = szoveg.Length / 2; i < szoveg.Length; i++)
            {
                masodikFele += szoveg[i];
            }
            Console.WriteLine(masodikFele);
            Console.WriteLine(masodikFele + forditottFele);

            Random r = new Random();
            double osszeg = 0;
            for (int i = 0; i < 13; i++)
            {
                // [10,999] - [5,499]*2 - [3,333]*3 - [1,71]*14
                int a = r.Next(1, 71) * 14;
                osszeg += a;
                Console.Write(a + " ");
            }
            Console.WriteLine();
            Console.WriteLine( osszeg/13);
            // int / int = int 
            // double / int = double
            // double / double = double


            Console.ReadLine();
        }
    }
}
