using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class MedioPagoRequest
    {
        public int Id { get; set; }

        public string Descripcion { get; set; } = null!;

        public string Titular { get; set; } = null!;

        //[InverseProperty("IdMedioPagoNavigation")]
        //public virtual ICollection<PedidoDetallePago> PedidoDetallePagos { get; set; } = new List<PedidoDetallePago>();

    }
}

