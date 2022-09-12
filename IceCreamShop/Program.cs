using System;
using System.Collections.Generic;

namespace IceCreamShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Case menu = new Case();
            List<Flavor> availableFlavors = menu.Flavors;
            List<Cone> availableCones = menu.Cones;

            Console.WriteLine("*** Before sorting: ***" + Environment.NewLine + menu.ToString());

            availableFlavors.Sort(new FlavorComparer());
            availableCones.Sort(new ConeComparer());

            Console.WriteLine("*** After sorting: ***" + Environment.NewLine + menu.ToString());
            
        }
    }
}
