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
    public class PedidoDetallePagoBussnies : IPedidoDetallePagoBussnies
    {
        ///INYECCIÓN DE DEPENDECIAS/
        #region DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE
        private readonly IPedidoDetallePagoRepository _PedidoDetallePagoRepository;
        private readonly IMapper _mapper;
        public PedidoDetallePagoBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _PedidoDetallePagoRepository = new PedidoDetallePagoRepository();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE

        #region START CRUD METHODS
        public List<PedidoDetallePagoResponse> GetAll()
        {
            List<PedidoDetallePago> PedidoDetallePagos = _PedidoDetallePagoRepository.GetAll();
            List<PedidoDetallePagoResponse> lstResponse = _mapper.Map<List<PedidoDetallePagoResponse>>(PedidoDetallePagos);
            return lstResponse;
        }

        public PedidoDetallePagoResponse GetById(int id)
        {
            PedidoDetallePago PedidoDetallePago = _PedidoDetallePagoRepository.GetById(id);
            PedidoDetallePagoResponse resul = _mapper.Map<PedidoDetallePagoResponse>(PedidoDetallePago);
            return resul;
        }

        public PedidoDetallePagoResponse Create(PedidoDetallePagoRequest entity)
        {
            PedidoDetallePago PedidoDetallePago = _mapper.Map<PedidoDetallePago>(entity);
            PedidoDetallePago = _PedidoDetallePagoRepository.Create(PedidoDetallePago);
            PedidoDetallePagoResponse result = _mapper.Map<PedidoDetallePagoResponse>(PedidoDetallePago);
            return result;
        }
        public List<PedidoDetallePagoResponse> CreateMultiple(List<PedidoDetallePagoRequest> lista)
        {
            List<PedidoDetallePago> PedidoDetallePagos = _mapper.Map<List<PedidoDetallePago>>(lista);
            PedidoDetallePagos = _PedidoDetallePagoRepository.CreateMultiple(PedidoDetallePagos);
            List<PedidoDetallePagoResponse> result = _mapper.Map<List<PedidoDetallePagoResponse>>(PedidoDetallePagos);
            return result;
        }

        public PedidoDetallePagoResponse Update(PedidoDetallePagoRequest entity)
        {
            PedidoDetallePago PedidoDetallePago = _mapper.Map<PedidoDetallePago>(entity);
            PedidoDetallePago = _PedidoDetallePagoRepository.Update(PedidoDetallePago);
            PedidoDetallePagoResponse result = _mapper.Map<PedidoDetallePagoResponse>(PedidoDetallePago);
            return result;
        }

        public List<PedidoDetallePagoResponse> UpdateMultiple(List<PedidoDetallePagoRequest> lista)
        {
            List<PedidoDetallePago> PedidoDetallePagos = _mapper.Map<List<PedidoDetallePago>>(lista);
            PedidoDetallePagos = _PedidoDetallePagoRepository.UpdateMultiple(PedidoDetallePagos);
            List<PedidoDetallePagoResponse> result = _mapper.Map<List<PedidoDetallePagoResponse>>(PedidoDetallePagos);
            return result;
        }

        public int Delete(int id)
        {
            int cantidad = _PedidoDetallePagoRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<PedidoDetallePagoRequest> lista)
        {
            List<PedidoDetallePago> PedidoDetallePagos = _mapper.Map<List<PedidoDetallePago>>(lista);
            int cantidad = _PedidoDetallePagoRepository.DeleteMultipleItems(PedidoDetallePagos);
            return cantidad;
        }

        public GenericFilterResponse<PedidoDetallePagoResponse> GetByFilter(GenericFilterRequest request)
        {

            GenericFilterResponse<PedidoDetallePagoResponse> result = _mapper.Map<GenericFilterResponse<PedidoDetallePagoResponse>>(_PedidoDetallePagoRepository.GetByFilter(request));

            return result;
        }
        #endregion END CRUD METHODS
    }
}
