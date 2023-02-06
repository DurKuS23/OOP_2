using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    internal class ZpevnyPtak : Ptak
    {
        public ZpevnyPtak(string druh): base(druh)
        {

        }
        public override string UdelejZvuk()
        {
            return base.UdelejZvuk() + " la la ";
        }
    }
}
