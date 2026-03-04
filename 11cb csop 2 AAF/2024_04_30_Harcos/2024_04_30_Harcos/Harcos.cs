using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_04_30_Harcos
{
    // Scope - public, private
    class Harcos
    {
        //Mezők
        private string nev;
        private int eletero, harciero;

        //Konstruktor
        public Harcos(string nev, int eletero, int harciero)
        {
            this.nev = nev;
            this.eletero = eletero;
            this.harciero = harciero;
        }

        //Metódusok
        public bool Harcol(Harcos ellenfel)
        {
            eletero -= ellenfel.harciero;
            ellenfel.eletero -= harciero;
            return eletero < 0 || ellenfel.eletero < 0;
        }

        public override string ToString()
        {
            return string.Format("név: {0} HP:{1} DP:{2}",nev,eletero,harciero);
        }

        //Getter, Setter
        public string Nev
        {
            get { return nev; }
            set { nev = value; }
        }
        public int Eletero
        {
            get { return eletero; }
            set { eletero = value; }
        }
        public int Harciero
        {
            get { return harciero; }
            set { harciero = value; }
        }





        //public string Szuloje { get; set; }

        ////Getter, setter
        //public string Nev {
        //    get {
        //        return nev;
        //    }
        //    private set {
        //        nev = value;
        //    }
        //}

        //public Harcos()
        //{
        //    Nev = "Gábor";
        //}


        //public string NevErteke()
        //{
        //    return nev;
        //}

        //public string GetNev()
        //{
        //    return nev;
        //}
    }
}
