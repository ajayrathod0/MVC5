using MVCAuthentication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVCAuthentication.Controllers
{
    public class AccountController : Controller
    {
        ProductDBContext _db = new ProductDBContext();
        // GET: Account
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User user)
        {
            user.IsActive = true;
            user.CreateDate = DateTime.Now;

            _db.Users.Add(user);
            _db.SaveChanges();

            UserRole userRole = new UserRole()
            {
                UserId = user.UserId,
                RoleId = 3 //by default jo add honga uski role id 3 hongi
            };

            _db.UserRoles.Add(userRole);
            _db.SaveChanges();


            return RedirectToAction("Index", "Products");
        }


        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {
                User user = _db.Users.Include("UserRoles").FirstOrDefault
                    (u =>
                    u.Email == loginModel.Email &&
                    u.PassWord == loginModel.Password
                    );
                if (user != null)
                {
                    FormsAuthentication.SetAuthCookie(user.Email, loginModel.RememberMe); //chackbox ke liye remember Me

                    if (user.UserRoles.Any(r => r.RoleId == 1))
                    {
                        return RedirectToAction("Index", "Manager");
                    }
                    else if (user.UserRoles.Any(u => u.RoleId == 2))
                    {
                        return RedirectToAction("Index", "Products");
                    }
                    else
                    {
                        return RedirectToAction("Index", "Products");
                    }
                }
                else
                {
                    ViewBag.Message = "Email and PassWord is Incorrect";
                    return View();
                }
            }
            return View();
        }

        [HttpGet]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}