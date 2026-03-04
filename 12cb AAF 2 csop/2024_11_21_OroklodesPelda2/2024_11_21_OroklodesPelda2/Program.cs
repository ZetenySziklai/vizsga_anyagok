using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2024_11_21_OroklodesPelda2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ososztaly s = new Ososztaly(4, 5);
            //s.x = 23; HIBA
            //s.y = 12; HIBA
            Console.WriteLine(s.X);

            Utodosztaly u = new Utodosztaly(123,21,-56);
        }
    }

    class Ososztaly
    {
        //Adattagok
        protected int x;
        protected int y;

        public int X { get { return x; } }

        //Konstruktor
        public Ososztaly(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        //Metódusok
        public void TobbszorozX(int a)
        {
            x *= a;
        }

        public override string ToString()
        {
            return $"x: {x} ";
        }
    }

    class Utodosztaly : Ososztaly
    {
        //Adattagok
        public int b;

        //Konstruktor
        //public Utodosztaly() : base(12,35)
        //public Utodosztaly(int ujx) : base(ujx,35)
        //public Utodosztaly(int ujx, int ujy) : base(ujx,ujy)
        public Utodosztaly(int ujx, int ujy, int b) : base(ujx, ujy)
        {
            this.b = b;
        }

        //Metódusok
        public void OrokoltErtekek()
        {
            Console.WriteLine($"x: {x} y:{y}");
        }

    }

}
