using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inlupp1Mvc1.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Category_id { get; set; }
        public string Image { get; set; }
    }
}
