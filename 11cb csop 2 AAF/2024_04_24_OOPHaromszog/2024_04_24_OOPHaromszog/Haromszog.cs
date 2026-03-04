using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_04_24_OOPHaromszog
{
    class Haromszog
    {
        //Mező(k)
        public double oldal1, oldal2, oldal3;


        //Konstruktor(ok)
        public Haromszog(double oldal1, double oldal2, double oldal3)
        {
            this.oldal1 = oldal1;
            this.oldal2 = oldal2;
            this.oldal3 = oldal3;
        }

        //Metódus(ok)
        //Vizsgálatok
        //1. Szabályos-e a háromszög
        public bool SzabalyosE()
        {
            return oldal1 == oldal2 && oldal2 == oldal3;
        }

        //2. Egyenlő szárú-e a háromszög
        public bool EgyenloSzaruE()
        {
            return oldal1 == oldal2 || oldal2 == oldal3 || oldal3 == oldal1;
        }

        //3. Szerkeszthető-e a háromszög
        public bool SzerkeszthetoE()
        {
            return oldal1 + oldal2 > oldal3 && oldal1 + oldal3 > oldal2 && oldal2 + oldal3 > oldal1;
        }

        //Derékszögű-e?
        public bool DerekszoguE()
        {
            //return AlphaFok() == 90 || BetaFok() == 90 || GammaFok() == 90;
            return PitagoraszVizsgalat(oldal1, oldal2, oldal3) || PitagoraszVizsgalat(oldal1, oldal3, oldal2) || PitagoraszVizsgalat(oldal2, oldal3, oldal1);
        }

        private bool PitagoraszVizsgalat(double befogo1, double befogo2, double atfogo)
        {
            return befogo1 * befogo1 + befogo2 * befogo2 == atfogo * atfogo;
        }

        // HF: Kerület, Terület, Alpha, Béta, Gamma

        public double Kerulet()
        {
            return oldal1 + oldal2 + oldal3;
        }

        public double Terulet()
        {
            double s = Kerulet() / 2;
            return Math.Sqrt(s * (s - oldal1) * (s - oldal2) * (s - oldal3));
        }

        public double AlphaRad()
        {
            return Math.Asin(2 * Terulet() / (oldal3 * oldal2));
        }
        public double AlphaFok()
        {
            return Math.Asin(2 * Terulet() / (oldal3 * oldal2)) * 180 / Math.PI;
        }

        public double BetaRad()
        {
            return Math.Asin(2 * Terulet() / (oldal1 * oldal3));
        }

        public double BetaFok()
        {
            return Math.Asin(2 * Terulet() / (oldal1 * oldal3)) * 180 / Math.PI;
        }

        public double GammaRad()
        {
            return Math.Asin(2 * Terulet() / (oldal1 * oldal2));
        }
        public double GammaFok()
        {
            return Math.Asin(2 * Terulet() / (oldal1 * oldal2)) * 180 / Math.PI;
        }

        public double Moldal1()
        {
            return Terulet() * 2 / oldal1;
        }
        public double Moldal2()
        {
            return Terulet() * 2 / oldal2;
        }
        public double Moldal3()
        {
            return Terulet() * 2 / oldal3;
        }
    }
}
