using Data;
using Repositories;
using System.Collections.Generic;

namespace BAL
{
    public class CityBL : ICityBL
    {
        CityRepository _cityRepo = new CityRepository(); //Repository layer se
        public bool Create(City city)
        {
            return _cityRepo.Create(city);
        }

        public List<City> GetAll()
        {
            return _cityRepo.GetAll();
        }

        public List<City> GetAllByDistrictId(int districtId)
        {
            return _cityRepo.GetAllByDistrictId(districtId);
        }
    }
}
