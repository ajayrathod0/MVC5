using MVCAuthentication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAuthentication.Common
{
    public class CurtomAuthorizeAttribute : AuthorizeAttribute
    {
        ProductDBContext _db = new ProductDBContext();
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            var userId = _db.Users.FirstOrDefault(u => u.Email == HttpContext.Current.User.Identity.Name)?.UserId;
            var userRoleId = _db.UserRoles.FirstOrDefault(ur => ur.UserId == userId)?.RoleId;
            var userRole = _db.Roles.Find(userRoleId)?.RoleName ?? "Guest";

            return Roles.Contains(userRole);
        }


    }
}