using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class PedidoDetallePagoResponse
    {
        public int Id { get; set; }

        public int IdPedido { get; set; }

        public int IdMedioPago { get; set; }
        public int MontoPago { get; set; }

        //[ForeignKey("IdMedioPago")]
        //[InverseProperty("PedidoDetallePagos")]
        //public virtual MedioPago IdMedioPagoNavigation { get; set; } = null!;

        //[ForeignKey("IdPedido")]
        //[InverseProperty("PedidoDetallePagos")]
        //public virtual Pedido IdPedidoNavigation { get; set; } = null!;

        //[InverseProperty("IdPedidoDetallePagoNavigation")]
        //public virtual ICollection<MovimientosCaja> MovimientosCajas { get; set; } = new List<MovimientosCaja>();
    }
}
