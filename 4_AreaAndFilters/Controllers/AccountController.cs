using _4_AreaAndFilters.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _4_AreaAndFilters.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel user)
        {
            if (user.Username == "admin" && user.Password == "admin")
            {
                return RedirectToAction("Index", "Home", new { area = "admin" });
            }
            else if (user.Username == "seller" && user.Password == "seller")
            {
                return RedirectToAction("Index", "Home", new { area = "seller" });

            }
            else if (user.Username == "user" && user.Password == "user")
            {
                return RedirectToAction("Index", "Home", new { area = "user" });

            }
            else
            {
                return RedirectToAction("Index", "Home", new { area = "admin" });

            }
        }
    }
}