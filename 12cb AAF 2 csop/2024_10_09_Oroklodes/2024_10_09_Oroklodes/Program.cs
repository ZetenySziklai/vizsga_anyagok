using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_10_09_Oroklodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kutya k = new Kutya();
           // k.Ugat();

            Puli p = new Puli();
            p.Terel();

            p.Ugat();

            Kutya k = p;
            k.Ugat();
            //k.Terel(); - polimorfizmus miatt nem megoldható.

            Console.ReadLine();
        }
    }

    class Kutya {
        public void Ugat()
        {
            Console.WriteLine("Vau-Vau");
        }
    }

    class Puli : Kutya {
        public void Terel() {
            Console.WriteLine("Gyerünk, indulás, lusta banda!");
        }
    }
}
