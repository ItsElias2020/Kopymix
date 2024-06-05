using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class ProductoEmpresaRequest
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("idProducto")]
        public int IdProducto { get; set; }

        [Column("idEmpresa")]
        public int IdEmpresa { get; set; }

        //[ForeignKey("IdEmpresa")]
        //[InverseProperty("ProductoEmpresas")]
        //public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

        //[ForeignKey("IdProducto")]
        //[InverseProperty("ProductoEmpresas")]
        //public virtual Producto IdProductoNavigation { get; set; } = null!;
    }
}
