using AutoMapper;
using BDKopymixModel;
using IBussnies;
using IRepository;
using Repository;
using RequestResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilSecurity;

namespace Bussnies
{
    public class AuthBussnies : IAuthBussnies
    {
        private readonly IUsuarioBussnies _usuarioBussnies;
        private readonly IMapper _mapper;
        private readonly IRoleBussnies _roleBussnies;
        private readonly UtilEncriptarDesencriptar _cripto;

        public AuthBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _usuarioBussnies = new UsuarioBussnies(mapper);
            _roleBussnies = new RoleBussnies(mapper);
            _cripto = new UtilEncriptarDesencriptar();
        }

        public LoginResponse Login(LoginRequest request)
        {
            LoginResponse result = new LoginResponse();
            VUsuario usuario = _usuarioBussnies.ObtenerVistaUsername(request.UserName);

            if (usuario == null)
            {
                return result;
            }

            string newPassword = _cripto.AES_encriptar(request.Password);

            if (newPassword != usuario.Password)
            {
                return result;
            }

            result.Success = true;
            result.Mensaje = "Login Correcto";

            result.Usuario = new UsuarioLoginResponse();
            result.Usuario.Id = usuario.IdUsuario;
            result.Usuario.Username = usuario.Username;
            result.Usuario.Password = usuario.Password;
            result.Role = new RoleResponse();
            result.Role.Id = usuario.IdRol;
            result.Role.Descripcion = usuario.Descripcion;
            result.Role.Funcion = usuario.Funcion;
            result.Cliente = new ClienteResponse();
            result.Cliente.Nombre = usuario.Nombre;




            return result;
        }
    }
}
