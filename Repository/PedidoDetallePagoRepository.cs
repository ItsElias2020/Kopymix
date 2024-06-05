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
    public class PedidoDetallePagoRepository : CRUDRepository<PedidoDetallePago>, IPedidoDetallePagoRepository
    {

        public GenericFilterResponse<PedidoDetallePago> GetByFilter(GenericFilterRequest request)
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
                        case "idMedioPago":
                            query = query.Where(x => x.IdMedioPago == int.Parse(j.Value));
                            break;
                        case "montoPago":
                            query = query.Where(x => x.MontoPago == int.Parse(j.Value));
                            break;
                    }
                }
            });

            GenericFilterResponse<PedidoDetallePago> res = new GenericFilterResponse<PedidoDetallePago>();

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
