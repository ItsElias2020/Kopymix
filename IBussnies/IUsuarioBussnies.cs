using BDKopymixModel;
using RequestResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBussnies
{
    public interface IUsuarioBussnies : ICRUDBussnies<UsuarioRequest, UsuarioResponse>
    {
        UsuarioResponse BuscarPorNombreUsuario(string username);

        VUsuario ObtenerVistaUsername(string username);
    }
}
