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
    public class ClienteBussnies : IClienteBussnies
    {
        ///INYECCIÓN DE DEPENDECIAS/
        #region DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE
        private readonly IClienteRepository _ClienteRepository;
        private readonly IMapper _mapper;
        public ClienteBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _ClienteRepository = new ClienteRepository();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE

        #region START CRUD METHODS
        public List<ClienteResponse> GetAll()
        {
            List<Cliente> Clientes = _ClienteRepository.GetAll();
            List<ClienteResponse> lstResponse = _mapper.Map<List<ClienteResponse>>(Clientes);
            return lstResponse;
        }

        public ClienteResponse GetById(int id)
        {
            Cliente Cliente = _ClienteRepository.GetById(id);
            ClienteResponse resul = _mapper.Map<ClienteResponse>(Cliente);
            return resul;
        }

        public ClienteResponse Create(ClienteRequest entity)
        {
            Cliente Cliente = _mapper.Map<Cliente>(entity);
            Cliente = _ClienteRepository.Create(Cliente);
            ClienteResponse result = _mapper.Map<ClienteResponse>(Cliente);
            return result;
        }
        public List<ClienteResponse> CreateMultiple(List<ClienteRequest> lista)
        {
            List<Cliente> Clientes = _mapper.Map<List<Cliente>>(lista);
            Clientes = _ClienteRepository.CreateMultiple(Clientes);
            List<ClienteResponse> result = _mapper.Map<List<ClienteResponse>>(Clientes);
            return result;
        }

        public ClienteResponse Update(ClienteRequest entity)
        {
            Cliente Cliente = _mapper.Map<Cliente>(entity);
            Cliente = _ClienteRepository.Update(Cliente);
            ClienteResponse result = _mapper.Map<ClienteResponse>(Cliente);
            return result;
        }

        public List<ClienteResponse> UpdateMultiple(List<ClienteRequest> lista)
        {
            List<Cliente> Clientes = _mapper.Map<List<Cliente>>(lista);
            Clientes = _ClienteRepository.UpdateMultiple(Clientes);
            List<ClienteResponse> result = _mapper.Map<List<ClienteResponse>>(Clientes);
            return result;
        }

        public int Delete(int id)
        {
            int cantidad = _ClienteRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<ClienteRequest> lista)
        {
            List<Cliente> Clientes = _mapper.Map<List<Cliente>>(lista);
            int cantidad = _ClienteRepository.DeleteMultipleItems(Clientes);
            return cantidad;
        }

        public GenericFilterResponse<ClienteResponse> GetByFilter(GenericFilterRequest request)
        {

            GenericFilterResponse<ClienteResponse> result = _mapper.Map<GenericFilterResponse<ClienteResponse>>(_ClienteRepository.GetByFilter(request));

            return result;
        }
        #endregion END CRUD METHODS
    }
}
