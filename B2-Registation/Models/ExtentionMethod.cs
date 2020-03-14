using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2Registation.Models
{
    public static class ExtentionMethod
    {
        public static decimal TotalPrice0(this ShoppingCart cart)
        {
            decimal total = 0;
            foreach(Product p in cart.pro)
            {
                total += p?.Price ?? 0;
            }
            return total;
        }
    }
}
