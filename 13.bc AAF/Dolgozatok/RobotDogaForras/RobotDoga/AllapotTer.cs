using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotDoga
{
    internal class AllapotTer
    {
        public Allapot kezdoAllapot;
        //private List<string> allapotokRajza = new List<string>();

        public AllapotTer()
        {
            char[,] palya = PalyaFajlbol("palya.txt");
            if(palya != null)
                kezdoAllapot = new Allapot(1,1,palya, null);
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

        public int[,] RobotLepese(int[,] palya)
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
