using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IDistrictRepository
    {
        List<District> GetAll();

        List<District> GetByDistrictId(int stateId); 
    }
}
