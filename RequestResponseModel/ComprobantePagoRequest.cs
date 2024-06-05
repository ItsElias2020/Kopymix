using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class ComprobantePagoRequest
    {
        public int Id { get; set; }

        public string Descripcion { get; set; } = null!;

        //[InverseProperty("IdComprobantePagoNavigation")]
        //public virtual ICollection<IngresoSalidaProducto> IngresoSalidaProductos { get; set; } = new List<IngresoSalidaProducto>();

        //[InverseProperty("IdComprobantePagoNavigation")]
        //public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
    }
}
