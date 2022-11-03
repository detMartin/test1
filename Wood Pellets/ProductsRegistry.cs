using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wood_Pellets
{
    public class ProductsRegistry
    {
        public static Pellets PremiumPellets = new Pellets(7000, "brand", "6mm", "premium", "4,93 kwh/kg", "4,5%", "info");
        public static Pellets GenericPellets = new Pellets(6000, "brand", "6mm", "generic", "4,3 kwh/kg", "5%", "info");
    }
}
