using _2_ViewInMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2_ViewInMvc.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            List<Category> categories = new List<Category>() {
                new Category (){Id = 1, Name= "Jeans", Rating = 4 },
                new Category (){Id = 2, Name= "Shirt", Rating = 3 },
                new Category (){Id = 3, Name= "TShirt", Rating = 5 },
            };
            TempData["categories"] = categories;

            return View(categories);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        //  public ActionResult Create(string Name, string Rating)  //Simple type Parameter
        // public ActionResult Create(Category category) // using Model type Parameter
        public ActionResult Create(FormCollection form) // it is key value pair collenction
        {
            string name = form["Name"]; //  key ka name or input name attibute ka value ka name same honga tabi value yaha aayenga
            string rating = form["Rating"];
            return View();
        }

        [HttpGet]
        public ActionResult GetValue(string Catename)
        {
            return Redirect("Create");
        }

        public PartialViewResult GetPartial()
        {

            return PartialView("_PartialView",4000);
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            var categories = (List<Category>)TempData.Peek("categories");
            return View(categories.FirstOrDefault(c => c.Id == id));
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult SectionDelete(int? id)
        {
            return View();
        }
    }
}