using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _2025_11_17_Kombinacio
{
    internal class KombinacioOsszeg
    {
        private List<int> szamok = new List<int>() { 1, 2, 3, 4, 5, 6 };
        private List<int> aktLista = new List<int>();

        private int Osszeg { get; }
        public KombinacioOsszeg(int osszeg)
        { 
            Osszeg = osszeg;
        }

        public void Run()
        {
            OsszegKombinacioRek(szamok, Osszeg, 0, aktLista);
        }

        private void OsszegKombinacioRek(List<int> sz, int cel, int index, List<int> akt)
        {
            if (cel == 0)
            {
                Console.WriteLine(string.Join(" ", akt));
                return;
            }
            if (cel < 0 || index >= sz.Count) return;
            akt.Add(sz[index]);
            OsszegKombinacioRek(sz, cel - sz[index], index + 1, akt);

            akt.RemoveAt(akt.Count - 1);
            OsszegKombinacioRek(sz, cel, index + 1, akt);
        }
    }
}
