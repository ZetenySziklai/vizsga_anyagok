using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_02_06_FutoversenyProjekt
{
    public class Versenyzo : IVersenyzo
    {
        public string ID { get ; set ; }
        public string Nev { get ; set ; }
        public bool Neme { get ; set ; }

        public Dictionary<Versenytipus, Futas> eredmenyek = new Dictionary<Versenytipus, Futas>();

        public Versenyzo(string id, string nev, bool neme)
        {
            ID = id;
            Nev = nev;
            Neme = neme;
        }

        public bool VersenyzoEredmenye(Versenytipus versenytipus, Futas futas)
        {
            if (!eredmenyek.Any(x => x.Key.ID == versenytipus.ID))
            {
                eredmenyek.Add(versenytipus, futas);
                return true;
            }
            else return false;
        }

        public int HanyVersenyenvolt()
        {
            return eredmenyek.Count;
        }

        public string LegjobbEredmeny()
        {
            // táv, TeljesitménySec
            // sec / táv
            var legjobb = eredmenyek.OrderBy(x => x.Value.TeljesitmenySec() / x.Key.Hossz).First();
            return $"versenyid: {legjobb.Key.ID} tav: {legjobb.Key.Hossz} start: {legjobb.Value.Kezdes} finish: {legjobb.Value.Befejezes}";
        }

        public override string ToString()
        {
            return $"név: {Nev} neme: {(Neme ? "ferfi" : "no")} versenyek száma: {eredmenyek.Count}";
        }
    }
}
