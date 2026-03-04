using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_04_18_OOPalapok
{
    class Program
    {
        static void Main(string[] args)
        {
            Kutya k1 = new Kutya("labrador", false, "bézs", 5, 30);
            Kutya k2 = new Kutya(true, "Zsigmond", true, "barna", 6, 37, "vizsla");

            Console.WriteLine(k1.ToString());
            /*if(k1.MindMegeszi(2))
                Console.WriteLine("Mindent megevett.");
            else Console.WriteLine("Nem evett meg mindent");*/
            Console.WriteLine(k1.MindMegeszi(2) ? "Mindent megevett." : "Nem evett meg mindent");
            Console.WriteLine(k1.ToString());

            //int a = k1.MindMegeszi(2) == true ? 12 : 45;

            Console.WriteLine(k2.ToString());
            Console.WriteLine(k2.MindMegeszi(2) ? "Mindent megevett." : "Nem evett meg mindent");
            Console.WriteLine(k2.ToString());



            //A osztaly1 = new A("alma");
            ////osztaly1.s = "szöveg";
            ////osztaly1.a = 123;

            //Console.WriteLine(osztaly1.s+" "+osztaly1.a);

            //Console.WriteLine(osztaly1.Sokszorosit(5));



            Console.ReadLine();
        }
    }

    class A
    {
        //Mezők, jellemző, tulajdonság, attribútum
        public string s; //public - globális, bárhol használható a névtéren belül.
        public int a; //private - osztály szintű

        //Konstruktorok
        public A(string sz) {
            s = sz;
            a = sz.Length;
        }

        //Metódusok

        public string Sokszorosit(int k)
        {
            string szoveg = "";
            for (int i = 0; i < k; i++)
                szoveg += s;
            return szoveg;
        }

    }
}
