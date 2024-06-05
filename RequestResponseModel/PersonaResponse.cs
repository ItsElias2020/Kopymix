using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class PersonaResponse
    {
        public int Id { get; set; }
        public short? IdPersonaTipoDocumento { get; set; }
        public short IdPersonaTipo { get; set; }
        public string? NroDocumento { get; set; }
        public string? Nombre { get; set; }
        public string? ApellidoPaterno { get; set; }
        public string? ApellidoMaterno { get; set; }
        public string? NombreCompleto { get; set; }
        public string? TipoSangre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public short IdGenero { get; set; }
        public string? Email { get; set; }
        public string? Celular { get; set; }
        public int? IdUbigeo { get; set; }
        public string? Direccion { get; set; }
        public bool? IdEstado { get; set; }
        public int UsuarioCrea { get; set; }
        public int UsuarioActualiza { get; set; }
        public DateTime FechaCrea { get; set; }
        public DateTime FechaActualiza { get; set; }
    }
}
