using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutyaMenhely
{
    internal class NemetJuhasz : Mentokutya
    {
        public NemetJuhasz(int ke = 2, int kh = 4, bool gid = false) : base(ke, kh, gid)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
