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
    public class ProductoBussnies : IProductoBussnies
    {
        ///INYECCIÓN DE DEPENDECIAS/
        #region DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE
        private readonly IProductoRepository _ProductoRepository;
        private readonly IMapper _mapper;
        public ProductoBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _ProductoRepository = new ProductoRepository();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE

        #region START CRUD METHODS
        public List<ProductoResponse> GetAll()
        {
            List<Producto> Productos = _ProductoRepository.GetAll();
            List<ProductoResponse> lstResponse = _mapper.Map<List<ProductoResponse>>(Productos);
            return lstResponse;
        }

        public ProductoResponse GetById(int id)
        {
            Producto Producto = _ProductoRepository.GetById(id);
            ProductoResponse resul = _mapper.Map<ProductoResponse>(Producto);
            return resul;
        }

        public ProductoResponse Create(ProductoRequest entity)
        {
            Producto Producto = _mapper.Map<Producto>(entity);
            Producto = _ProductoRepository.Create(Producto);
            ProductoResponse result = _mapper.Map<ProductoResponse>(Producto);
            return result;
        }
        public List<ProductoResponse> CreateMultiple(List<ProductoRequest> lista)
        {
            List<Producto> Productos = _mapper.Map<List<Producto>>(lista);
            Productos = _ProductoRepository.CreateMultiple(Productos);
            List<ProductoResponse> result = _mapper.Map<List<ProductoResponse>>(Productos);
            return result;
        }

        public ProductoResponse Update(ProductoRequest entity)
        {
            Producto Producto = _mapper.Map<Producto>(entity);
            Producto = _ProductoRepository.Update(Producto);
            ProductoResponse result = _mapper.Map<ProductoResponse>(Producto);
            return result;
        }

        public List<ProductoResponse> UpdateMultiple(List<ProductoRequest> lista)
        {
            List<Producto> Productos = _mapper.Map<List<Producto>>(lista);
            Productos = _ProductoRepository.UpdateMultiple(Productos);
            List<ProductoResponse> result = _mapper.Map<List<ProductoResponse>>(Productos);
            return result;
        }

        public int Delete(int id)
        {
            int cantidad = _ProductoRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<ProductoRequest> lista)
        {
            List<Producto> Productos = _mapper.Map<List<Producto>>(lista);
            int cantidad = _ProductoRepository.DeleteMultipleItems(Productos);
            return cantidad;
        }

        public GenericFilterResponse<ProductoResponse> GetByFilter(GenericFilterRequest request)
        {

            GenericFilterResponse<ProductoResponse> result = _mapper.Map<GenericFilterResponse<ProductoResponse>>(_ProductoRepository.GetByFilter(request));

            return result;
        }
        #endregion END CRUD METHODS
    }
}
