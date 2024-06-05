using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RequestResponseModel
{
    public class TipoDocumentoRequest
    {

        public int Id { get; set; }

        [StringLength(30)]

        public string Descripcion { get; set; } = null!;

        //[InverseProperty("IdTipoDocumentoNavigation")]
        //public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();
    }
}