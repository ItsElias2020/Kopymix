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
    public class SubCategoriaRepository : CRUDRepository<SubCategoria>, ISubCategoriaRepository
    {

        public GenericFilterResponse<SubCategoria> GetByFilter(GenericFilterRequest request)
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
                        case "descripcion":
                            query = query.Where(x => x.Descripcion.ToLower().Contains(j.Value.ToLower()));
                            break;
                        case "idCategoria":
                            query = query.Where(x => x.IdCategoria == int.Parse(j.Value));
                            break;
                    }
                }
            });

            GenericFilterResponse<SubCategoria> res = new GenericFilterResponse<SubCategoria>();

            res.TotalRegistros = query.Count();
            res.Lista = query
                //.Include(x => x.Status)
                .Skip((request.NumeroPagina - 1) * request.Cantidad).Take(request.Cantidad)
                .OrderBy(x => x.Descripcion)
                .ToList();

            return res;
        }

    }
}
