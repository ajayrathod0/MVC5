using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class DistrictRepository : IDistrictRepository
    {
        EmployeeDBContext _db = new EmployeeDBContext();
        public List<District> GetAll()
        {
            var district = _db.Districts.ToList();
            return district;
        }

        public List<District> GetByDistrictId(int stateId) //state se lenge
        {
            var district = _db.Districts.Where(d => d.StateId == stateId)?.ToList();
            return district;
        }
    }
}
