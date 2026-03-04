using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_02_06_FutoversenyProjekt
{
    public interface ISzervezo
    {
        string ID { get; set; }
        bool EredmenyMentese(Versenytipus versenytipus, Versenyzo versenyo, Futas futas);
    }
}
