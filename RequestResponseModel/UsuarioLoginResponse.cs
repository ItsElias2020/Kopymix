using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class UsuarioLoginResponse
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int IdRol { get; set; }


    }
}
