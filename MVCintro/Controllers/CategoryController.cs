using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCintro.Controllers
{
    public class CategoryController : Controller  //jab controller add karte hai to view m controller ke same ka folder create ho jata hai
    {
        /*public ActionResult Index() //ActionResult class base class all result class
        {
            return View();
        }*/

        public ViewResult AllCategory()
        {
            return View(); //by defult action method ka name se view dundenga same name
           //return View("Index1"); // agar name alag g action method se to view ko batana padenga
          // return View("~/Views/Student/index.cshtml"); //agar alag folder me view hai to path se batana padenga
        }
    }
}