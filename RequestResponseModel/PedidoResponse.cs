using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class PedidoResponse
    {
        public int Id { get; set; }

        public DateTime Fecha { get; set; }

        public bool EstadoPagado { get; set; }

        public bool Fiado { get; set; }

        public bool Delivery { get; set; }

        public decimal MontoTotal { get; set; }

        public decimal MontoPagado { get; set; }

        public decimal MontoPorPagar { get; set; }

        public string NroSerie { get; set; } = null!;

        public decimal Igv { get; set; }

        public int IdCliente { get; set; }

        public int IdEstadoPedido { get; set; }

        public int IdDireccion { get; set; }

        public int IdComprobantePago { get; set; }

        public int IdUsuario { get; set; }

        //[ForeignKey("IdCliente")]
        //[InverseProperty("Pedidos")]
        //public virtual Cliente IdClienteNavigation { get; set; } = null!;

        //[ForeignKey("IdComprobantePago")]
        //[InverseProperty("Pedidos")]
        //public virtual ComprobantePago IdComprobantePagoNavigation { get; set; } = null!;

        //[ForeignKey("IdDireccion")]
        //[InverseProperty("Pedidos")]
        //public virtual ClienteUbigeo IdDireccionNavigation { get; set; } = null!;

        //[ForeignKey("IdEstadoPedido")]
        //[InverseProperty("Pedidos")]
        //public virtual EstadoPedido IdEstadoPedidoNavigation { get; set; } = null!;

        //[ForeignKey("IdUsuario")]
        //[InverseProperty("Pedidos")]
        //public virtual Usuario IdUsuarioNavigation { get; set; } = null!;

        //[InverseProperty("IdPedidoNavigation")]
        //public virtual ICollection<PedidoDetallePago> PedidoDetallePagos { get; set; } = new List<PedidoDetallePago>();

        //[InverseProperty("IdPedidoNavigation")]
        //public virtual ICollection<PedidoDetalle> PedidoDetalles { get; set; } = new List<PedidoDetalle>();
    }
}

