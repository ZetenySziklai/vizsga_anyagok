using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_10_19_Tomb2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] napok = new string[] { "hétfő", "kedd", "szerda", "csütörtök", "péntek", "szombat", "vasárnap" };
            // Tárolj el 7 db véletlen számot [10,500] között!
            // Add meg melyik napon volt a legtöbb bevétel!

            int[] bevetelek = new int[7];
            Random r = new Random();
            for (int i = 0; i < bevetelek.Length; i++)
            {
                bevetelek[i] = r.Next(10, 501);
            }
            for (int i = 0; i < bevetelek.Length; i++)
            {
                Console.WriteLine(napok[i]+": "+bevetelek[i]);
            }

            int maxi = 0;
            for (int i = 1; i < bevetelek.Length; i++)
            {
                if (bevetelek[i] > bevetelek[maxi])
                    maxi = i;
            }
            string nap = napok[maxi];
            Console.WriteLine(nap + "i napon volt a legnagyobb a bevétel.");

            //Add meg, hogy volt-e 450 feletti érték a bevételek között. Ha volt melyik nap?

            int j = 0;
            while (j < bevetelek.Length && bevetelek[j] <= 450)
                j++;
            bool vane = j < bevetelek.Length;
            if (vane)
            {
                Console.WriteLine(napok[j]);
            }
            else
            {
                Console.WriteLine("nincs 450 feletti bevétel");
            }



            Console.ReadLine();
        }
    }
}
