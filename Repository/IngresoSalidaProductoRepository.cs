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
    public class IngresoSalidaProductoRepository : CRUDRepository<IngresoSalidaProducto>, IIngresoSalidaProductoRepository
    {

        public GenericFilterResponse<IngresoSalidaProducto> GetByFilter(GenericFilterRequest request)
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
                        case "tipo":
                            query = query.Where(x => x.Tipo.ToLower().Contains(j.Value.ToLower()));
                            break;
                        case "idProducto":
                            query = query.Where(x => x.IdProducto == int.Parse(j.Value));
                            break;
                        case "cantidadIngreso":
                            query = query.Where(x => x.CantidadIngreso == decimal.Parse(j.Value));
                            break;
                        case "cantidadSalida":
                            query = query.Where(x => x.CantidadSalida == decimal.Parse(j.Value));
                            break;
                        case "fechaRegistro":
                            query = query.Where(x => x.FechaRegistro == DateTime.Parse(j.Value));
                            break;
                        case "fechaBoleta":
                            query = query.Where(x => x.FechaBoleta == DateTime.Parse(j.Value));
                            break;
                        case "idComprobantePago":
                            query = query.Where(x => x.IdComprobantePago == int.Parse(j.Value));
                            break;
                        case "nroSerie":
                            query = query.Where(x => x.NroSerie.ToLower().Contains(j.Value.ToLower()));
                            break;
                        case "idEmpresa":
                            query = query.Where(x => x.IdEmpresa == int.Parse(j.Value));
                            break;
                        case "precioUnitario":
                            query = query.Where(x => x.PrecioUnitario == decimal.Parse(j.Value));
                            break;
                        case "precioTotal":
                            query = query.Where(x => x.PrecioTotal == decimal.Parse(j.Value));
                            break;
                    }
                }
            });

            GenericFilterResponse<IngresoSalidaProducto> res = new GenericFilterResponse<IngresoSalidaProducto>();

            res.TotalRegistros = query.Count();
            res.Lista = query
                //.Include(x => x.Status)
                .Skip((request.NumeroPagina - 1) * request.Cantidad).Take(request.Cantidad)
                .OrderBy(x => x.IdProducto)
                .ToList();

            return res;
        }

    }
}
