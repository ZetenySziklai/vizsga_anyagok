using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_03_21_Szalloda
{
    class Program
    {
        static List<Foglalas> foglalasok = new List<Foglalas>();
        static List<Honap> honapok = new List<Honap>();
        static void Main(string[] args)
        {
            Fajlbeolvasas();
            Feladat2();
            Feladat3();
            FajlbeolvasasHonapok();

            Console.ReadLine();
        }

        private static void FajlbeolvasasHonapok()
        {
            StreamReader f = new StreamReader("honapok.txt");
            while (!f.EndOfStream)
            {
                Honap sv = new Honap();
                sv.nev = f.ReadLine();
                sv.napok = Convert.ToInt32(f.ReadLine());
                sv.kezdes = Convert.ToInt32(f.ReadLine());
                honapok.Add(sv);
            }
            f.Close();
        }

        static void Feladat3()
        {
            Console.WriteLine("3. feladat");
            StreamWriter g = new StreamWriter("bevetel.txt");
            for (int i = 0; i < foglalasok.Count; i++)
            {
                g.WriteLine("{0}: {1}", foglalasok[i].sorszam, OsszegSzamolas(i));
            }
            g.Close();
        }

        static int OsszegSzamolas(int index)
        {
            int erkezes = foglalasok[index].erkezes;
            int ejszakak = foglalasok[index].ejszakak;
            int fo = foglalasok[index].vendegek;
            bool reggeli = foglalasok[index].reggeli;
            int szobaAr, potagy = 0;
            if (erkezes < 121) szobaAr = 9000;
            else if (erkezes < 244) szobaAr = 10000;
            else szobaAr = 8000;
            if (fo > 2) potagy = fo - 2;
            int osszeg = 0;
            if (reggeli) osszeg += fo * ejszakak * 1100;
            osszeg += ejszakak * szobaAr + potagy * 2000;
            return osszeg;
        }

        static void Feladat2()
        {
            Console.WriteLine("2. feladat");
            int maxi = MaxEjszakakSzama();
            Console.WriteLine("{0}({1}) - {2}",foglalasok[maxi].nev, foglalasok[maxi].erkezes, foglalasok[maxi].ejszakak);
        }

        static int MaxEjszakakSzama()
        {
            int maxi = 0;
            for (int i = 0; i < foglalasok.Count; i++)
            {
                if (foglalasok[i].ejszakak > foglalasok[maxi].ejszakak)
                    maxi = i;
            }
            return maxi;
        }

        static void Fajlbeolvasas()
        {
            StreamReader f = new StreamReader("pitypang.txt");
            f.ReadLine();
            while (!f.EndOfStream)
            {
                Foglalas sv = new Foglalas(f.ReadLine());
                foglalasok.Add(sv);
            }
            f.Close();
        }
    }

    struct Honap {
        public string nev;
        public int napok, kezdes;
    }

    struct Foglalas
    {
        //Mezők
        public int sorszam, szoba, erkezes, tavozas, vendegek, ejszakak;
        public bool reggeli;
        public string nev;

        //Konstruktor
        public Foglalas(string sor)
        {
            string[] st = sor.Split(' ');
            sorszam = Convert.ToInt32(st[0]);
            szoba = Convert.ToInt32(st[1]);
            erkezes = Convert.ToInt32(st[2]);
            tavozas = Convert.ToInt32(st[3]);
            vendegek = Convert.ToInt32(st[4]);
            if (st[5] == "1") reggeli = true;
            else reggeli = false;
            nev = st[6];
            ejszakak = tavozas- erkezes; 
        }


    }
}
