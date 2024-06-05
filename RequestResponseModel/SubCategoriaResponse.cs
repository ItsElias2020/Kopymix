using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class SubCategoriaResponse
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
