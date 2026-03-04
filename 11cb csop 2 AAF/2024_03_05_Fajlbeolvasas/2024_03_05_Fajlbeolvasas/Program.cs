using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2024_03_05_Fajlbeolvasas
{
    class Program
    {

        static List<Papirleadas> leadasok = new List<Papirleadas>();

        static void Main(string[] args)
        {
            //Fajlbeolvasas0();
            //Fajlbeolvasas1();
            //Fajlbeolvasas2();
            //ListaKiirat();

            Fajlbeolvasas3();
            ListaKiirat();
            // FV - 2 dátum (19-20) adjuk meg, hogy melyik nap átlagban mennyi papírt hoztak!

            // Rendezd a súly alapján az adatokat

            Feladat1();

            Console.ReadLine();
        }

        static void Feladat1()
        {
            Console.WriteLine("2024. 03. 19-én {0} kg papír lett leadva", PapirOsszegPerNap("2024.03.19"));
            Console.WriteLine("2024. 03. 20-én {0} kg papír lett leadva", PapirOsszegPerNap("2024.03.20"));

            Console.WriteLine("2024. 03. 19-én {0} kg papír lett leadva", PapirOsszegPerNap(19));
            Console.WriteLine("2024. 03. 20-én {0} kg papír lett leadva", PapirOsszegPerNap(20));
        }

        static int PapirOsszegPerNap(int nap)
        {
            int osszeg = 0;
            for (int i = 0; i < leadasok.Count; i++)
            {
                string[] st = leadasok[i].datum.Split('.');
                if (Convert.ToInt32(st[2]) == nap)
                    osszeg += leadasok[i].suly;
            }
            return osszeg;
        }

        static int PapirOsszegPerNap(string datum)
        {
            int osszeg = 0;
            for (int i = 0; i < leadasok.Count; i++)
            {
                if (leadasok[i].datum == datum)
                    osszeg+=leadasok[i].suly;
            }
            return osszeg;
        }

        static void Fajlbeolvasas3()
        {
            //A fájlt megnyitjuk olvasásra
            StreamReader f = new StreamReader("adatok.txt");

            f.ReadLine();
            f.ReadLine();

            while (!f.EndOfStream)
            {
                //Console.WriteLine(f.ReadLine());
                string[] st = f.ReadLine().Split(' ');
                Papirleadas sv = new Papirleadas(st[0], st[1], Convert.ToInt32(st[2]));
                leadasok.Add(sv);
            }

            f.Close();
        }

        static void ListaKiirat()
        {
            for (int i = 0; i < leadasok.Count; i++)
            {
                Console.WriteLine("{0} {1} {2}", leadasok[i].nev, leadasok[i].datum, leadasok[i].suly);
            }
        }

        static void Fajlbeolvasas2()
        {
            string[] adatok = File.ReadAllLines("adatok.txt");

            for (int i = 0; i < adatok.Length; i++)
            {
                string[] st = adatok[i].Split(' ');
                // Konstruktor kell hozzá
                Papirleadas sv = new Papirleadas(st[0],st[1],Convert.ToInt32(st[2]));
                leadasok.Add(sv);
            }
        }

        static void Fajlbeolvasas1()
        {
            string[] adatok = File.ReadAllLines("adatok.txt");

            for (int i = 0; i < adatok.Length; i++)
            {
                string[] st = adatok[i].Split(' ');
                Papirleadas sv = new Papirleadas();
                sv.nev = st[0];
                sv.datum = st[1];
                sv.suly = Convert.ToInt32(st[2]);
                leadasok.Add(sv);
            }
        }

        static void Fajlbeolvasas0()
        {
            // Könnyen beolvasható, de nehezebben kiértékelhető
            // File.ReadAllLines("../../adatok.txt")
            string[] adatok = File.ReadAllLines("adatok.txt");

            int maxi = 0;
            int maxe = 0;
            for (int i = 0; i < adatok.Length; i++)
            {
                Console.WriteLine(adatok[i]+"$");
                string sor = adatok[i];
                string[] st = sor.Split(' ');
                if (Convert.ToInt32(st[2]) > maxe)
                {
                    maxe = Convert.ToInt32(st[2]);
                    maxi = i;
                }
            }
            Console.WriteLine("{0}. ember hozta a legtöbbet.", maxi+1);
            //string[] stmax = adatok[maxi].Split(' ');
            //Console.WriteLine("{0} hozta a legtöbbet.",stmax[0]);
            Console.WriteLine("{0} hozta a legtöbbet.", adatok[maxi].Split(' ')[0]);
        }

    }

    struct Papirleadas
    {
        public string nev, datum;
        public int suly;

        //konstruktor
        public Papirleadas(string ujnev, string ujdatum, int ujsuly)
        {
            nev = ujnev;
            datum = ujdatum;
            suly = ujsuly;
        }
    }
}
