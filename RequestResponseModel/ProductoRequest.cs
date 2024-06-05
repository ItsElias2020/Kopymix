using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class ProductoRequest
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("idCategoria")]
        public int IdCategoria { get; set; }

        [Column("idSubCategoria")]
        public int IdSubCategoria { get; set; }

        [Column("codigo")]
        [StringLength(50)]
        
        public string Codigo { get; set; } = null!;

        [Column("calificacion")]
        public int Calificacion { get; set; }

        [Column("nombre")]
        [StringLength(150)]
        
        public string Nombre { get; set; } = null!;

        [Column("stock", TypeName = "decimal(18, 0)")]
        public decimal Stock { get; set; }

        [Column("foto")]
        [StringLength(200)]
        
        public string Foto { get; set; } = null!;

        [Column("marca")]
        [StringLength(200)]
        
        public string Marca { get; set; } = null!;

        [Column("modelo")]
        [StringLength(200)]
        
        public string Modelo { get; set; } = null!;

        [Column("precioCompra", TypeName = "decimal(18, 0)")]
        public decimal PrecioCompra { get; set; }

        [Column("precioVenta", TypeName = "decimal(18, 0)")]
        public decimal PrecioVenta { get; set; }

        [Column("descripcion")]
        [StringLength(150)]
        
        public string Descripcion { get; set; } = null!;

        [Column("estado")]
        public bool Estado { get; set; }

        //[ForeignKey("IdCategoria")]
        //[InverseProperty("Productos")]
        //public virtual Categoria IdCategoriaNavigation { get; set; } = null!;

        //[ForeignKey("IdSubCategoria")]
        //[InverseProperty("Productos")]
        //public virtual SubCategoria IdSubCategoriaNavigation { get; set; } = null!;

        //[InverseProperty("IdProductoNavigation")]
        //public virtual ICollection<IngresoSalidaProducto> IngresoSalidaProductos { get; set; } = new List<IngresoSalidaProducto>();

        //[InverseProperty("IdProductoNavigation")]
        //public virtual ICollection<PedidoDetalle> PedidoDetalles { get; set; } = new List<PedidoDetalle>();

        //[InverseProperty("IdProductoNavigation")]
        //public virtual ICollection<ProductoEmpresa> ProductoEmpresas { get; set; } = new List<ProductoEmpresa>();
    }
}
