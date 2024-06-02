using MVCAuthentication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAuthentication.Controllers
{
    public class ManagerController : Controller
    {
        ProductDBContext _db = new ProductDBContext();
        // GET: Manager
        public ActionResult Index()
        {
            var user = _db.Users.ToList();

            return View(user);












        }
    }
}