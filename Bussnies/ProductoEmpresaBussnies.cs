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
    public class ProductoEmpresaBussnies : IProductoEmpresaBussnies
    {
        ///INYECCIÓN DE DEPENDECIAS/
        #region DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE
        private readonly IProductoEmpresaRepository _ProductoEmpresaRepository;
        private readonly IMapper _mapper;
        public ProductoEmpresaBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _ProductoEmpresaRepository = new ProductoEmpresaRepository();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE

        #region START CRUD METHODS
        public List<ProductoEmpresaResponse> GetAll()
        {
            List<ProductoEmpresa> ProductoEmpresas = _ProductoEmpresaRepository.GetAll();
            List<ProductoEmpresaResponse> lstResponse = _mapper.Map<List<ProductoEmpresaResponse>>(ProductoEmpresas);
            return lstResponse;
        }

        public ProductoEmpresaResponse GetById(int id)
        {
            ProductoEmpresa ProductoEmpresa = _ProductoEmpresaRepository.GetById(id);
            ProductoEmpresaResponse resul = _mapper.Map<ProductoEmpresaResponse>(ProductoEmpresa);
            return resul;
        }

        public ProductoEmpresaResponse Create(ProductoEmpresaRequest entity)
        {
            ProductoEmpresa ProductoEmpresa = _mapper.Map<ProductoEmpresa>(entity);
            ProductoEmpresa = _ProductoEmpresaRepository.Create(ProductoEmpresa);
            ProductoEmpresaResponse result = _mapper.Map<ProductoEmpresaResponse>(ProductoEmpresa);
            return result;
        }
        public List<ProductoEmpresaResponse> CreateMultiple(List<ProductoEmpresaRequest> lista)
        {
            List<ProductoEmpresa> ProductoEmpresas = _mapper.Map<List<ProductoEmpresa>>(lista);
            ProductoEmpresas = _ProductoEmpresaRepository.CreateMultiple(ProductoEmpresas);
            List<ProductoEmpresaResponse> result = _mapper.Map<List<ProductoEmpresaResponse>>(ProductoEmpresas);
            return result;
        }

        public ProductoEmpresaResponse Update(ProductoEmpresaRequest entity)
        {
            ProductoEmpresa ProductoEmpresa = _mapper.Map<ProductoEmpresa>(entity);
            ProductoEmpresa = _ProductoEmpresaRepository.Update(ProductoEmpresa);
            ProductoEmpresaResponse result = _mapper.Map<ProductoEmpresaResponse>(ProductoEmpresa);
            return result;
        }

        public List<ProductoEmpresaResponse> UpdateMultiple(List<ProductoEmpresaRequest> lista)
        {
            List<ProductoEmpresa> ProductoEmpresas = _mapper.Map<List<ProductoEmpresa>>(lista);
            ProductoEmpresas = _ProductoEmpresaRepository.UpdateMultiple(ProductoEmpresas);
            List<ProductoEmpresaResponse> result = _mapper.Map<List<ProductoEmpresaResponse>>(ProductoEmpresas);
            return result;
        }

        public int Delete(int id)
        {
            int cantidad = _ProductoEmpresaRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<ProductoEmpresaRequest> lista)
        {
            List<ProductoEmpresa> ProductoEmpresas = _mapper.Map<List<ProductoEmpresa>>(lista);
            int cantidad = _ProductoEmpresaRepository.DeleteMultipleItems(ProductoEmpresas);
            return cantidad;
        }

        public GenericFilterResponse<ProductoEmpresaResponse> GetByFilter(GenericFilterRequest request)
        {

            GenericFilterResponse<ProductoEmpresaResponse> result = _mapper.Map<GenericFilterResponse<ProductoEmpresaResponse>>(_ProductoEmpresaRepository.GetByFilter(request));

            return result;
        }
        #endregion END CRUD METHODS
    }
}
