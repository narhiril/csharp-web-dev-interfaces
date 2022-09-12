using System;
using System.Collections.Generic;
using System.Text;

namespace IceCreamShop
{
    public class ConeComparer : IComparer<Cone>
    {
        public int Compare(Cone x, Cone y)
        {
            return x.Cost == y.Cost ? 0
                 : x.Cost > y.Cost ? 1
                 : -1;
        }
    }
}
