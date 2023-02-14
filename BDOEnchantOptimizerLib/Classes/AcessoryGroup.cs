using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDOEnchantOptimizerLib
{
    public class AcessoryGroup
    {
        public string Name { get; set; }
        public double PriceAcessory0 { get; set; }
        public double PriceAcessoryPri { get; set; }
        public double PriceAcessoryDuo { get; set; }
        public double PriceAcessoryTri { get; set; }
        public double PriceAcessoryTet { get; set; }
        public double PriceAcessoryPen { get; set; }
        public AcessoryGroup(string name, double priceAcessory0, double priceAcessoryPri, double priceAcessoryDuo, double priceAcessoryTri, double priceAcessoryTet, double priceAcessoryPen)
        {
            this.Name = name;
            this.PriceAcessory0 = priceAcessory0;
            PriceAcessoryPri = priceAcessoryPri;
            PriceAcessoryDuo = priceAcessoryDuo;
            PriceAcessoryTri = priceAcessoryTri;
            PriceAcessoryTet = priceAcessoryTet;
            PriceAcessoryPen = priceAcessoryPen;
        }

        public AcessoryGroup()
        {
        }        
    }
}
