using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2Registation.Models
{
    public class Product
    {
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public static Product[] GetProducts()
        {
            Product product1 = new Product()
            {
                Name = "Bong ro",
                Price = 110m
            };
            Product product2 = new Product()
            {
                Name = "Bong truyen",
                Price = 111m
            };
            Product[] pro = new Product[] { product1, product2 };
            return pro;
        }
    }
}
