using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WorkingWithVS7.Models;

namespace WorkingWithVS7.Controllers
{
    public class HomeController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View(SimpleRepository.SharedRepository.Products
        //        .Where(p => p?.Price < 50));    // => / { return }   //Added ? to p to allow null values on page 147.
        //}
        SimpleRepository Repository = SimpleRepository.SharedRepository;
        public IActionResult Index() => View(Repository.Products
        .Where(p => p?.Price < 50));
        [HttpGet]
        public IActionResult AddProduct() => View(new Product());
        [HttpPost]
        public IActionResult AddProduct(Product p)
        {
            Repository.AddProduct(p);
            return RedirectToAction("Index");
        }
    }
}
