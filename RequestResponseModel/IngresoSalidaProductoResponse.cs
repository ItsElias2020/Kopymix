using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class IngresoSalidaProductoResponse
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("tipo")]
        [StringLength(10)]
        public string Tipo { get; set; } = null!;

        [Column("idProducto")]
        public int IdProducto { get; set; }

        [Column("cantidadIngreso", TypeName = "decimal(18, 0)")]
        public decimal CantidadIngreso { get; set; }

        [Column("cantidadSalida", TypeName = "decimal(18, 0)")]
        public decimal CantidadSalida { get; set; }

        [Column("fechaRegistro", TypeName = "date")]
        public DateTime FechaRegistro { get; set; }

        [Column("fechaBoleta", TypeName = "date")]
        public DateTime FechaBoleta { get; set; }

        [Column("idComprobantePago")]
        public int IdComprobantePago { get; set; }

        [Column("nroSerie")]
        [StringLength(7)]
        public string NroSerie { get; set; } = null!;

        [Column("idEmpresa")]
        public int IdEmpresa { get; set; }

        [Column("precioUnitario", TypeName = "decimal(18, 0)")]
        public decimal PrecioUnitario { get; set; }

        [Column("precioTotal", TypeName = "decimal(18, 0)")]
        public decimal PrecioTotal { get; set; }

        //[ForeignKey("IdComprobantePago")]
        //[InverseProperty("IngresoSalidaProductos")]
        //public virtual ComprobantePago IdComprobantePagoNavigation { get; set; } = null!;

        //[ForeignKey("IdEmpresa")]
        //[InverseProperty("IngresoSalidaProductos")]
        //public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

        //[ForeignKey("IdProducto")]
        //[InverseProperty("IngresoSalidaProductos")]
        //public virtual Producto IdProductoNavigation { get; set; } = null!;
    }
}
