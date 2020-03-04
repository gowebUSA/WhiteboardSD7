using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LangFeatures7.Models
{
    public static class MyExtensionMethods
    {
        public static decimal TotalPrices(this IEnumerable<Product> products)
        {
            //Page 87
            decimal total = 0;
            foreach (Product prod in products)
            {
                total += prod?.Price ?? 0;
            }
            return total;
        }
        //public static decimal TotalPrices(this ShoppingCart cartParam)
        //{
        //    //Page 85
        //    decimal total = 0;
        //    foreach (Product prod in cartParam.Products)
        //    {
        //        total += prod?.Price ?? 0;
        //    }
        //    return total;
        //}
    }
}
