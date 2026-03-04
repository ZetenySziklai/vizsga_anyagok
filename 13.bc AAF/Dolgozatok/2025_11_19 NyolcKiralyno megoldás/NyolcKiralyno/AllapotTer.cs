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
            int[,] ujPalya = (int[,])palya.Clone();
            ujPalya[s, o] = 1;

            // sorban lévő üres helyek lefoglalása
            for (int i = 0; i < palya.GetLength(0); i++)
            {
                ujPalya[s, i] = ujPalya[s, i] == 1 ? 1 : 2;  
            }
            // oszlopban lévő üres helyek lefoglalása
            for (int i = 0; i < palya.GetLength(1); i++)
            {
                ujPalya[i,o] = ujPalya[i, o] == 1 ? 1 : 2;
            }

            // balról jobbra le átlóban lévő üres helyek lefoglalása
            if (s <= o)
            {
                for (int i = 0; i < s + 8 - o; i++)
                {
                    ujPalya[i, o - s + i] = ujPalya[i, o - s + i] == 1 ? 1 : 2;
                }
            }
            else
            {
                for (int i = 0; i < o + 8 - s; i++)
                {
                    ujPalya[s - o + i, i] = ujPalya[s - o + i, i] == 1 ? 1 : 2;
                }
            }
            // jobbról balra le átlóban lévő üres helyek lefoglalása
            if (s < 8 - o)
            {
                for (int i = 0; i < s + o + 1; i++)
                    ujPalya[i, o + s - i] = ujPalya[s, o + s - i] == 1 ? 1 : 2;
            }
            else
            {
                for (int i = 0; i < 15 - s - o; i++)
                    ujPalya[s - 7 + o + i, 7 - i] = ujPalya[s - 7 + o + i, 7 - i] == 1 ? 1 : 2;
            }


            return ujPalya;
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
            Stack<Allapot> allapotok = new Stack<Allapot>();
            allapotok.Push(kezdoAllapot);
            Allapot akt;
            do
            {
                akt = allapotok.Pop();
                UjallapotokKeszitese(akt, allapotok);
            } while (allapotok.Count > 0 && !akt.VegallapotE);

            return akt;
        }

        private void UjallapotokKeszitese(Allapot akt, Stack<Allapot> allapotok)
        {
            for (int i = 0; i < akt.Palya.GetLength(0); i++)
            {
                for (int j = 0; j < akt.Palya.GetLength(1); j++)
                {
                    if (akt.Palya[i, j] == 0)   
                    {
                        int[,] ujPalya = KiralynoLerakasa(akt.Palya, i, j);
                        allapotok.Push(new Allapot(ujPalya, akt));
                    }
                }
            }
        }
    }
}
