using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_02_06_FutoversenyProjekt
{
    public class Versenytipus : IVersenytipus
    {
        public string ID { get; set; }
        public int Hossz { get; set; }
        public DateTime Datum { get; set; }

        public Versenytipus(string id, int hossz, DateTime datum)
        {
            ID = id;
            Hossz = hossz;
            Datum = datum;
        }


        public override string ToString()
        {
            return $"id: {ID} hossz: {Hossz} datum: {Datum}";
        }
    }
}
