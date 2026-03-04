using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_09_19_Elagazasok
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Elágazások
             * ha(feltétel(ek))
             *      szekvencia;
             *      
             * if(feltétel(ek))
             * { // egy utasítás esetén a zárójel elhagyható.
             *      Szekvencia;
             * }
             * 
             * ha(feltétel(ek))
             *      szekvencia1;
             * különben
             *      szekvencia2;
             * 
             * if(feltétel(ek))
             * {
             *      Szekvencia1;
             * }
             * else
             * {
             *      Szekvencia2;
             * }
             * 
             * if(feltétel(ek))
             *      Szekvencia1;
             * else if(feltétel(ek))
             *      Szekvencia2;
             * ....
             * else
             *      SzekvenciaN;
             *      
             *      
             * switch(változó)
             * {
             *      case érték1: Szekvencia1;
             *          break;
             *      case érték2: Szekvencia2;
             *          break;
             *      case érték3: Szekvencia2;
             *          break;
             *      case érték4: Szekvencia2;
             *          break;
             *      default: SzekvenciaN;
             *          break;
             * }
             */

            Console.Write("Adjon meg egy napot: ");
            string nap = Console.ReadLine();
            switch (nap)
            {
                case "hétfő": Console.WriteLine("raguleves");
                    break;
                case "kedd":
                    Console.WriteLine("rántott husi");
                    break;
                default: Console.WriteLine("Hibás napot adott meg.");
                    break;
            }
            // HF pdf-ből 7-9.

            Console.ReadLine();
        }
    }
}
