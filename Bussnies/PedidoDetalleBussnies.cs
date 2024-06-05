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
    public class PedidoDetalleBussnies : IPedidoDetalleBussnies
    {
        ///INYECCIÓN DE DEPENDECIAS/
        #region DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE
        private readonly IPedidoDetalleRepository _PedidoDetalleRepository;
        private readonly IMapper _mapper;
        public PedidoDetalleBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _PedidoDetalleRepository = new PedidoDetalleRepository();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE

        #region START CRUD METHODS
        public List<PedidoDetalleResponse> GetAll()
        {
            List<PedidoDetalle> PedidoDetalles = _PedidoDetalleRepository.GetAll();
            List<PedidoDetalleResponse> lstResponse = _mapper.Map<List<PedidoDetalleResponse>>(PedidoDetalles);
            return lstResponse;
        }

        public PedidoDetalleResponse GetById(int id)
        {
            PedidoDetalle PedidoDetalle = _PedidoDetalleRepository.GetById(id);
            PedidoDetalleResponse resul = _mapper.Map<PedidoDetalleResponse>(PedidoDetalle);
            return resul;
        }

        public PedidoDetalleResponse Create(PedidoDetalleRequest entity)
        {
            PedidoDetalle PedidoDetalle = _mapper.Map<PedidoDetalle>(entity);
            PedidoDetalle = _PedidoDetalleRepository.Create(PedidoDetalle);
            PedidoDetalleResponse result = _mapper.Map<PedidoDetalleResponse>(PedidoDetalle);
            return result;
        }
        public List<PedidoDetalleResponse> CreateMultiple(List<PedidoDetalleRequest> lista)
        {
            List<PedidoDetalle> PedidoDetalles = _mapper.Map<List<PedidoDetalle>>(lista);
            PedidoDetalles = _PedidoDetalleRepository.CreateMultiple(PedidoDetalles);
            List<PedidoDetalleResponse> result = _mapper.Map<List<PedidoDetalleResponse>>(PedidoDetalles);
            return result;
        }

        public PedidoDetalleResponse Update(PedidoDetalleRequest entity)
        {
            PedidoDetalle PedidoDetalle = _mapper.Map<PedidoDetalle>(entity);
            PedidoDetalle = _PedidoDetalleRepository.Update(PedidoDetalle);
            PedidoDetalleResponse result = _mapper.Map<PedidoDetalleResponse>(PedidoDetalle);
            return result;
        }

        public List<PedidoDetalleResponse> UpdateMultiple(List<PedidoDetalleRequest> lista)
        {
            List<PedidoDetalle> PedidoDetalles = _mapper.Map<List<PedidoDetalle>>(lista);
            PedidoDetalles = _PedidoDetalleRepository.UpdateMultiple(PedidoDetalles);
            List<PedidoDetalleResponse> result = _mapper.Map<List<PedidoDetalleResponse>>(PedidoDetalles);
            return result;
        }

        public int Delete(int id)
        {
            int cantidad = _PedidoDetalleRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<PedidoDetalleRequest> lista)
        {
            List<PedidoDetalle> PedidoDetalles = _mapper.Map<List<PedidoDetalle>>(lista);
            int cantidad = _PedidoDetalleRepository.DeleteMultipleItems(PedidoDetalles);
            return cantidad;
        }

        public GenericFilterResponse<PedidoDetalleResponse> GetByFilter(GenericFilterRequest request)
        {

            GenericFilterResponse<PedidoDetalleResponse> result = _mapper.Map<GenericFilterResponse<PedidoDetalleResponse>>(_PedidoDetalleRepository.GetByFilter(request));

            return result;
        }
        #endregion END CRUD METHODS
    }
}
