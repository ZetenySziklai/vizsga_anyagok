using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025_10_06_Solitaire
{
    internal class Allapot
    {
        public int[,] Palya { get; }
        public bool VegallapotE => golyokszama == 1;
        public Allapot Szulo { get; }
        public int golyokszama;

        public Allapot(int[,] palya, Allapot szulo, int gsz)
        { 
            Palya = palya;
            Szulo = szulo;
            golyokszama = gsz;
        }

        private int GolyokSzama()
        {
            int db = 0;
            for (int i = 0; i < Palya.GetLength(0); i++)
            {
                for (int j = 0; j < Palya.GetLength(1); j++)
                {
                    if (Palya[i, j] == 1) db++;
                }
            }
            return db;
        }

        public override string ToString()
        {
            string ki = "";
            for (int i = 0; i < Palya.GetLength(0); i++)
            {
                for (int j = 0; j < Palya.GetLength(1); j++)
                {
                    ki += Palya[i, j];
                }
                ki += "\n";
            }
            return ki;            
        }

    }

}
