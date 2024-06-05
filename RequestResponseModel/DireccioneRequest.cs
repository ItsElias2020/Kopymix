using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class DireccioneRequest
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("departamento")]
        [StringLength(30)]
        public string Departamento { get; set; } = null!;

        [Column("provincia")]
        [StringLength(30)]
        public string Provincia { get; set; } = null!;

        [Column("distrito")]
        [StringLength(30)]
        public string Distrito { get; set; } = null!;

        //[InverseProperty("IdDireccionNavigation")]
        //public virtual ICollection<ClienteDireccione> ClienteDirecciones { get; set; } = new List<ClienteDireccione>();
    }
}
