using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_04_24_OOPHaromszog
{
    class Program
    {
        static List<Haromszog> haromszogek = new List<Haromszog>();
        static void Main(string[] args)
        {
            Haromszog h1 = new Haromszog(3,4,5);
            Console.WriteLine(h1.DerekszoguE());

            //if(h1.SzabalyosE())
            //    Console.WriteLine("A háromszög szabályos.");    
            //else
            //    Console.WriteLine("A háromszög nem szabályos.");
            Console.WriteLine(h1.SzabalyosE() ? "A háromszög szabályos" : "A háromszög nem szabályos");

            //Fájlbeolvasás
            // 1. Hány szerkeszthető háromszög van?
            // 2. Van-e olyan háromszög, amelyik a szerkeszthető háromszögek Területének átlagának kerekített értékével egyenlő

            Fajlbeolvasas();
            Feladat1();

            Console.ReadLine();
        }

        static void Feladat2()
        {
            double atlag = TeruletekAtlaga();
            if (VaneAtlagkozeliErtek(atlag))
                Console.WriteLine("Van olyan háromszög, amelyik a szerkeszthető háromszögek területének átlagának kerekített értékével egyenlő.");
            else
                Console.WriteLine("Nincs olyan háromszög, amelyik a szerkeszthető háromszögek területének átlagának kerekített értékével egyenlő.");
        }

        static bool VaneAtlagkozeliErtek(double atlag)
        {
            int i = 0;
            while (i < haromszogek.Count && (int)haromszogek[i].Terulet() != (int)atlag)
                i++;
            return i < haromszogek.Count;
        }

        static double TeruletekAtlaga()
        {
            double osszeg = 0;
            for (int i = 0; i < haromszogek.Count; i++)
                osszeg += haromszogek[i].Terulet();
            return osszeg / haromszogek.Count;
        }

        static void Feladat1()
        {
            int db = SzerkeszthetoHaromszogekDB();
            Console.WriteLine($"{db} db szerkeszthető háromszögvan.");
        }

        static int SzerkeszthetoHaromszogekDB()
        {
            int db = 0;
            for (int i = 0; i < haromszogek.Count; i++)
                if (haromszogek[i].SzerkeszthetoE())
                    db++;
            return db;
        }

        static void Fajlbeolvasas()
        {
            StreamReader f = new StreamReader("haromszogek.csv");
            f.ReadLine();

            while (!f.EndOfStream)
            {
                string[] st = f.ReadLine().Split(';');
                haromszogek.Add(new Haromszog(Convert.ToDouble(st[0]), Convert.ToDouble(st[1]), Convert.ToDouble(st[2])));
            }

            f.Close();
        }
    }
}
