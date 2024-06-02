using Data;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class DistrictBL : IDistrictBL
    {
        DistrictRepository _distRepo = new DistrictRepository();
        public List<District> GetAll()
        {
            return _distRepo.GetAll();
        }

        public List<District> GetAllByStateId(int stateId)
        {
            return _distRepo.GetByDistrictId(stateId);
        }
    }
}
