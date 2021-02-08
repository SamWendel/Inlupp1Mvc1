using Inlupp1Mvc1.Data;
using Inlupp1Mvc1.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inlupp1Mvc1.Controllers
{
    public class BaseController : Controller
    {
        protected readonly ApplicationDbContext _dbContext;

        public BaseController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            ViewData["AllaProdukter"] = _dbContext.Products
                .Select(dbProd => new ProductViewModel
                {
                    Id = dbProd.Id,
                    Name = dbProd.Name,
                    Description = dbProd.Description,
                    Price = dbProd.Price,
                    Category_id = dbProd.Category_id
                }).ToList();
            base.OnActionExecuting(context);
        }
    }
}
