using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class EstadoPedidoRequest
    {
        public int Id { get; set; }

        public string Descripcion { get; set; } = null!;

        public string Campo { get; set; } = null!;

        //[InverseProperty("IdEstadoPedidoNavigation")]
        //public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
    }
}
