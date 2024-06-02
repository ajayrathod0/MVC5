using Data;
using System.Collections.Generic;

namespace BAL
{
    internal interface ICityBL
    {
        bool Create(City city);
        List<City> GetAllByDistrictId(int districtId);
        List<City> GetAll();

    }
}
