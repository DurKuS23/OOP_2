using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    internal class Ptak:Zvire
    {
        public Ptak (string druh) : base(druh)
        {

        }

        public override string UdelejZvuk()
        {
            return "Pí pí";
        }
    }
}
