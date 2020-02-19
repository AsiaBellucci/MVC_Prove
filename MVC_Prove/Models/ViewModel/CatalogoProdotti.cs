using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Prove.Models.ViewModel
{
    public class CatalogoProdotti
    {
        public string Color { get; set; }
        public int Weight { get; set; }
        public string Variety { get; set; }
        public string Origin { get; set; }
        public CatalogoProdotti(string color, int weight, string variety, string origin)
        {
            Color = color;
            Weight = weight;
            Variety = variety;
            Origin = origin;
        }
    }
}
