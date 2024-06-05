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
    public class TipoDocumentoBussnies : ITipoDocumentoBussnies
    {
        ///INYECCIÓN DE DEPENDECIAS/
        #region DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE
        private readonly ITipoDocumentoRepository _TipoDocumentoRepository;
        private readonly IMapper _mapper;
        public TipoDocumentoBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _TipoDocumentoRepository = new TipoDocumentoRepository();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE

        #region START CRUD METHODS
        public List<TipoDocumentoResponse> GetAll()
        {
            List<TipoDocumento> TipoDocumentos = _TipoDocumentoRepository.GetAll();
            List<TipoDocumentoResponse> lstResponse = _mapper.Map<List<TipoDocumentoResponse>>(TipoDocumentos);
            return lstResponse;
        }

        public TipoDocumentoResponse GetById(int id)
        {
            TipoDocumento TipoDocumento = _TipoDocumentoRepository.GetById(id);
            TipoDocumentoResponse resul = _mapper.Map<TipoDocumentoResponse>(TipoDocumento);
            return resul;
        }

        public TipoDocumentoResponse Create(TipoDocumentoRequest entity)
        {
            TipoDocumento TipoDocumento = _mapper.Map<TipoDocumento>(entity);
            TipoDocumento = _TipoDocumentoRepository.Create(TipoDocumento);
            TipoDocumentoResponse result = _mapper.Map<TipoDocumentoResponse>(TipoDocumento);
            return result;
        }
        public List<TipoDocumentoResponse> CreateMultiple(List<TipoDocumentoRequest> lista)
        {
            List<TipoDocumento> TipoDocumentos = _mapper.Map<List<TipoDocumento>>(lista);
            TipoDocumentos = _TipoDocumentoRepository.CreateMultiple(TipoDocumentos);
            List<TipoDocumentoResponse> result = _mapper.Map<List<TipoDocumentoResponse>>(TipoDocumentos);
            return result;
        }

        public TipoDocumentoResponse Update(TipoDocumentoRequest entity)
        {
            TipoDocumento TipoDocumento = _mapper.Map<TipoDocumento>(entity);
            TipoDocumento = _TipoDocumentoRepository.Update(TipoDocumento);
            TipoDocumentoResponse result = _mapper.Map<TipoDocumentoResponse>(TipoDocumento);
            return result;
        }

        public List<TipoDocumentoResponse> UpdateMultiple(List<TipoDocumentoRequest> lista)
        {
            List<TipoDocumento> TipoDocumentos = _mapper.Map<List<TipoDocumento>>(lista);
            TipoDocumentos = _TipoDocumentoRepository.UpdateMultiple(TipoDocumentos);
            List<TipoDocumentoResponse> result = _mapper.Map<List<TipoDocumentoResponse>>(TipoDocumentos);
            return result;
        }

        public int Delete(int id)
        {
            int cantidad = _TipoDocumentoRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<TipoDocumentoRequest> lista)
        {
            List<TipoDocumento> TipoDocumentos = _mapper.Map<List<TipoDocumento>>(lista);
            int cantidad = _TipoDocumentoRepository.DeleteMultipleItems(TipoDocumentos);
            return cantidad;
        }

        public GenericFilterResponse<TipoDocumentoResponse> GetByFilter(GenericFilterRequest request)
        {

            GenericFilterResponse<TipoDocumentoResponse> result = _mapper.Map<GenericFilterResponse<TipoDocumentoResponse>>(_TipoDocumentoRepository.GetByFilter(request));

            return result;
        }
        #endregion END CRUD METHODS
    }
}
