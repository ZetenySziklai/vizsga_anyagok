using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_02_06_FutoversenyProjekt
{
    public class Szervezo : ISzervezo
    {
        public string ID { get; set; }

        public bool EredmenyMentese(Versenytipus versenytipus, Versenyzo versenyzo, Futas futas)
        {
            return versenyzo.VersenyzoEredmenye(versenytipus, futas);
        }
    }
}
