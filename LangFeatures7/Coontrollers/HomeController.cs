using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LangFeatures7.Models;

namespace LangFeatures7.Coontrollers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            ShoppingCart cart
            = new ShoppingCart { Products = Product.GetProducts() };
            Product[] productArray = {
                new Product {Name = "Kayak", Price = 275M},
                new Product {Name = "Lifejacket", Price = 48.95M}
            };
            decimal cartTotal = cart.TotalPrices();
            decimal arrayTotal = productArray.TotalPrices();
            return View("Index", new string[] {
                $"Cart Total: {cartTotal:C2}",
                $"Array Total: {arrayTotal:C2}" });
        }
        public ViewResult Index7()
        {
            //Page 86
            ShoppingCart cart
            = new ShoppingCart { Products = Product.GetProducts() };
            decimal cartTotal = cart.TotalPrices();
            return View("Index", new string[] { $"Total: {cartTotal:C2}" });
        }
        public ViewResult Index6()
        {
            //Page 84
            object[] data = new object[] { 275M, 29.95M,
            "apple", "orange", 100, 10 };
            decimal total = 0;
            for (int i = 0; i < data.Length; i++)
            {
                switch (data[i])
                {
                    case decimal decimalValue:
                        total += decimalValue;
                        break;
                    case int intValue when intValue > 50:
                        total += intValue;
                        break;
                }
            }
            return View("Index", new string[] { $"Total: {total:C2}" });
        }
        public ViewResult Index5()
        {
            //Page 83
            object[] data = new object[] { 275M, 29.95M,
            "apple", "orange", 100, 10 };
            decimal total = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] is decimal d)
                {
                    total += d;
                }
            }
            return View("Index", new string[] { $"Total: {total:C2}" });
        }
        public ViewResult Index4()
        {
            //Page 82
            Dictionary<string, Product> products =
                new Dictionary<string, Product>
                {
                    //{"kayak", new Product{Name="Kayak", Price=375M} },
                    //{"lifejaket", new Product{ Name="PFD", Price=50.95M } }
                    ["Kayak"] = new Product { Name = "Kayak", Price = 275M },
                    ["Lifejacket"] = new Product { Name = "Lifejacket", Price = 48.95M }
                };
            return View("Index", products.Keys);
        }
        public ViewResult Index3()
        {
            string[] names = new string[3];
            names[0] = "Bob";
            names[1] = "Joe";
            names[2] = "Alice";
            return View("Index", names);
        }
        public ViewResult Index2()
        {
            //return View(new string[] { "C#", "Language", "Features" });
            List<string> results = new List<string>();
            foreach (Product p in Product.GetProducts())
            {
                string name = p?.Name;    // ? nullable
                decimal? price = p?.Price;
                string relatedItem = p?.Related?.Name ?? "<None>";         // ?? null coalescing operator
                results.Add(string.Format(
                    $"Name: {name}," +              //We use sring interppoaltion instead of using array positioning.
                    $"Price: {price}," + 
                    $"Related : {relatedItem}"));       //, name, price, relatedItem
            }
            return View(results);
        }
    } 
}
