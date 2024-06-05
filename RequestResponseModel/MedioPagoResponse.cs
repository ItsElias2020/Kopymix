using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class MedioPagoResponse
    {
        public int Id { get; set; }

        public string Descripcion { get; set; } = null!;

        public string Titular { get; set; } = null!;

        //[InverseProperty("IdMedioPagoNavigation")]
        //public virtual ICollection<PedidoDetallePago> PedidoDetallePagos { get; set; } = new List<PedidoDetallePago>();
    }
}
