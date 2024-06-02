using _3_MVCCRUDUsingEFDBFrist.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _3_MVCCRUDUsingEFDBFrist.Controllers
{
    public class AccountController : Controller
    {
        ProductDBContextClass _db = new ProductDBContextClass();


        public ActionResult Listuser()
        {
            return View(_db.Users.ToList());
        }

        [HttpGet]
        public ActionResult Ragister()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Ragister(User user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _db.Users.Add(user);
                    _db.SaveChanges();

                    ViewBag.Massage = "User Created Successfully Login to use website";
                }
                else
                {
                    ViewBag.Massage = "Please Correct Input";
                }
            }
            catch
            {
                ViewBag.Massage = "Error in Creating User";
            }

            return View();
        }

        public JsonResult IsEmailExit(string Email)
        {
            bool isEmailExit = _db.Users.Any(u => u.Email.Equals(Email));
            return Json(!isEmailExit, JsonRequestBehavior.AllowGet);
        }
    }
}