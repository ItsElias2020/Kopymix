using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class ClienteRequest
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = null!;

        public string ApPaterno { get; set; } = null!;

        public string ApMaterno { get; set; } = null!;

        public string Correo { get; set; } = null!;

        public string Password { get; set; } = null!;

        public string NroCelular { get; set; } = null!;

        public int IdTipoDocumento { get; set; }

        public int? UsuarioCrea { get; set; }

        public int UsuarioActualiza { get; set; }

        public DateTime FechaCrea { get; set; }

        public DateTime FechaActualiza { get; set; }


    }
}
