using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_02_22_Struktura
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Változók:
             * Elemi típus
             * típus változó_név = érték;
             * int a = 5;
             * 
             * Összetett típusok:
             * Tömb - Array - azonos típusúak
             * Lista - List - azonos típusúak
             * 2D Tömb - 2D Array - mátrix - azonos típusúak
             * Listában a lista - azonos típusúak
             * 
             * Struktúra
             * definiálunk egy új szerkezetet, struktúrát*/

            Diak diak1 = new Diak();
            diak1.nev = "Béla";
            //Console.WriteLine(diak1.nev);
            diak1.osztalyfonok = "Nagy János";
            //Console.WriteLine(diak1.osztalyfonok);
            diak1.osztaly = "11.H";
            diak1.szulev = 2006;
            diak1.evVegiAtlag = 4.2;

            Console.WriteLine("{0} ({3}): {1}\nofi: {2}\nÉv végi átlag: {4}",diak1.nev, diak1.osztaly,diak1.osztalyfonok,diak1.szulev, diak1.evVegiAtlag);
            Console.WriteLine(diak1.ToString());

            Diak diak5 = new Diak("Jolán", "11.J", "Pintér Aladár", 2007, 3.4);
            Console.WriteLine(diak5.ToString());
            //Console.WriteLine($"{diak1.nev} ({diak1.szulev}): {diak1.osztaly}\nofi: {diak1.osztalyfonok}\nÉv végi átlag: {diak1.evVegiAtlag}");

            Console.ReadLine();
        }
    }

    struct Tema
    { 
        // legalább 5 mezőt
        // ToString()
    }

    struct Diak {
        // Mezők, jellemzők, tulajdonságok
        public string nev, osztaly, osztalyfonok;
        public int szulev;
        public double evVegiAtlag;

        //Konstruktor - Speciális metódus
        public Diak(string ujnev, string ujosztaly, string ujosztalyfonok, int ujszulev, double ujevatlag)
        {
            nev = ujnev;
            osztaly = ujosztaly;
            osztalyfonok = ujosztalyfonok;
            szulev = ujszulev;
            evVegiAtlag = ujevatlag;
        }


        //Metódusok
        public override string ToString()
        {
            return string.Format("{0} ({3}): {1}\nofi: {2}\nÉv végi átlag: {4}", nev, osztaly, osztalyfonok, szulev, evVegiAtlag);
        }
    }
}
