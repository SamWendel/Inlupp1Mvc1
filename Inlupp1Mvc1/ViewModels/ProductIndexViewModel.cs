using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inlupp1Mvc1.ViewModels
{
    public class ProductIndexViewModel
    {
        public string q { get; set; }
        public List<ProductViewModel> ProductsList { get; set; } = new List<ProductViewModel>();
    }
}
