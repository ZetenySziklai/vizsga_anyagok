using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_04_18_OOPalapok
{
    class Kutya
    {
        //Mezők
        public string nev, fajta, szin;
        public double kor, suly;
        public bool him, chip = false;

        //Konstruktorok
        public Kutya(string fajta, bool him, string szin, int kor, double suly)
        {
            this.fajta = fajta;
            this.szin = szin;
            this.kor = kor;
            this.suly = suly;
            this.him = him;
            //chip = false;
            //nev = "";
        }

        public Kutya(bool chip, string nev, bool him, string szin, int kor, double suly, string fajta)
        {
            this.chip = chip;
            this.nev = nev;
            this.fajta = fajta;
            this.szin = szin;
            this.kor = kor;
            this.suly = suly;
            this.him = him;
        }

        //Metódusok
        public bool MindMegeszi(int mennyiseg)
        {
            if (mennyiseg < suly * 0.05)
            {
                suly += mennyiseg;
                return true;
            }
            else
            {
                suly += suly * 0.05;
                return false;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4} {5}", fajta, szin, kor, suly, 
                him == true ? "kan" : "szuka",
                chip ? "csippelt" : "nem chippelt");
        }
    }
}
