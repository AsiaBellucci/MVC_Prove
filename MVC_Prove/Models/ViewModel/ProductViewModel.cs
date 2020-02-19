using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Prove.Models.ViewModel
{
    public class ProductViewModel
    {
        public int PesoMin { get; set; }

        public ProductViewModel(int peso)
        {
            PesoMin = peso;
        }

        
    }
}
