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
    public class PedidoBussnies : IPedidoBussnies
    {
        ///INYECCIÓN DE DEPENDECIAS/
        #region DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE
        private readonly IPedidoRepository _PedidoRepository;
        private readonly IMapper _mapper;
        public PedidoBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _PedidoRepository = new PedidoRepository();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE

        #region START CRUD METHODS
        public List<PedidoResponse> GetAll()
        {
            List<Pedido> Pedidos = _PedidoRepository.GetAll();
            List<PedidoResponse> lstResponse = _mapper.Map<List<PedidoResponse>>(Pedidos);
            return lstResponse;
        }

        public PedidoResponse GetById(int id)
        {
            Pedido Pedido = _PedidoRepository.GetById(id);
            PedidoResponse resul = _mapper.Map<PedidoResponse>(Pedido);
            return resul;
        }

        public PedidoResponse Create(PedidoRequest entity)
        {
            Pedido Pedido = _mapper.Map<Pedido>(entity);
            Pedido = _PedidoRepository.Create(Pedido);
            PedidoResponse result = _mapper.Map<PedidoResponse>(Pedido);
            return result;
        }
        public List<PedidoResponse> CreateMultiple(List<PedidoRequest> lista)
        {
            List<Pedido> Pedidos = _mapper.Map<List<Pedido>>(lista);
            Pedidos = _PedidoRepository.CreateMultiple(Pedidos);
            List<PedidoResponse> result = _mapper.Map<List<PedidoResponse>>(Pedidos);
            return result;
        }

        public PedidoResponse Update(PedidoRequest entity)
        {
            Pedido Pedido = _mapper.Map<Pedido>(entity);
            Pedido = _PedidoRepository.Update(Pedido);
            PedidoResponse result = _mapper.Map<PedidoResponse>(Pedido);
            return result;
        }

        public List<PedidoResponse> UpdateMultiple(List<PedidoRequest> lista)
        {
            List<Pedido> Pedidos = _mapper.Map<List<Pedido>>(lista);
            Pedidos = _PedidoRepository.UpdateMultiple(Pedidos);
            List<PedidoResponse> result = _mapper.Map<List<PedidoResponse>>(Pedidos);
            return result;
        }

        public int Delete(int id)
        {
            int cantidad = _PedidoRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<PedidoRequest> lista)
        {
            List<Pedido> Pedidos = _mapper.Map<List<Pedido>>(lista);
            int cantidad = _PedidoRepository.DeleteMultipleItems(Pedidos);
            return cantidad;
        }

        public GenericFilterResponse<PedidoResponse> GetByFilter(GenericFilterRequest request)
        {

            GenericFilterResponse<PedidoResponse> result = _mapper.Map<GenericFilterResponse<PedidoResponse>>(_PedidoRepository.GetByFilter(request));

            return result;
        }
        #endregion END CRUD METHODS
    }
}
