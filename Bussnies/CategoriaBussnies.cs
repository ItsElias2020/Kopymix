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
    public class CategoriaBussnies : ICategoriaBussnies
    {
        ///INYECCIÓN DE DEPENDECIAS/
        #region DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE
        private readonly ICategoriaRepository _CategoriaRepository;
        private readonly IMapper _mapper;
        public CategoriaBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _CategoriaRepository = new CategoriaRepository();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE

        #region START CRUD METHODS
        public List<CategoriaResponse> GetAll()
        {
            List<Categoria> Categorias = _CategoriaRepository.GetAll();
            List<CategoriaResponse> lstResponse = _mapper.Map<List<CategoriaResponse>>(Categorias);
            return lstResponse;
        }

        public CategoriaResponse GetById(int id)
        {
            Categoria Categoria = _CategoriaRepository.GetById(id);
            CategoriaResponse resul = _mapper.Map<CategoriaResponse>(Categoria);
            return resul;
        }

        public CategoriaResponse Create(CategoriaRequest entity)
        {
            Categoria Categoria = _mapper.Map<Categoria>(entity);
            Categoria = _CategoriaRepository.Create(Categoria);
            CategoriaResponse result = _mapper.Map<CategoriaResponse>(Categoria);
            return result;
        }
        public List<CategoriaResponse> CreateMultiple(List<CategoriaRequest> lista)
        {
            List<Categoria> Categorias = _mapper.Map<List<Categoria>>(lista);
            Categorias = _CategoriaRepository.CreateMultiple(Categorias);
            List<CategoriaResponse> result = _mapper.Map<List<CategoriaResponse>>(Categorias);
            return result;
        }

        public CategoriaResponse Update(CategoriaRequest entity)
        {
            Categoria Categoria = _mapper.Map<Categoria>(entity);
            Categoria = _CategoriaRepository.Update(Categoria);
            CategoriaResponse result = _mapper.Map<CategoriaResponse>(Categoria);
            return result;
        }

        public List<CategoriaResponse> UpdateMultiple(List<CategoriaRequest> lista)
        {
            List<Categoria> Categorias = _mapper.Map<List<Categoria>>(lista);
            Categorias = _CategoriaRepository.UpdateMultiple(Categorias);
            List<CategoriaResponse> result = _mapper.Map<List<CategoriaResponse>>(Categorias);
            return result;
        }

        public int Delete(int id)
        {
            int cantidad = _CategoriaRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<CategoriaRequest> lista)
        {
            List<Categoria> Categorias = _mapper.Map<List<Categoria>>(lista);
            int cantidad = _CategoriaRepository.DeleteMultipleItems(Categorias);
            return cantidad;
        }

        public GenericFilterResponse<CategoriaResponse> GetByFilter(GenericFilterRequest request)
        {

            GenericFilterResponse<CategoriaResponse> result = _mapper.Map<GenericFilterResponse<CategoriaResponse>>(_CategoriaRepository.GetByFilter(request));

            return result;
        }
        #endregion END CRUD METHODS
    }
}
