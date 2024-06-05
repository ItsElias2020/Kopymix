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
    public class EstadoPedidoBussnies : IEstadoPedidoBussnies
    {
        ///INYECCIÓN DE DEPENDECIAS/
        #region DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE
        private readonly IEstadoPedidoRepository _EstadoPedidoRepository;
        private readonly IMapper _mapper;
        public EstadoPedidoBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _EstadoPedidoRepository = new EstadoPedidoRepository();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE

        #region START CRUD METHODS
        public List<EstadoPedidoResponse> GetAll()
        {
            List<EstadoPedido> EstadoPedidos = _EstadoPedidoRepository.GetAll();
            List<EstadoPedidoResponse> lstResponse = _mapper.Map<List<EstadoPedidoResponse>>(EstadoPedidos);
            return lstResponse;
        }

        public EstadoPedidoResponse GetById(int id)
        {
            EstadoPedido EstadoPedido = _EstadoPedidoRepository.GetById(id);
            EstadoPedidoResponse resul = _mapper.Map<EstadoPedidoResponse>(EstadoPedido);
            return resul;
        }

        public EstadoPedidoResponse Create(EstadoPedidoRequest entity)
        {
            EstadoPedido EstadoPedido = _mapper.Map<EstadoPedido>(entity);
            EstadoPedido = _EstadoPedidoRepository.Create(EstadoPedido);
            EstadoPedidoResponse result = _mapper.Map<EstadoPedidoResponse>(EstadoPedido);
            return result;
        }
        public List<EstadoPedidoResponse> CreateMultiple(List<EstadoPedidoRequest> lista)
        {
            List<EstadoPedido> EstadoPedidos = _mapper.Map<List<EstadoPedido>>(lista);
            EstadoPedidos = _EstadoPedidoRepository.CreateMultiple(EstadoPedidos);
            List<EstadoPedidoResponse> result = _mapper.Map<List<EstadoPedidoResponse>>(EstadoPedidos);
            return result;
        }

        public EstadoPedidoResponse Update(EstadoPedidoRequest entity)
        {
            EstadoPedido EstadoPedido = _mapper.Map<EstadoPedido>(entity);
            EstadoPedido = _EstadoPedidoRepository.Update(EstadoPedido);
            EstadoPedidoResponse result = _mapper.Map<EstadoPedidoResponse>(EstadoPedido);
            return result;
        }

        public List<EstadoPedidoResponse> UpdateMultiple(List<EstadoPedidoRequest> lista)
        {
            List<EstadoPedido> EstadoPedidos = _mapper.Map<List<EstadoPedido>>(lista);
            EstadoPedidos = _EstadoPedidoRepository.UpdateMultiple(EstadoPedidos);
            List<EstadoPedidoResponse> result = _mapper.Map<List<EstadoPedidoResponse>>(EstadoPedidos);
            return result;
        }

        public int Delete(int id)
        {
            int cantidad = _EstadoPedidoRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<EstadoPedidoRequest> lista)
        {
            List<EstadoPedido> EstadoPedidos = _mapper.Map<List<EstadoPedido>>(lista);
            int cantidad = _EstadoPedidoRepository.DeleteMultipleItems(EstadoPedidos);
            return cantidad;
        }

        public GenericFilterResponse<EstadoPedidoResponse> GetByFilter(GenericFilterRequest request)
        {

            GenericFilterResponse<EstadoPedidoResponse> result = _mapper.Map<GenericFilterResponse<EstadoPedidoResponse>>(_EstadoPedidoRepository.GetByFilter(request));

            return result;
        }
        #endregion END CRUD METHODS
    }
}
