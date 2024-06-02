using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _4_AreaAndFilters.Areas.user.Controllers
{
    public class HomeController : Controller
    {
        // GET: user/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}