using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCintro.Controllers
{
    public class HomeController : Controller
    {
        public string Welcome()
        {
            return "My frist MVC Page ";
        }
        public string GetResult(int id)
        {
            return $"GetResult(int id) action method calledMY Id is {id} ";
        }
        public string GetEmployee(int id, string Name)
        {
            return $"Employee Id is {id} and Name {Name}";
        }
        
        [Route("Vhaash/home/{id}/{StudentName}")]
        public string GetStudent(int id, string StudentName)
        {
            return $"Employee Id is {id} and Name {StudentName}";
        }
    }
}