using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_02_06_FutoversenyProjekt
{
    public interface IVersenyzo
    {
        string ID { get; set;}
        string Nev {  get; set;}
        /// <summary>
        /// Neme tulajdonság értékei: true - ferfi, false - nő
        /// </summary>
        bool Neme { get; set;}
    }
}
