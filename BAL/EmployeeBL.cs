using Data;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class EmployeeBL : IEmployeeBL
    {
        EmployeeRepository _employeRepo = new EmployeeRepository();
        public bool Create(Employee employee)
        {
            return _employeRepo.Create(employee);
        }

        public bool Delete(Employee employee)
        {
            return _employeRepo.Delete(employee);
        }

        public List<Employee> GetAll()
        {
            return _employeRepo.GetAll();
        }



        public bool Update(Employee employee)
        {
            return _employeRepo.Update(employee);
        }

        public List<Employee> GetById(int employeeId)
        {
            throw new NotImplementedException();
        }
    }
}
