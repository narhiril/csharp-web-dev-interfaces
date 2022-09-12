using System;
using System.Collections.Generic;

namespace IceCreamShop
{
    public class FlavorComparer : IComparer<Flavor>
    {
        /*
        public int Compare(Flavor x, Flavor y)
        {
            return String.Compare(x.Name, y.Name);
        }
        */

        public int Compare(Flavor x, Flavor y)
        {
            return x.Allergens.Count == y.Allergens.Count ? 0
                 : x.Allergens.Count > y.Allergens.Count ? 1
                 : -1;
        }
    }
}
