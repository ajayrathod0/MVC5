using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class StateRepository : IStateRepository
    {
        EmployeeDBContext _db = new EmployeeDBContext();
        public List<State> GetAll()
        {
            var states = _db.States.ToList();
            return states;
        }
    }
}
