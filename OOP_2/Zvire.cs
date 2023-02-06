using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    internal class Zvire
    {
        public string Druh { get; set; }

        public Zvire (string druh)
        {
            Druh = druh;
        }

        public virtual string UdelejZvuk()
        {
            return "";
        }
    }
}
