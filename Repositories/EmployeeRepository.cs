using Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        EmployeeDBContext _db = new EmployeeDBContext();
        public bool Create(Employee employee)
        {

            _db.Employees.Add(employee);
            _db.SaveChanges();
            return true;
        }

        public bool Delete(Employee employee)
        {
            var emp = _db.Employees.Find(employee);
            if (emp != null)
            {
                _db.Employees.Remove(employee);
                _db.SaveChanges();
            }
            return true;
        }

        public List<Employee> GetAll()
        {
            var employees = _db.Employees.ToList();
            return employees;
        }

        public Employee GetById(int id)
        {
            return _db.Employees.Find(id);
        }

        public bool Update(Employee employee)
        {
            _db.Entry(employee).State = EntityState.Modified;
            _db.SaveChanges();
            return true;
        }
    }
}
