using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class ClienteDireccioneRequest
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("idCliente")]
        public int IdCliente { get; set; }

        [Column("idDireccion")]
        public int IdDireccion { get; set; }

        [Column("calle")]
        [StringLength(30)]
        public string Calle { get; set; } = null!;

        [Column("nro")]
        [StringLength(5)]
        public string Nro { get; set; } = null!;

        [Column("referencia")]
        [StringLength(100)]
        public string Referencia { get; set; } = null!;

        //[ForeignKey("IdCliente")]
        //[InverseProperty("ClienteDirecciones")]
        //public virtual Cliente IdClienteNavigation { get; set; } = null!;

        //[ForeignKey("IdDireccion")]
        //[InverseProperty("ClienteDirecciones")]
        //public virtual Direccione IdDireccionNavigation { get; set; } = null!;

        //[InverseProperty("IdDireccionNavigation")]
        //public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
    }
}
