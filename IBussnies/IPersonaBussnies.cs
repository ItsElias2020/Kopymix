using BDKopymixModel;
using RequestResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBussnies
{
    public interface IPersonaBussnies : ICRUDBussnies<PersonaRequest, PersonaResponse>
    {
        List<VPersonaUbigeo> ObtenerTodosConUbigeo();
        VPersona GetByTipoNroDocumento(string tipoDocumento, string NroDocumento);
    }
}
