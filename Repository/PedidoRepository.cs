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
    public class PedidoRepository : CRUDRepository<Pedido>, IPedidoRepository
    {
        public GenericFilterResponse<Pedido> GetByFilter(GenericFilterRequest request)
        {
            var query = db.Pedidos.Where(x => x.Id == x.Id);
            request.Filtros.ForEach(j =>
            {
                if (!string.IsNullOrEmpty(j.Value))
                {
                    switch (j.Name)
                    {
                        case "id":
                            query = query.Where(x => x.Id == int.Parse(j.Value));
                            break;
                        case "fecha":
                            query = query.Where(x => x.Fecha == DateTime.Parse(j.Value));
                            break;
                        case "estadoPagado":
                            query = query.Where(x => x.EstadoPagado == bool.Parse(j.Value));
                            break;
                        case "montoTotal":
                            query = query.Where(x => x.MontoTotal == decimal.Parse(j.Value));
                            break;
                        case "montoPagado":
                            query = query.Where(x => x.MontoPagado == decimal.Parse(j.Value));
                            break;
                        case "montoPorPagar":
                            query = query.Where(x => x.MontoPorPagar == decimal.Parse(j.Value));
                            break;
                        case "nroSerie":
                            query = query.Where(x => x.NroSerie.ToLower().Contains(j.Value.ToLower()));
                            break;
                        case "igv":
                            query = query.Where(x => x.Igv == int.Parse(j.Value));
                            break;
                        case "idCliente":
                            query = query.Where(x => x.IdCliente == int.Parse(j.Value));
                            break;
                        case "idEstadoPedido":
                            query = query.Where(x => x.IdEstadoPedido == int.Parse(j.Value));
                            break;
                        case "idDireccion":
                            query = query.Where(x => x.IdDireccion == int.Parse(j.Value));
                            break;
                        case "idComprobantePago":
                            query = query.Where(x => x.IdComprobantePago == int.Parse(j.Value));
                            break;
                        case "idUsuario":
                            query = query.Where(x => x.IdUsuario == int.Parse(j.Value));
                            break;


                    }
                }
            });

            GenericFilterResponse<Pedido> res = new GenericFilterResponse<Pedido>();

            res.TotalRegistros = query.Count();
            res.Lista = query
                .Skip((request.NumeroPagina - 1) * request.Cantidad).Take(request.Cantidad)
                .OrderBy(x => x.IdCliente)
                .ToList();

            return res;
        }

    }
}
