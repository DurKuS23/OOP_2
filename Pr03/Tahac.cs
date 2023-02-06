using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr03
{
    internal class Tahac : NakladniAuto
    {
        public Tahac(string spz, int nosnost, int nosnostVlecky) : base(spz, nosnost)
        {
           this.nosnost += nosnostVlecky;
        }
    }
}
