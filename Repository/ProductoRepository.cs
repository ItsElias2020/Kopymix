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
    public class ProductoRepository : CRUDRepository<Producto>, IProductoRepository
    {

        public GenericFilterResponse<Producto> GetByFilter(GenericFilterRequest request)
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
                        case "idCategoria":
                            query = query.Where(x => x.IdCategoria == int.Parse(j.Value));
                            break;
                        case "idSubCategoria":
                            query = query.Where(x => x.IdSubCategoria == int.Parse(j.Value));
                            break;
                        case "codigo":
                            query = query.Where(x => x.Codigo.ToLower().Contains(j.Value.ToLower()));
                            break;
                        case "calificacion":
                            query = query.Where(x => x.Calificacion== int.Parse(j.Value));
                            break;
                        case "nombre":
                            query = query.Where(x => x.Nombre.ToLower().Contains(j.Value.ToLower()));
                            break;
                        case "marca":
                            query = query.Where(x => x.Marca.ToLower().Contains(j.Value.ToLower()));
                            break;
                        case "modelo":
                            query = query.Where(x => x.Modelo.ToLower().Contains(j.Value.ToLower()));
                            break;
                        case "precioCompra":
                            query = query.Where(x => x.PrecioCompra == decimal.Parse(j.Value));
                            break;
                        case "precioVenta":
                            query = query.Where(x => x.PrecioVenta == decimal.Parse(j.Value));
                            break;
                        case "descripcion":
                            query = query.Where(x => x.Descripcion.ToLower().Contains(j.Value.ToLower()));
                            break;
                    }
                }
            });

            GenericFilterResponse<Producto> res = new GenericFilterResponse<Producto>();

            res.TotalRegistros = query.Count();
            res.Lista = query
                //.Include(x => x.Status)
                .Skip((request.NumeroPagina - 1) * request.Cantidad).Take(request.Cantidad)
                .OrderBy(x => x.Nombre)
                .ToList();

            return res;
        }

    }
}
