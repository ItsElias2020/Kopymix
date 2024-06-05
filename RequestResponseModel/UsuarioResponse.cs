using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class UsuarioResponse
    {
        public int Id { get; set; }

        public string Username { get; set; } = null!;

        public string Password { get; set; } = null!;

        public int? UsuarioCrea { get; set; }

        public int UsuarioActualiz { get; set; }

        public DateTime FechaCrea { get; set; }

        public DateTime FechaActualiza { get; set; }

        public int IdRol { get; set; }

        public int IdCliente { get; set; }

        //[InverseProperty("IdUsuarioAperturaNavigation")]
        //public virtual ICollection<Caja> CajaIdUsuarioAperturaNavigations { get; set; } = new List<Caja>();

        //[InverseProperty("IdUsuarioCierreNavigation")]
        //public virtual ICollection<Caja> CajaIdUsuarioCierreNavigations { get; set; } = new List<Caja>();

        //[ForeignKey("IdRol")]
        //[InverseProperty("Usuarios")]
        //public virtual Role IdRolNavigation { get; set; } = null!;

        //[InverseProperty("IdUsuarioNavigation")]
        //public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
    }
}
