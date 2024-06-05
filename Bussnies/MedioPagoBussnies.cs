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
    public class MedioPagoBussnies : IMedioPagoBussnies
    {
        ///INYECCIÓN DE DEPENDECIAS/
        #region DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE
        private readonly IMedioPagoRepository _MedioPagoRepository;
        private readonly IMapper _mapper;
        public MedioPagoBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _MedioPagoRepository = new MedioPagoRepository();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE

        #region START CRUD METHODS
        public List<MedioPagoResponse> GetAll()
        {
            List<MedioPago> MedioPagos = _MedioPagoRepository.GetAll();
            List<MedioPagoResponse> lstResponse = _mapper.Map<List<MedioPagoResponse>>(MedioPagos);
            return lstResponse;
        }

        public MedioPagoResponse GetById(int id)
        {
            MedioPago MedioPago = _MedioPagoRepository.GetById(id);
            MedioPagoResponse resul = _mapper.Map<MedioPagoResponse>(MedioPago);
            return resul;
        }

        public MedioPagoResponse Create(MedioPagoRequest entity)
        {
            MedioPago MedioPago = _mapper.Map<MedioPago>(entity);
            MedioPago = _MedioPagoRepository.Create(MedioPago);
            MedioPagoResponse result = _mapper.Map<MedioPagoResponse>(MedioPago);
            return result;
        }
        public List<MedioPagoResponse> CreateMultiple(List<MedioPagoRequest> lista)
        {
            List<MedioPago> MedioPagos = _mapper.Map<List<MedioPago>>(lista);
            MedioPagos = _MedioPagoRepository.CreateMultiple(MedioPagos);
            List<MedioPagoResponse> result = _mapper.Map<List<MedioPagoResponse>>(MedioPagos);
            return result;
        }

        public MedioPagoResponse Update(MedioPagoRequest entity)
        {
            MedioPago MedioPago = _mapper.Map<MedioPago>(entity);
            MedioPago = _MedioPagoRepository.Update(MedioPago);
            MedioPagoResponse result = _mapper.Map<MedioPagoResponse>(MedioPago);
            return result;
        }

        public List<MedioPagoResponse> UpdateMultiple(List<MedioPagoRequest> lista)
        {
            List<MedioPago> MedioPagos = _mapper.Map<List<MedioPago>>(lista);
            MedioPagos = _MedioPagoRepository.UpdateMultiple(MedioPagos);
            List<MedioPagoResponse> result = _mapper.Map<List<MedioPagoResponse>>(MedioPagos);
            return result;
        }

        public int Delete(int id)
        {
            int cantidad = _MedioPagoRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<MedioPagoRequest> lista)
        {
            List<MedioPago> MedioPagos = _mapper.Map<List<MedioPago>>(lista);
            int cantidad = _MedioPagoRepository.DeleteMultipleItems(MedioPagos);
            return cantidad;
        }

        public GenericFilterResponse<MedioPagoResponse> GetByFilter(GenericFilterRequest request)
        {

            GenericFilterResponse<MedioPagoResponse> result = _mapper.Map<GenericFilterResponse<MedioPagoResponse>>(_MedioPagoRepository.GetByFilter(request));

            return result;
        }
        #endregion END CRUD METHODS
    }
}
