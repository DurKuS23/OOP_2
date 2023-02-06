using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr02
{
    internal class Retez
    {
        private string veta;
        private int cislo;

        public string Veta
        {
            get
            {
                return veta;
            }
            set
            {
                veta = value;
                veta[0].ToString().ToUpper();
            }
        }

        public Retez (string veta, int cislo)
        {
            Veta = veta;
            this.cislo = cislo;
        }

        public override string ToString()
        {
            return veta;
        }
    }
}
