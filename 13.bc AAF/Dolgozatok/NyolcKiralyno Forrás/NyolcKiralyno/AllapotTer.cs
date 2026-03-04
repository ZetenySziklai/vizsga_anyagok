using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyolcKiralyno
{
    internal class AllapotTer
    {
        private Allapot kezdoAllapot;
        private List<string> allapotokRajza = new List<string>();

        public AllapotTer()
        {
            kezdoAllapot = new Allapot(new int[8,8],null);
        }


        public int[,] KiralynoLerakasa(int[,] palya, int s, int o)
        {            
            return null;

        }

        public List<Allapot> Megoldas()
        {
            List<Allapot> megoldas = new List<Allapot>();

            Allapot akt = VegallapotKereses();
            do
            {
                megoldas.Add(akt);
                akt = akt.Szulo;
            } while (akt != null);

            return megoldas;
        }

        private Allapot VegallapotKereses()
        {
           
            return null;
        }

    }
}
