using BDKopymixModel;
using IRepository;
using RequestResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class PersonaRepository : CRUDRepository<Persona>, IPersonaRepository
    {
        public GenericFilterResponse<Persona> GetByFilter(GenericFilterRequest request)
        {
            throw new NotImplementedException();
        }


        public List<VPersonaUbigeo> ObtenerTodosConUbigeo()
        {
            List<VPersonaUbigeo> list = db.VPersonaUbigeos.ToList();
            return list;
        }
        public VPersona GetByTipoNroDocumento(string tipoDocumento, string NroDocumento)
        {
            VPersona vPersona = new VPersona();
            //tipoDocumento ==> RUC | DNI

            int tDocumento = 0;

            switch (tipoDocumento.ToLower())
            {
                case "dni": tDocumento = 1; break;
                case "ruc": tDocumento = 2; break;
                default:
                    return vPersona;
            }


#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            vPersona = db.VPersonas
                .Where(x => x.IdPersonaTipoDocumento == tDocumento)
                .Where(x => x.NroDocumento == NroDocumento)
                .FirstOrDefault()
                ;
            return vPersona;
        }


    }
}


