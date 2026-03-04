using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_09_14_Konverzitas
{
    class Program
    {
        static void Main(string[] args)
        {
            //HF
            Random r = new Random();
            /*Console.WriteLine(
                Math.Round(r.NextDouble() * 10 + 10 , 2));*/
            double a = r.Next(1000, 2001);
            Console.WriteLine(a / 100);

            a = r.Next(100, 401);
            Console.WriteLine(Math.Round(Math.Sqrt(a),2));

            //Konverziók
            string beSzam = "12";
            //int egesz = Convert.ToInt32(beSzam);
            int egesz = int.Parse(beSzam);
            Console.WriteLine(egesz * 2);

            string beTort = "12,54";
            double tort = Convert.ToDouble(beTort);
            //double tort2 = 12.54;
            Console.WriteLine(Math.Sqrt(tort));

            //int.Parse vs Convert.ToInt32()
            Console.WriteLine(Convert.ToInt32(true));
            //Console.WriteLine(int.Parse(true));

            Console.WriteLine(Convert.ToInt32(null));
            //Console.WriteLine(int.Parse(null));

            double te = -12.8;
            //int et = Convert.ToInt32(te);
            int et = (int)te;
            Console.WriteLine(et);

            int id = 13;
            Console.WriteLine((double)id / 3);

            //Szöveggé alakítás
            int b = 123;
            //string szb = Convert.ToString(b);
            //string szb = b.ToString();
            string szb = ""+b;
            Console.WriteLine(szb);


            //Kiíratási lehetőségek
            string nev = "Péter";
            int kor = 12;
            string cim = "Cegléd Kossuth F. u 32";
            bool ferfi = true;
            Console.WriteLine("Név: " + nev + " Kor: " + kor + " Cim: " + cim + " Ferfi: " + ferfi);

            Console.WriteLine("Név: {0} Kor: {1} Cim: {3} Ferfi: {2}", nev, kor, ferfi, cim);

            Console.WriteLine($"Név: {nev} Kor: {kor} Cim: {cim} Ferfi: {ferfi}");

            //Felhasználótól adat bekérés
            Console.Write("Írjon be egy szöveget: ");
            string szoveg = Console.ReadLine();
            Console.WriteLine(szoveg);

            Console.Write("Adjon meg egy egész számot: ");
            /*string be = Console.ReadLine();
            int beEgesz = Convert.ToInt32(be);*/
            int beEgesz = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A szám kétszerese: " + beEgesz * 2);

            // HF feladatok 2021-2022.pdf
            // 1-6. feladatok

            double el = 12.3;
            double l = el * Math.Sqrt(2);
            double t = el * Math.Sqrt(3);
            Console.WriteLine("{0} {1} {2}", el, l, t);


            Console.ReadLine();
        }
    }
}
