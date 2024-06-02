using _3_MVCCRUDUsingEFDBFrist.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;


namespace _3_MVCCRUDUsingEFDBFrist.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product

        ProductDBContextClass _db = new ProductDBContextClass();
        public ActionResult Index(string Search, string Sort, int? Page)
        {

            List<Product> Products = _db.Products.ToList();

            ViewBag.NameSort = (Sort == "name") ? "name desc" : "name";
            ViewBag.PriceSort = (Sort == "Price") ? "Price desc" : "Price";

            if (!string.IsNullOrEmpty(Search)) //search box ke liye
            {
                Products = _db.Products.Where
               (p =>
                   p.Category.CategoryName.Contains(Search) ||
                   p.Price.ToString().Equals(Search) ||
                   p.Name.Contains(Search)
               ).ToList();
            }

            if (!string.IsNullOrEmpty(Sort))  // Sort 
            {
                switch (Sort)
                {
                    case "name":
                        Products = Products.OrderBy(p => p.Name).ToList();
                        break;
                    case "Price":
                        Products = Products.OrderBy(p => p.Name).ToList();
                        break;
                    case "Price desc":
                        Products = Products.OrderByDescending(p => p.Name).ToList();
                        break;
                    default:
                        Products = Products.OrderByDescending(p => p.Name).ToList();
                        break;
                }
            }


            return View(Products.ToPagedList(Page ?? 1, 3)); //pagenation  import two packeges pagedlist and pagedlist.mvc

        }



        [HttpGet]
        public ActionResult Delete(int? id)
        {
            var Products = _db.Products.Find(id);
            return View(Products);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult ConfirmDelete(int? Id)
        {
            var Product = _db.Products.Find(Id);
            _db.Products.Remove(Product);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Details(int? id)
        {
            Product products = _db.Products.Find(id);
            return View(products);
        }


        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Category = _db.Categories.ToList().
                Select(c => new SelectListItem()
                {
                    Text = c.CategoryName,
                    Value = c.CategoryId.ToString()
                });

            return View();
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            try
            {
                product.CreateDate = DateTime.Now;
                if (product.Image != null && product.Image.ContentLength > 0)
                {
                    string fileName = product.Image.FileName;
                    string folderPath = Server.MapPath("~/Images");

                    string filePath = Path.Combine(folderPath, fileName);
                    product.Image.SaveAs(filePath);

                    product.ImagePath = $"/Images/{fileName}";
                }


                _db.Products.Add(product);
                _db.SaveChanges();
                return RedirectToAction("Index");

            }
            catch
            {
                return View(product);
            }

        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            Product products = _db.Products.Find(id);

            ViewBag.Category = _db.Categories.ToList().
                Select(c => new SelectListItem()
                {
                    Text = c.CategoryName,
                    Value = c.CategoryId.ToString()
                });

            return View(products);
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            try
            {
                Product dbProduct = _db.Products.Find(product.Id);
                dbProduct.Name = product.Name;
                dbProduct.Price = product.Price;
                dbProduct.CategoryId = product.CategoryId;

                if (product.Image != null && product.Image.ContentLength > 0)
                {
                    string fileName = product.Image.FileName;
                    string folderPath = Server.MapPath("~/Images");

                    string filePath = Path.Combine(folderPath, fileName);
                    product.Image.SaveAs(filePath);

                    dbProduct.ImagePath = $"/Images/{fileName}";

                }

                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(product);
            }
        }

        [HttpPost]
        public ActionResult DeleteMultiple(IEnumerable<int> ProductToDelete)
        {
            foreach (var id in ProductToDelete)
            {
                var product = _db.Products.Find(id);
                _db.Products.Remove(product);
                _db.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}