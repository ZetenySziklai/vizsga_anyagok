using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutyaMenhely
{
    internal abstract class Mentokutya : IAllat
    {
        private int korEv;
        private int korHonap;
        private bool gazadaId_letezik;

        public Mentokutya(int ke, int kh, bool gid)
        {
            this.korEv = ke;
            this.korHonap = kh;
            this.gazadaId_letezik = gid;
        }

        public abstract bool Adoptalhato();
        public double EtetesiKoltseg()
        {
            return 500 + korEv*100;
        }

        public bool OrvosiVizsgalat()
        {
            return korEv < 10;
        }

        public bool GazdaId_letezik { get {  return gazadaId_letezik; } }

        public int KorEv{ get { return korEv; } protected set { korEv = value; } }

        public override string ToString()
        {
            return string.Format($"{korEv} éves {korHonap} hónapos \n\tEtetési költség:{EtetesiKoltseg()}");
        }
    }
}
