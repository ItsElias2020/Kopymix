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
    public class ProductoEmpresaRepository : CRUDRepository<ProductoEmpresa>, IProductoEmpresaRepository
    {

        public GenericFilterResponse<ProductoEmpresa> GetByFilter(GenericFilterRequest request)
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
                        case "idProducto":
                            query = query.Where(x => x.IdProducto == int.Parse(j.Value));
                            break;
                        case "idEmpresa":
                            query = query.Where(x => x.IdEmpresa == int.Parse(j.Value));
                            break;
                    }
                }
            });

            GenericFilterResponse<ProductoEmpresa> res = new GenericFilterResponse<ProductoEmpresa>();

            res.TotalRegistros = query.Count();
            res.Lista = query
                //.Include(x => x.Status)
                .Skip((request.NumeroPagina - 1) * request.Cantidad).Take(request.Cantidad)
                .OrderBy(x => x.Id)
                .ToList();

            return res;
        }

    }
}
