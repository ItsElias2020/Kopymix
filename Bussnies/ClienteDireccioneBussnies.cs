using AutoMapper;
using BDKopymixModel;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Vml.Office;
using IBussnies;
using IRepository;
using Repository;
using RequestResponseModel;
using System.Collections.Generic;

namespace Bussnies
{
    public class ClienteDireccioneBussnies : IClienteDireccioneBussnies
    {
        ///INYECCIÓN DE DEPENDECIAS/
        #region DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE
        private readonly IClienteDireccioneRepository _ClienteDireccioneRepository;
        private readonly IMapper _mapper;
        public ClienteDireccioneBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _ClienteDireccioneRepository = new ClienteDireccioneRepository();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE

        #region START CRUD METHODS
        public List<ClienteDireccioneResponse> GetAll()
        {
            List<ClienteDireccione> ClienteDirecciones = _ClienteDireccioneRepository.GetAll();
            List<ClienteDireccioneResponse> lstResponse = _mapper.Map<List<ClienteDireccioneResponse>>(ClienteDirecciones);
            return lstResponse;
        }

        public ClienteDireccioneResponse GetById(int id)
        {
            ClienteDireccione ClienteDireccione = _ClienteDireccioneRepository.GetById(id);
            ClienteDireccioneResponse resul = _mapper.Map<ClienteDireccioneResponse>(ClienteDireccione);
            return resul;
        }

        public ClienteDireccioneResponse Create(ClienteDireccioneRequest entity)
        {
            ClienteDireccione ClienteDireccione = _mapper.Map<ClienteDireccione>(entity);
            ClienteDireccione = _ClienteDireccioneRepository.Create(ClienteDireccione);
            ClienteDireccioneResponse result = _mapper.Map<ClienteDireccioneResponse>(ClienteDireccione);
            return result;
        }
        public List<ClienteDireccioneResponse> CreateMultiple(List<ClienteDireccioneRequest> lista)
        {
            List<ClienteDireccione> ClienteDirecciones = _mapper.Map<List<ClienteDireccione>>(lista);
            ClienteDirecciones = _ClienteDireccioneRepository.CreateMultiple(ClienteDirecciones);
            List<ClienteDireccioneResponse> result = _mapper.Map<List<ClienteDireccioneResponse>>(ClienteDirecciones);
            return result;
        }

        public ClienteDireccioneResponse Update(ClienteDireccioneRequest entity)
        {
            ClienteDireccione ClienteDireccione = _mapper.Map<ClienteDireccione>(entity);
            ClienteDireccione = _ClienteDireccioneRepository.Update(ClienteDireccione);
            ClienteDireccioneResponse result = _mapper.Map<ClienteDireccioneResponse>(ClienteDireccione);
            return result;
        }

        public List<ClienteDireccioneResponse> UpdateMultiple(List<ClienteDireccioneRequest> lista)
        {
            List<ClienteDireccione> ClienteDirecciones = _mapper.Map<List<ClienteDireccione>>(lista);
            ClienteDirecciones = _ClienteDireccioneRepository.UpdateMultiple(ClienteDirecciones);
            List<ClienteDireccioneResponse> result = _mapper.Map<List<ClienteDireccioneResponse>>(ClienteDirecciones);
            return result;
        }

        public int Delete(int id)
        {
            int cantidad = _ClienteDireccioneRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<ClienteDireccioneRequest> lista)
        {
            List<ClienteDireccione> ClienteDirecciones = _mapper.Map<List<ClienteDireccione>>(lista);
            int cantidad = _ClienteDireccioneRepository.DeleteMultipleItems(ClienteDirecciones);
            return cantidad;
        }

        public GenericFilterResponse<ClienteDireccioneResponse> GetByFilter(GenericFilterRequest request)
        {

            GenericFilterResponse<ClienteDireccioneResponse> result = _mapper.Map<GenericFilterResponse<ClienteDireccioneResponse>>(_ClienteDireccioneRepository.GetByFilter(request));

            return result;
        }
        #endregion END CRUD METHODS
    }
}
