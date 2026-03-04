using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_05_10_Vektorok
{
    class Program
    {
        static void Main(string[] args)
        {
            Vektor v = new Vektor(3,4);
            Console.WriteLine(v.AlphaFok());
            Console.WriteLine(v.Meredekseg());
            Console.WriteLine(v.Hossz());

            Console.WriteLine(v.Nyujtas(1));
            Console.WriteLine(v.Hossz());




            Console.ReadLine();
        }
    }
}
