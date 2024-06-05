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
    public class PedidoDetalleRepository : CRUDRepository<PedidoDetalle>, IPedidoDetalleRepository
    {

        public GenericFilterResponse<PedidoDetalle> GetByFilter(GenericFilterRequest request)
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
                        case "idPedido":
                            query = query.Where(x => x.IdPedido == int.Parse(j.Value));
                            break;
                        case "idProducto":
                            query = query.Where(x => x.IdProducto == int.Parse(j.Value));
                            break;
                        case "cantidad":
                            query = query.Where(x => x.Cantidad == decimal.Parse(j.Value));
                            break;
                        case "precioUnitario":
                            query = query.Where(x => x.PrecioUnitario == decimal.Parse(j.Value));
                            break;
                        case "subTotal":
                            query = query.Where(x => x.SubTotal == decimal.Parse(j.Value));
                            break;
                        case "estado":
                            query = query.Where(x => x.Estado == bool.Parse(j.Value));
                            break;
                    }
                }
            });

            GenericFilterResponse<PedidoDetalle> res = new GenericFilterResponse<PedidoDetalle>();

            res.TotalRegistros = query.Count();
            res.Lista = query
                //.Include(x => x.Status)
                .Skip((request.NumeroPagina - 1) * request.Cantidad).Take(request.Cantidad)
                .OrderBy(x => x.IdPedido)
                .ToList();

            return res;
        }

    }
}
