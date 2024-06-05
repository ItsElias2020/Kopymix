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
    public class ClienteDireccioneRepository : CRUDRepository<ClienteDireccione>, IClienteDireccioneRepository
    {

        public GenericFilterResponse<ClienteDireccione> GetByFilter(GenericFilterRequest request)
        {
            var query = dbSet.Where(x => x.Id == x.Id);
            request.Filtros.ForEach(j =>
            {
                if (!string.IsNullOrEmpty(j.Value))
                {
                    switch (j.Name)
                    {
                        case "id":
                            query = query.Where(x => x.Id == int.Parse(j.Value));
                            break;
                        case "idCliente":
                            query = query.Where(x => x.IdCliente == int.Parse(j.Value));
                            break;
                        case "idDireccion":
                            query = query.Where(x => x.IdDireccion == int.Parse(j.Value));
                            break;
                        case "calle":
                            query = query.Where(x => x.Calle.ToLower().Contains(j.Value.ToLower()));
                            break;
                        case "nro":
                            query = query.Where(x => x.Nro.ToLower().Contains(j.Value.ToLower()));
                            break;
                        case "referencia":
                            query = query.Where(x => x.Referencia.ToLower().Contains(j.Value.ToLower()));
                            break;
                    }
                }
            });

            GenericFilterResponse<ClienteDireccione> res = new GenericFilterResponse<ClienteDireccione>();

            res.TotalRegistros = query.Count();
            res.Lista = query
                //.Include(x => x.Status)
                .Skip((request.NumeroPagina - 1) * request.Cantidad).Take(request.Cantidad)
                .OrderBy(x => x.Calle)
                .ToList();

            return res;
        }

    }
}
