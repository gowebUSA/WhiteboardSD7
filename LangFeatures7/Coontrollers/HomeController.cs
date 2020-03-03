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
            Dictionary<string, Product> products =
                new Dictionary<string, Product>
                {
                    {"kayak", new Product{Name="Kayak", Price=375M} },
                    {"lifejaket", new Product{ Name="PFD", Price=50.95M } }
                };
            return View("Index", products.Keys);
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
        public ViewResult Index3()
        {
            string[] names = new string[3];
            names[0] = "Bob";
            names[1] = "Joe";
            names[2] = "Alice";
            return View("Index", names);
        }
    }
}
