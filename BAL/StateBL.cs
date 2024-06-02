using Data;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class StateBL : IStateBL
    {
        StateRepository _stateRepo = new StateRepository();
        public List<State> GetAll()
        {
            return _stateRepo.GetAll();
        }
    }
}
