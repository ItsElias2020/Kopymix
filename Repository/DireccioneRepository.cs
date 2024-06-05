using BDKopymixModel;
using IRepository;
using RequestResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class DireccioneRepository : CRUDRepository<Direccione>, IDireccioneRepository
    {
        public GenericFilterResponse<Direccione> GetByFilter(GenericFilterRequest request)
        {
            throw new NotImplementedException();
        }
    }
}