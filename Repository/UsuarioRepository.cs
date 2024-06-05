using BDKopymixModel;
using IRepository;
using Microsoft.EntityFrameworkCore;
using RequestResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UsuarioRepository : CRUDRepository<Usuario>, IUsuarioRepository
    {
        public GenericFilterResponse<Usuario> GetByFilter(GenericFilterRequest request)
        {
            throw new NotImplementedException();
        }

        public Usuario ObtenerPorUsername(string username)
        {
            Usuario usuario = dbSet.Where(x => x.Username.ToLower() == username.ToLower())
                //.Include(x => x.IdRolNavigation)
                //.Include(x => x.IdClienteNavigation)
                .FirstOrDefault();

            return usuario;
        }

        public VUsuario ObtenerVistaUsername(string username)
        {
            VUsuario vUsuario = db.VUsuarios.Where(x => x.Username.ToLower() == username.ToLower()).FirstOrDefault();
            return vUsuario;
        }
    }
}
