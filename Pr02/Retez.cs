using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr02
{
    internal class Retez
    {
        protected string veta;
        private int cislo;

        public virtual string Veta
        {
            get
            {
                return veta;
            }
            set
            {
                veta = value;
                string c = (value.Substring(0, 1).ToUpper()) + value.Substring(1);
                if (c[c.Length - 1] == '.')
                {
                    veta = c;
                }
                else
                {
                    c += '.';
                    veta = c;
                }
            }
        }

        public Retez (string veta, int cislo)
        {
            Veta = veta;
            this.cislo = cislo;
        }

        public void PocetSlov(out int pocetslov)
        {
            string[] veta_array = veta.Split(' ');
            pocetslov = veta_array.Count();
        }

        public virtual void Zkrat(int cislo)
        {
            string[] newveta = veta.Split(' ');

            veta = string.Empty;
            for (int k = 0; k < cislo; k++)
            {
                veta += newveta[k] + " ";
            }
        }

        public override string ToString()
        {
            return veta;
        }
    }
}
