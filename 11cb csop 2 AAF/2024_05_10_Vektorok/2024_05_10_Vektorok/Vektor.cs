using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_05_10_Vektorok
{
    class Vektor
    {
        //Mezők
        private double x, y;

        public double X {
            get { return x; }
        }
        public double Y {
            get { return y; }
        }

        //public double R {
        //    get;
        //    private set;
        //}

        //Konstruktor
        public Vektor(string sor)
        {
            string[] st = sor.Split(';');
            x = Convert.ToDouble(st[0]);
            y = Convert.ToDouble(st[1]);
        }

        public Vektor(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double Hossz()
        {
            return Math.Sqrt(x * x + y * y);
        }

        public double Meredekseg()
        {
            return y / x;
        }

        public double AlphaRadian()
        {
            //return Math.Atan(Meredekseg());
            return Math.Atan(y/x);
        }

        public double AlphaFok()
        {
            return AlphaRadian() * 180 / Math.PI;
        }

        //Nyújtás lambda*Vektor=(lambda*x, lambda*y)

        public bool Nyujtas(double lambda)
        {
            //x = x * lambda;
            double x1 = x *lambda;
            //y = y * lambda;
            double y1 = y * lambda;
            if (lambda != 1)
            {
                x = x1;
                y = y1;
            }
            return lambda != 1;
        }
    }
}
