using _4_AreaAndFilters.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _4_AreaAndFilters.Controllers
{
    // [Authorize]
    public class HomeController : Controller
    {
        //[AllowAnonymous]
       // [HandleError] //without try catch block  = web.config me CustomError Mode on karna padenga   

        [TraceRequestsAttribute]
        public ActionResult Index() 
        {
           // throw new Exception("My Custom Exception");

            return View(); 
        }

        //[AllowAnonymous]
        // [ValidateInput(false)]
        public ActionResult PostComments(string comment)
        {
            ViewBag.Comment = comment;

            return View("PostComments");
        }


        // [OutputCache(Duration = 10)] //agar bahut sari file me karna hai cache to fir Web.Config se use karenge kuch changes
        //karna rahe time to web.config me change karenge to sare jagah time change ho jayenga
        [OutputCache(CacheProfile = "10SecCache")] //main web.config se
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.LoadedTime = DateTime.Now;  // caching ke liye
            
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [ChildActionOnly]
        public ActionResult LoginSection()
        {
            return PartialView("_LoginPartial"); //shared folder me 
        }

    }
}