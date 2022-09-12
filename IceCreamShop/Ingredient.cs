using System;
using System.Collections.Generic;
using System.Text;

namespace IceCreamShop
{
    public abstract class Ingredient
    {
        public string Name { get; set; }
        public double Cost { get; set; }
        public List<string> Allergens { get; set; }

        public Ingredient(string name, double cost, List<string> allergens)
        {
            Name = name;
            Cost = cost;
            Allergens = allergens;
        }

        /*
        public override string ToString()
        {
            return "Name: " + Name + "\n" + "Cost: $" + Cost + "\n" + "Allergens: " + Allergens + "\n";
        }
        */

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (Allergens.Count > 0)
            {
                string allergenStr;
                sb.Append("(Allergens: ");
                foreach (var item in Allergens)
                {
                    sb.Append($"{item}, ");
                }
                sb.Remove(sb.Length - 2, 2);
                sb.Append(")");
                allergenStr = sb.ToString();
                sb.Clear();
                sb.AppendFormat("{0,-30} {1,-10:C2}\n{2,-50}", Name, Cost, allergenStr);
            }
            else
            {
                sb.AppendFormat("{0,-30} {1,-10:C2}", Name, Cost);
            }
            sb.Append(Environment.NewLine);
            return sb.ToString();
        }
    }
}
