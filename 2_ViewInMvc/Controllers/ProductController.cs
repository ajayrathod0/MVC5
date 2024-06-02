using _2_ViewInMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2_ViewInMvc.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            List<Product> products = new List<Product>()
            {
                 new Product(){ Id = 101, Name = "Shirt", Price = 299 },
                new Product(){ Id = 102, Name = "T-Shirt", Price = 999},
                new Product(){ Id = 103, Name = "Shoes", Price = 500},
            };
            TempData["products"] = products;

            return View(products);
        }

        public ActionResult Create()
        {

            return View();
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            List<Product> products = (List<Product>)TempData.Peek("products");

            Product product = products.FirstOrDefault(p => p.Id == id);

            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(int? id, Product updatedata)
        {
            List<Product> products = (List<Product>)TempData.Peek("products");

            Product product = products.FirstOrDefault(p => p.Id == id);

            product.Name = updatedata.Name;
            product.Price = updatedata.Price;

            return View(product);
        }
        [HttpGet]
        public ActionResult Delete(int? id)
        {
           /* List<Product> products = (List<Product>)TempData.Peek("products");

            Product product = products.FirstOrDefault(p => p.Id == id);*/
           
            return View();
        }
    }
}