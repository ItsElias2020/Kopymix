using AutoMapper;
using BDKopymixModel;
using IBussnies;
using IRepository;
using IServices;
using Repository;
using RequestResponseModel;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussnies
{
    public class PersonaBussnies : IPersonaBussnies
    {
        //INYECCIÓN DE DEPENDECIAS/
        #region DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE
        private readonly IPersonaRepository _PersonaRepository;
        private readonly IMapper _mapper;
        private readonly IApisPeruServices _apisPeruServices;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mapper"></param>
        public PersonaBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _PersonaRepository = new PersonaRepository();
            _apisPeruServices = new ApisPeruServices();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE

        #region START CRUD METHODS
        public List<PersonaResponse> GetAll()
        {
            List<Persona> Personas = _PersonaRepository.GetAll();
            List<PersonaResponse> lstResponse = _mapper.Map<List<PersonaResponse>>(Personas);
            return lstResponse;
        }

        public PersonaResponse GetById(int id)
        {
            Persona Persona = _PersonaRepository.GetById(id);
            PersonaResponse resul = _mapper.Map<PersonaResponse>(Persona);
            return resul;
        }

        public PersonaResponse Create(PersonaRequest entity)
        {
            Persona Persona = _mapper.Map<Persona>(entity);
            Persona = _PersonaRepository.Create(Persona);
            PersonaResponse result = _mapper.Map<PersonaResponse>(Persona);
            return result;
        }
        public List<PersonaResponse> CreateMultiple(List<PersonaRequest> lista)
        {
            List<Persona> Personas = _mapper.Map<List<Persona>>(lista);
            Personas = _PersonaRepository.CreateMultiple(Personas);
            List<PersonaResponse> result = _mapper.Map<List<PersonaResponse>>(Personas);
            return result;
        }

        public PersonaResponse Update(PersonaRequest entity)
        {



            Persona PersonaRequest = _mapper.Map<Persona>(entity);
            PersonaResponse PersonaOld = GetById(entity.Id);

            PersonaRequest.UsuarioCrea = PersonaOld.UsuarioCrea;
            PersonaRequest.FechaActualiza = PersonaOld.FechaActualiza;

            PersonaRequest = _PersonaRepository.Update(PersonaRequest);
            PersonaResponse result = _mapper.Map<PersonaResponse>(PersonaRequest);
            return result;
        }

        public List<PersonaResponse> UpdateMultiple(List<PersonaRequest> lista)
        {
            List<Persona> Personas = _mapper.Map<List<Persona>>(lista);
            Personas = _PersonaRepository.UpdateMultiple(Personas);
            List<PersonaResponse> result = _mapper.Map<List<PersonaResponse>>(Personas);
            return result;
        }

        public int Delete(int id)
        {
            int cantidad = _PersonaRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<PersonaRequest> lista)
        {
            List<Persona> Personas = _mapper.Map<List<Persona>>(lista);
            int cantidad = _PersonaRepository.DeleteMultipleItems(Personas);
            return cantidad;
        }

        public List<VPersonaUbigeo> ObtenerTodosConUbigeo()
        {
            List<VPersonaUbigeo> lst = _PersonaRepository.ObtenerTodosConUbigeo();
            return lst;
        }


        public GenericFilterResponse<PersonaResponse> GetByFilter(GenericFilterRequest request)
        {
            throw new NotImplementedException();
        }

        #endregion END CRUD METHODS
        public VPersona GetByTipoNroDocumento(string tipoDocumento, string NroDocumento)
        {
            VPersona vPersona = _PersonaRepository.GetByTipoNroDocumento(tipoDocumento, NroDocumento);

            if (vPersona == null || vPersona.Id == 0)
            {
                if (tipoDocumento.ToLower() == "dni")
                {
                    ApisPeruPersonaResponse pres = _apisPeruServices.PersonaPorDNI(NroDocumento);
                    if (pres.success)
                    {
                        vPersona = new VPersona();
                        vPersona.NroDocumento = pres.dni;
                        vPersona.ApellidoMaterno = pres.apellidoMaterno;
                        vPersona.ApellidoPaterno = pres.apellidoPaterno;
                        vPersona.Nombre = pres.nombres;
                    }
                }
                else
                {
                    ApisPeruEmpresaResponse pres = _apisPeruServices.EmpresaPorRUC(NroDocumento);
                    //
                }
                //tengo que consumir el web service de APIS Peru
            }
            return vPersona;
        }
    }
}
