using _2_ViewInMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2_ViewInMvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewData["Name"] = "Ajay Rathod";
            ViewBag.Email = "ajayjathod@gmail.com";
            TempData["Address"] = "Mp me rahata hu me";

            return View();
        }
        public ActionResult Index2()
        {
            return View();

        }
        public ActionResult Index3()
        {
            int number = 100;
            return View(number);
        }
        public ActionResult Index4()
        {
            Product p = new Product() { Id = 101, Name = "Shirt", Price = 999 };

            return View(p);
        }

        public ActionResult Index5()
        {
            List<Product> list = new List<Product>()
            {
                new Product(){ Id = 101, Name = "Shirt", Price = 299 },
                new Product(){ Id = 102, Name = "T-Shirt", Price = 299},
                new Product(){ Id = 103, Name = "Shoes" , Price = 299}
            };

            return View(list);
        }
    }
}