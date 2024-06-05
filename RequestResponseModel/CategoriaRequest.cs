using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class CategoriaRequest
    {
        public int Id { get; set; }

        public string Descripcion { get; set; } = null!;

        //[InverseProperty("IdCategoriaNavigation")]
        //public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();

        //[InverseProperty("IdCategoriaNavigation")]
        //public virtual ICollection<SubCategoria> SubCategoria { get; set; } = new List<SubCategoria>();
    }
}
