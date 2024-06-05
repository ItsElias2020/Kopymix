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
    public class IngresoSalidaProductoBussnies : IIngresoSalidaProductoBussnies
    {
        ///INYECCIÓN DE DEPENDECIAS/
        #region DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE
        private readonly IIngresoSalidaProductoRepository _IngresoSalidaProductoRepository;
        private readonly IMapper _mapper;
        public IngresoSalidaProductoBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _IngresoSalidaProductoRepository = new IngresoSalidaProductoRepository();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE

        #region START CRUD METHODS
        public List<IngresoSalidaProductoResponse> GetAll()
        {
            List<IngresoSalidaProducto> IngresoSalidaProductos = _IngresoSalidaProductoRepository.GetAll();
            List<IngresoSalidaProductoResponse> lstResponse = _mapper.Map<List<IngresoSalidaProductoResponse>>(IngresoSalidaProductos);
            return lstResponse;
        }

        public IngresoSalidaProductoResponse GetById(int id)
        {
            IngresoSalidaProducto IngresoSalidaProducto = _IngresoSalidaProductoRepository.GetById(id);
            IngresoSalidaProductoResponse resul = _mapper.Map<IngresoSalidaProductoResponse>(IngresoSalidaProducto);
            return resul;
        }

        public IngresoSalidaProductoResponse Create(IngresoSalidaProductoRequest entity)
        {
            IngresoSalidaProducto IngresoSalidaProducto = _mapper.Map<IngresoSalidaProducto>(entity);
            IngresoSalidaProducto = _IngresoSalidaProductoRepository.Create(IngresoSalidaProducto);
            IngresoSalidaProductoResponse result = _mapper.Map<IngresoSalidaProductoResponse>(IngresoSalidaProducto);
            return result;
        }
        public List<IngresoSalidaProductoResponse> CreateMultiple(List<IngresoSalidaProductoRequest> lista)
        {
            List<IngresoSalidaProducto> IngresoSalidaProductos = _mapper.Map<List<IngresoSalidaProducto>>(lista);
            IngresoSalidaProductos = _IngresoSalidaProductoRepository.CreateMultiple(IngresoSalidaProductos);
            List<IngresoSalidaProductoResponse> result = _mapper.Map<List<IngresoSalidaProductoResponse>>(IngresoSalidaProductos);
            return result;
        }

        public IngresoSalidaProductoResponse Update(IngresoSalidaProductoRequest entity)
        {
            IngresoSalidaProducto IngresoSalidaProducto = _mapper.Map<IngresoSalidaProducto>(entity);
            IngresoSalidaProducto = _IngresoSalidaProductoRepository.Update(IngresoSalidaProducto);
            IngresoSalidaProductoResponse result = _mapper.Map<IngresoSalidaProductoResponse>(IngresoSalidaProducto);
            return result;
        }

        public List<IngresoSalidaProductoResponse> UpdateMultiple(List<IngresoSalidaProductoRequest> lista)
        {
            List<IngresoSalidaProducto> IngresoSalidaProductos = _mapper.Map<List<IngresoSalidaProducto>>(lista);
            IngresoSalidaProductos = _IngresoSalidaProductoRepository.UpdateMultiple(IngresoSalidaProductos);
            List<IngresoSalidaProductoResponse> result = _mapper.Map<List<IngresoSalidaProductoResponse>>(IngresoSalidaProductos);
            return result;
        }

        public int Delete(int id)
        {
            int cantidad = _IngresoSalidaProductoRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<IngresoSalidaProductoRequest> lista)
        {
            List<IngresoSalidaProducto> IngresoSalidaProductos = _mapper.Map<List<IngresoSalidaProducto>>(lista);
            int cantidad = _IngresoSalidaProductoRepository.DeleteMultipleItems(IngresoSalidaProductos);
            return cantidad;
        }

        public GenericFilterResponse<IngresoSalidaProductoResponse> GetByFilter(GenericFilterRequest request)
        {

            GenericFilterResponse<IngresoSalidaProductoResponse> result = _mapper.Map<GenericFilterResponse<IngresoSalidaProductoResponse>>(_IngresoSalidaProductoRepository.GetByFilter(request));

            return result;
        }
        #endregion END CRUD METHODS
    }
}
