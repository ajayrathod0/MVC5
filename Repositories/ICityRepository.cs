using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ICityRepository
    {
        bool Create(City city);

        List<City> GetAllByDistrictId(int districtId);

        List<City> GetAll();
    }
}
