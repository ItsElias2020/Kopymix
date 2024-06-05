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
    public class ComprobantePagoBussnies : IComprobantePagoBussnies
    {
        ///INYECCIÓN DE DEPENDECIAS/
        #region DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE
        private readonly IComprobantePagoRepository _ComprobantePagoRepository;
        private readonly IMapper _mapper;
        public ComprobantePagoBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _ComprobantePagoRepository = new ComprobantePagoRepository();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE

        #region START CRUD METHODS
        public List<ComprobantePagoResponse> GetAll()
        {
            List<ComprobantePago> ComprobantePagos = _ComprobantePagoRepository.GetAll();
            List<ComprobantePagoResponse> lstResponse = _mapper.Map<List<ComprobantePagoResponse>>(ComprobantePagos);
            return lstResponse;
        }

        public ComprobantePagoResponse GetById(int id)
        {
            ComprobantePago ComprobantePago = _ComprobantePagoRepository.GetById(id);
            ComprobantePagoResponse resul = _mapper.Map<ComprobantePagoResponse>(ComprobantePago);
            return resul;
        }

        public ComprobantePagoResponse Create(ComprobantePagoRequest entity)
        {
            ComprobantePago ComprobantePago = _mapper.Map<ComprobantePago>(entity);
            ComprobantePago = _ComprobantePagoRepository.Create(ComprobantePago);
            ComprobantePagoResponse result = _mapper.Map<ComprobantePagoResponse>(ComprobantePago);
            return result;
        }
        public List<ComprobantePagoResponse> CreateMultiple(List<ComprobantePagoRequest> lista)
        {
            List<ComprobantePago> ComprobantePagos = _mapper.Map<List<ComprobantePago>>(lista);
            ComprobantePagos = _ComprobantePagoRepository.CreateMultiple(ComprobantePagos);
            List<ComprobantePagoResponse> result = _mapper.Map<List<ComprobantePagoResponse>>(ComprobantePagos);
            return result;
        }

        public ComprobantePagoResponse Update(ComprobantePagoRequest entity)
        {
            ComprobantePago ComprobantePago = _mapper.Map<ComprobantePago>(entity);
            ComprobantePago = _ComprobantePagoRepository.Update(ComprobantePago);
            ComprobantePagoResponse result = _mapper.Map<ComprobantePagoResponse>(ComprobantePago);
            return result;
        }

        public List<ComprobantePagoResponse> UpdateMultiple(List<ComprobantePagoRequest> lista)
        {
            List<ComprobantePago> ComprobantePagos = _mapper.Map<List<ComprobantePago>>(lista);
            ComprobantePagos = _ComprobantePagoRepository.UpdateMultiple(ComprobantePagos);
            List<ComprobantePagoResponse> result = _mapper.Map<List<ComprobantePagoResponse>>(ComprobantePagos);
            return result;
        }

        public int Delete(int id)
        {
            int cantidad = _ComprobantePagoRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<ComprobantePagoRequest> lista)
        {
            List<ComprobantePago> ComprobantePagos = _mapper.Map<List<ComprobantePago>>(lista);
            int cantidad = _ComprobantePagoRepository.DeleteMultipleItems(ComprobantePagos);
            return cantidad;
        }

        public GenericFilterResponse<ComprobantePagoResponse> GetByFilter(GenericFilterRequest request)
        {

            GenericFilterResponse<ComprobantePagoResponse> result = _mapper.Map<GenericFilterResponse<ComprobantePagoResponse>>(_ComprobantePagoRepository.GetByFilter(request));

            return result;
        }
        #endregion END CRUD METHODS
    }
}
