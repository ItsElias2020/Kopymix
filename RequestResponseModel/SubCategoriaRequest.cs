using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class SubCategoriaRequest
    {
        public int Id { get; set; }

        public string Descripcion { get; set; } = null!;

        public int IdCategoria { get; set; }

        //[ForeignKey("IdCategoria")]
        //[InverseProperty("SubCategoria")]
        //public virtual Categoria IdCategoriaNavigation { get; set; } = null!;

        //[InverseProperty("IdSubCategoriaNavigation")]
        //public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
    }
}
