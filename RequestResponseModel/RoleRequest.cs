using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class RoleRequest
    {
        public int Id { get; set; }
        [StringLength(100)]

        public string Descripcion { get; set; } = null!;
        [StringLength(30)]
        public string Funcion { get; set; } = null!;

        //[InverseProperty("IdRolNavigation")]
        //public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
    }
}
