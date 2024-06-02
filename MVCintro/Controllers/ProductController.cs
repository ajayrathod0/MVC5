using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCintro.Controllers
{
    [RoutePrefix("Product")]
    public class ProductController : Controller
    {
        // http://localhost/product  prefix kiya hai to esa url denge to call ho jayenga
        [Route("")]
        public string Getproduct()
        {
            return "<h1>All Product Avalible</h1> no product";
        }
        public EmptyResult Index()
        {
            return new EmptyResult();
        }
        public ContentResult Index1()
        {
            return Content("Hello");
        }
        public ContentResult Index2()
        {
            return Content("<h2>Index 2 Page</h2>", "text/html");
        }

        public RedirectResult Redirect()
        {
            return Redirect("http://www.google.com");
        }
        public JsonResult JsonResult()
        {
            string json = "{Id:10,'Name':'Ajay','City':'Pune'}";
            return Json(json, JsonRequestBehavior.AllowGet);
        }
    }
}