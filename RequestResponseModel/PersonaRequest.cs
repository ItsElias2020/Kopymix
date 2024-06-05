using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace RequestResponseModel
{
    public class PersonaRequest
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


        public int UsuarioCrea { get; set; } = 0;
        public DateTime FechaCrea { get; set; } = DateTime.Now;


        [JsonIgnore] // ==> no va a pedir los datos desde el request
        public int UsuarioActualiza { get; set; } = 0;
        //[JsonIgnore] // ==> no va a pedir los datos desde el request
        [JsonIgnore]
        public DateTime FechaActualiza { get; set; } = DateTime.Now;
    }
}



