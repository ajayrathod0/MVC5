using BAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeBL _bl = new EmployeeBL();
        StateBL _stateBl = new StateBL();
        DistrictBL _districtBL = new DistrictBL();
        CityBL _cityBL = new CityBL();

        // GET: Employee

        [HttpGet]
        public ActionResult Index()
        {
            List<Employee> employees = _bl.GetAll()?.Select(e => new Employee()
            {
                EmployeeId = e.EmployeeId,
                Name = e.Name,
                Address = e.Address,
                CityId = e.CityId,
                Mobile = e.Mobile,
                Salary = e.Salary,
                Designation = e.Designation,
                CreatedDate = e.CreatedDate,
                DeletedDate = e.DeletedDate,
                ModifiedDate = e.ModifiedDate,

            }).ToList();

            return View(employees);
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.States = _stateBl.GetAll().Select(s => new SelectListItem()
            {
                Text = s.StateName,
                Value = s.StateId.ToString()
            });

            ViewBag.Districs = _districtBL.GetAll().Select(d => new SelectListItem()
            {
                Text = d.DistrictName,
                Value = d.DistrictId.ToString()
            });

            ViewBag.Cities = _cityBL.GetAll().Select(c => new SelectListItem()
            {
                Text = c.CityName,
                Value = c.CityId.ToString()
            });

            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                Data.Employee emp = new Data.Employee()
                {
                    Name = employee.Name,
                    Designation = employee.Designation,
                    Salary = employee.Salary,
                    Address = employee.Address,
                    Mobile = employee.Mobile,
                    CreatedDate = DateTime.Now,
                    CityId = employee.CityId,

                };

                _bl.Create(emp);
                return RedirectToAction("Index");
            }

            return View();
        }


        [HttpGet]
        public ActionResult Edit(int? id)
        {
            var employee = _bl.GetAll().FirstOrDefault(e => e.EmployeeId == id);
            if (employee == null)
            {
                return HttpNotFound();
            }


            return View(employee);
        }

        [HttpPost]
        public ActionResult Edit(Employee employe) 
        {
           // _bl.Update(employe);
            return View();
        }


        [HttpGet]
        public ActionResult Delete(int? id)
        {
            var employee = _bl.GetAll().FirstOrDefault(e => e.EmployeeId == id);
            if (employee == null)
            {
                return HttpNotFound();
            }

            return View(employee);
        }

        [HttpPost]
        public ActionResult Delete(Data.Employee id) 
        {
            _bl.Delete(id);
            return RedirectToAction("Index");
        }


    }
}