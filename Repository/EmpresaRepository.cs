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
    public class EmpresaRepository : CRUDRepository<Empresa>, IEmpresaRepository
    {

        public GenericFilterResponse<Empresa> GetByFilter(GenericFilterRequest request)
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
                        case "ruc":
                            query = query.Where(x => x.Ruc.ToLower().Contains(j.Value.ToLower()));
                            break;
                        case "razonSocial":
                            query = query.Where(x => x.RazonSocial.ToLower().Contains(j.Value.ToLower()));
                            break;
                        case "telefono":
                            query = query.Where(x => x.Telefono.ToLower().Contains(j.Value.ToLower()));
                            break;
                        case "contacto":
                            query = query.Where(x => x.Contacto.ToLower().Contains(j.Value.ToLower()));
                            break;
                        case "email":
                            query = query.Where(x => x.Email.ToLower().Contains(j.Value.ToLower()));
                            break;
                    }
                }
            });

            GenericFilterResponse<Empresa> res = new GenericFilterResponse<Empresa>();

            res.TotalRegistros = query.Count();
            res.Lista = query
                //.Include(x => x.Status)
                .Skip((request.NumeroPagina - 1) * request.Cantidad).Take(request.Cantidad)
                .OrderBy(x => x.Ruc)
                .ToList();

            return res;
        }

    }
}
