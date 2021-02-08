using Inlupp1Mvc1.Data;
using Inlupp1Mvc1.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inlupp1Mvc1.Controllers
{
    public class ProductController : BaseController
    {

       public ProductController(ApplicationDbContext dbContext)
       : base(dbContext)
        {
        }

        public IActionResult ProductIndex(string q)
        {
            var viewModel = new ProductIndexViewModel();

            viewModel.ProductsList = _dbContext.Products
                .Where(r => q == null || r.Name.Contains(q))
                .Select(dbProduct => new ProductViewModel
                {
                    Id = dbProduct.Id,
                    Name = dbProduct.Name,
                    Description = dbProduct.Description,
                    Price = dbProduct.Price,
                    Category_id = dbProduct.Category_id,
                    Image = dbProduct.Image
                }).ToList();

            return View(viewModel);
        }
    }
}
