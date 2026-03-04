using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarakterlancTiltasokkal
{
    internal class SzovegGeneralas
    {
        private int Hossz { get; }
        private char[] Karakterek { get; }
        public List<string> megoldasok = new List<string>();

        public SzovegGeneralas(char[] karakterek, int hossz)
        {
            Karakterek = karakterek;
            Hossz = hossz;
        }

        public void Run()
        {
            Backtrack("");
        }

        private void Backtrack(string v)
        {
            if (v.Length == Hossz)
            {
                megoldasok.Add(v);
                return;
            }
            for (int i = 0; i < Karakterek.Length; i++)
            {
                //if (Karakterek[i] == 'B' && v[^1] == 'A')
                if (v.Length > 0 && Karakterek[i] == 'B' && v.Last() == 'A')
                {
                    continue;
                }
                if (v.Length > 0 && Karakterek[i] == 'C' && v.Last() == 'C')
                {
                    continue;
                }
                if (v.Length == 0 && Karakterek[i] == 'D')
                {
                    continue;
                }
                //if(!(Karakterek[i] == 'B' && v.Last() == 'A' || Karakterek[i] == 'C' && v.Last() == 'C' || v.Length == 0 && Karakterek[i] == 'D'))
                //if(megoldasok.Count <= 20)
                    Backtrack(v + Karakterek[i]);
            }
        }
    }
}
