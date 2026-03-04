using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_02_06_FutoversenyProjekt
{
    public static class Futtathato
    {
        public static List<Versenyzo> versenyzok = new List<Versenyzo>();

        public static void VersenyzoFelvetele(string sor, char c)
        {
            string[] st = sor.Split(c);
            Versenyzo v = new Versenyzo(st[0], st[1], st[2] == "ferfi");
            versenyzok.Add(v);
        }

        public static void VersenyzoFelvetele(Versenyzo v)
        {
            versenyzok.Add(v);
        }

        public static int HanyVersenyenVolt(Versenyzo v)
        {
            return v.HanyVersenyenvolt();
        }
        /// <summary>
        /// A paraméterben megadott Versenyzo tipusú versenyző legjobb eredményét adja vissza szöveges állapotban.
        /// </summary>
        /// <param name="v">Egy Versenyzo tipusú versenyzo</param>
        /// <returns>A legjobb eredmény szövegesen.</returns>
        public static string LegjobbEredmenye(Versenyzo v)
        {
            return v.LegjobbEredmeny();
        }

        public static List<Versenyzo> VersenyzokAdottTipusban(Versenytipus vt)
        {
            return versenyzok.Where(x => x.eredmenyek.Any(c => c.Key.ID == vt.ID)).ToList();
        }
    }
}
