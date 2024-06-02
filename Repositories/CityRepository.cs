using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CityRepository : ICityRepository
    {
        EmployeeDBContext _db = new EmployeeDBContext();

        public bool Create(City city)
        {
            try
            {
                _db.Cities.Add(city);
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<City> GetAll()
        {
            var Cities = _db.Cities.ToList();
            return Cities;

        }

        public List<City> GetAllByDistrictId(int districtId)
        {
            var cities = _db.Cities.Where(c => c.DistrictId == districtId)?.ToList();
            return cities;
        }
    }
}
