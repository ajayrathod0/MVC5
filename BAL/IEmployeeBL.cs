using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public interface IEmployeeBL
    {
        List<Employee> GetAll();
        List<Employee> GetById(int employeeId);

        bool Create(Employee employee);
        bool Update(Employee employee);
        bool Delete(Employee employee);

    }
}
