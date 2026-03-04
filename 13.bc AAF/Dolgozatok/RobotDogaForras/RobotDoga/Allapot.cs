using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotDoga
{
    internal class Allapot
    {
        public char[,] Palya { get; private set; }
        public int Aktsor { get; }
        public int AktOszlop { get; }
        public Allapot Szulo { get; }
        public bool VegallapotE => true;
        public int Szint { get; }

        public Allapot(int aktsor, int aktoszlop, char[,] palya, Allapot szulo)
        {
            Aktsor = aktsor;
            Aktsor = aktoszlop;
            Palya = palya;
            Szulo = szulo;
            if (szulo == null) Szint = 0;
            else Szint = szulo.Szint + 1;
        }

        
        public override string ToString()
        {
            string ki = "";
            for (int i = 0; i < Palya.GetLength(0); i++)
            {
                for (int j = 0; j < Palya.GetLength(1); j++)
                {
                    ki += Palya[i, j] ;
                }
                ki += "\n";
            }
            ki += "\n";

            return ki;
        }
    }
}
