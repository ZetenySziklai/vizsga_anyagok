using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_02_06_FutoversenyProjekt
{
    public class Futas
    {
        public string versenyzoId;
        /// <summary>
        /// Kezdés formátuma: ora:perc:sec
        /// </summary>
        public string Kezdes { get; set; }
        /// <summary>
        /// Befejezes formátuma: ora:perc:sec
        /// </summary>
        public string Befejezes { get; set; }
        /// <summary>
        /// A befejezés és kezdés különbsége, percben és sec-ben
        /// </summary>
        /// <returns>perc, sec</returns>

        public Futas(string kezdes, string befejezes)
        { 
            Kezdes = kezdes;
            Befejezes = befejezes;
        }

        public (int, int) TeljesitmenyPercSec()
        {
            //01:20:15
            //02:15:05
            //perc: 54
            //sec: 50 
            int[] k = Array.ConvertAll(Kezdes.Split(':'), Convert.ToInt32);
            int[] b = Array.ConvertAll(Befejezes.Split(':'), Convert.ToInt32);
            int osszes = b[0] * 3600 + b[1] * 60 + b[2]-( k[0] * 3600 + k[1] * 60 + k[2]);
            int perc = osszes / 60;
            int sec = osszes % 60;
            return (perc, sec);
        }

        public int TeljesitmenySec()
        {
            (int p, int s) = TeljesitmenyPercSec();
            return p * 60 + s;
        }
    }
}
