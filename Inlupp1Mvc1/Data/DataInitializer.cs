using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inlupp1Mvc1.Data
{
    public class DataInitializer
    {
        public static void SeedData(ApplicationDbContext dbContext)
        {
            dbContext.Database.Migrate();
            SeedProductCategory(dbContext);
            SeedProduct(dbContext);
        }


        private static void SeedProductCategory(ApplicationDbContext dbContext)
        {
            var productCategory = dbContext.ProductCategories.FirstOrDefault(r => r.Name == "Bildskärmar");
            if (productCategory == null)
            {
                dbContext.ProductCategories.Add(new ProductCategory
                {
                    Name = "Bildskärmar"
                });
            }
            productCategory = dbContext.ProductCategories.FirstOrDefault(r => r.Name == "Datorer");
            if (productCategory == null)
            {
                dbContext.ProductCategories.Add(new ProductCategory
                {
                    Name = "Datorer"
                });
            }
            productCategory = dbContext.ProductCategories.FirstOrDefault(r => r.Name == "Konsoller");
            if (productCategory == null)
            {
                dbContext.ProductCategories.Add(new ProductCategory
                {
                    Name = "Konsoller"
                });
            }
            dbContext.SaveChanges();
        }


        private static void SeedProduct(ApplicationDbContext dbContext)
        {
            var product = dbContext.Products.FirstOrDefault(r => r.Name == "HP Z24n");
            if (product == null)
            {
                dbContext.Products.Add(new Product
                {
                    Name = "HP Z24n",
                    Price = 3795,
                    Description = "5ms, 1920x1200, DVI-D,DP 1.2, HDMI 1.4",
                    Category_id = 1,
                    Image = "https://www.komplett.se/img/p/2400/1005907_1.jpg"
                });
            }

            product = dbContext.Products.FirstOrDefault(r => r.Name == "HP P34hc");
            if (product == null)
            {
                dbContext.Products.Add(new Product
                {
                    Name = "HP P34hc",
                    Price = 5995,
                    Description = "3440x1440 VA, 5ms, 3500:1, HDMI/DP/USB-C(65w)",
                    Category_id = 1,
                    Image = "https://www.komplett.se/img/p/1271/1178616_1.jpg"
                });
            }

            product = dbContext.Products.FirstOrDefault(r => r.Name == "HP E24 G4");
            if (product == null)
            {
                dbContext.Products.Add(new Product
                {
                    Name = "HP E24 G4",
                    Price = 2390,
                    Description = "1920x1080 IPS, 5ms, 1000:1, VGA/HDMI/DP",
                    Category_id = 1,
                    Image = "https://www.komplett.se/img/p/1271/1177927_2.jpg"
                });
            }

            product = dbContext.Products.FirstOrDefault(r => r.Name == "Lenovo IdeaCentre G5");
            if (product == null)
            {
                dbContext.Products.Add(new Product
                {
                    Name = "Lenovo IdeaCentre G5",
                    Price = 8290,
                    Description = "Medelbudget gamingdator",
                    Category_id = 2,
                    Image = "https://www.komplett.se/img/p/2000/1167338_2.jpg"
                });
            }

            product = dbContext.Products.FirstOrDefault(r => r.Name == "HP Pavilion Gaming TG01-0140");
            if (product == null)
            {
                dbContext.Products.Add(new Product
                {
                    Name = "HP Pavilion Gaming TG01-0140",
                    Price = 11490,
                    Description = "Gamingdator",
                    Category_id = 2,
                    Image = "https://www.komplett.se/img/p/1271/1165535_2.jpg"
                });
            }

            product = dbContext.Products.FirstOrDefault(r => r.Name == "Acer Nitro N50-610");
            if (product == null)
            {
                dbContext.Products.Add(new Product
                {
                    Name = "Acer Nitro N50-610",
                    Price = 10990,
                    Description = "Gamingdator",
                    Category_id = 2,
                    Image = "https://www.komplett.se/img/p/761/1165542_2.jpg"
                });
            }

            product = dbContext.Products.FirstOrDefault(r => r.Name == "PlayStation 5");
            if (product == null)
            {
                dbContext.Products.Add(new Product
                {
                    Name = "PlayStation 5",
                    Price = 5990,
                    Description = "DualSense,3D ljud, anpassningsbara triggers, Ultra-high Speed SSD och Ray Tracing",
                    Category_id = 3,
                    Image = "https://www.komplett.se/img/p/3601/1111557.jpg"
                });
            }

            product = dbContext.Products.FirstOrDefault(r => r.Name == "Xbox Series X");
            if (product == null)
            {
                dbContext.Products.Add(new Product
                {
                    Name = "Xbox Series X",
                    Price = 5695,
                    Description = "AMD Zen 2, SSD, GDDR6 SDRAM, Ray-Tracing",
                    Category_id = 3,
                    Image = "https://www.komplett.se/img/p/1080/1132588_1.jpg"
                });
            }

            product = dbContext.Products.FirstOrDefault(r => r.Name == "Nintendo Switch 2019");
            if (product == null)
            {
                dbContext.Products.Add(new Product
                {
                    Name = "Nintendo Switch 2019",
                    Price = 3749,
                    Description = "Konsol 32 GB, grå kontroller, 4.5 - 9 timmars batteritid",
                    Category_id = 3,
                    Image = "https://www.komplett.se/img/p/2340/1168526.jpg"
                });
            }

            dbContext.SaveChanges();
        }
    }
}
