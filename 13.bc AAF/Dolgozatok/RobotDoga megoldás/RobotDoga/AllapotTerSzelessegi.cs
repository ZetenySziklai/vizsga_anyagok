using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotDoga
{
    internal class AllapotTerSzelessegi
    {
        public Allapot kezdoAllapot;
        //private List<string> allapotokRajza = new List<string>();

        public AllapotTerSzelessegi()
        {
            char[,] palya = PalyaFajlbol("palya.txt");
            if (palya != null)
                kezdoAllapot = new Allapot(1, 1, palya, null);
        }

        private char[,] PalyaFajlbol(string utvonal)
        {
            char[,] palya = new char[10, 10];

            try
            {
                //using (StreamReader sr = new StreamReader(utvonal))
                //{}
                StreamReader f = new StreamReader(utvonal);
                int i = 0;
                while (!f.EndOfStream)
                {
                    string sor = f.ReadLine();
                    for (int j = 0; j < sor.Length; j++)
                    {
                        palya[i, j] = sor[j];
                    }
                    i++;
                }
                f.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

            return palya;
        }

        public Allapot RobotLepese(Allapot akt, int s, int o, int fugg, int vizsz)
        {
            int ujs = s + vizsz;
            int ujo = o + fugg;
            char[,] ujpalya = (char[,])akt.Palya.Clone();
            if (ujs >= 0 && ujs < akt.Palya.GetLength(1) && ujo >= 0 && ujo < akt.Palya.GetLength(0) && " SE".Contains(akt.Palya[ujs, ujo]))
                return new Allapot(ujs, ujo, ujpalya, akt);
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
            Queue<Allapot> allapotok = new Queue<Allapot>();
            allapotok.Enqueue(kezdoAllapot);
            Allapot akt;
            bool vege;
            do
            {
                akt = allapotok.Dequeue();
                vege = akt.VegallapotE;
                akt.Palya[akt.S, akt.O] = '.';
                Console.WriteLine(akt.ToString());
                UjAllapotok(akt, allapotok);
            } while (allapotok.Count > 0 && !vege);
            return akt;
        }

        private void UjAllapotok(Allapot akt, Queue<Allapot> allapotok)
        {
            Allapot uj4 = RobotLepese(akt, akt.S, akt.O, 0, 1);
            if (uj4 != null) allapotok.Enqueue(uj4);
            Allapot uj2 = RobotLepese(akt, akt.S, akt.O, 1, 0);
            if (uj2 != null) allapotok.Enqueue(uj2);
            Allapot uj3 = RobotLepese(akt, akt.S, akt.O, 0, -1);
            if (uj3 != null) allapotok.Enqueue(uj3);
            Allapot uj1 = RobotLepese(akt, akt.S, akt.O, -1, 0);
            if (uj1 != null) allapotok.Enqueue(uj1);
        }
    }
}
