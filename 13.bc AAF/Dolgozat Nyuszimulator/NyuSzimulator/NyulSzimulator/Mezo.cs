using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyulSzimulator
{
    internal class Mezo
    {
        public int Szelesseg { get; }
        public int Magassag { get; }
        public IEloleny[,] racs = new IEloleny[10,10];
        private int nyulSzuletesiEsely = 70;
        Random rnd = new Random();


        public Mezo(int szelesseg, int magassag, int nyulSzuletesiEsely = 70)
        {
            Szelesseg = szelesseg;
            Magassag = magassag;
            this.nyulSzuletesiEsely = nyulSzuletesiEsely;
        }

        


        public void RacsFeltoltes()
        {
            for (int i = 0; i < racs.GetLength(0); i++)
            {
                for (int j = 0; j < racs.GetLength(1); j++)
                {
                    if (rnd.Next(100) < nyulSzuletesiEsely)
                    {
                        racs[i, j] = new Nyul((Nem)rnd.Next(2));
                    }
                }
            }
        }

        public void Leptetes()
        {
            List<(int, int, IEloleny)> ujElolenyek = new List<(int, int, IEloleny)>();
            SzuletesNelkuliLeptetes();
 
            HalottElolenyTorlese();
        }

        private void HalottElolenyTorlese()
        {
            for (int i = 0; i < racs.GetLength(0); i++)
            {
                for (int j = 0; j < racs.GetLength(1); j++)
                {
                    if (racs[i,j] != null && !racs[i, j].ElE) racs[i, j] = null;
                }
            }
        }

        private void SzuletesNelkuliLeptetes()
        {
            for (int i = 0; i < Szelesseg; i++)
            {
                for (int j = 0; j < Magassag; j++)
                {
                    if (racs[i, j] != null)
                    {
                        ((Nyul)racs[i, j]).SzimulaciosLepes(racs, i, j);
                        
                    }
                }
            }
        }


    }
}
