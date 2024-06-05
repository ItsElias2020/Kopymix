using BDKopymixModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepository
{
    public interface IPersonaRepository : ICRUDRepository<Persona>
    {
        //declarar los metodos personalizados
        List<VPersonaUbigeo> ObtenerTodosConUbigeo();
        VPersona GetByTipoNroDocumento(string tipoDocumento, string NroDocumento);


    }
}
