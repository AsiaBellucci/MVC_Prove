using MVC_Prove.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Prove.Models.Services.Interfaces
{
    public interface IProductService
    {
        public int GetAppleMin();
        public ProductViewModel GetProduct();
    }
}
