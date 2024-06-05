using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class EmpresaRequest
    {
        public int Id { get; set; }

        public string Ruc { get; set; } = null!;

        public string RazonSocial { get; set; } = null!;

        public string Telefono { get; set; } = null!;

        public string Contacto { get; set; } = null!;

        public string Email { get; set; } = null!;

        //[InverseProperty("IdProveedorNavigation")]
        //public virtual ICollection<IngresoSalidaProducto> IngresoSalidaProductos { get; set; } = new List<IngresoSalidaProducto>();

        //[InverseProperty("IdProveedorNavigation")]
        //public virtual ICollection<ProductoProveedore> ProductoProveedores { get; set; } = new List<ProductoProveedore>();
    }
}
