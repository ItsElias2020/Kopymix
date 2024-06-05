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
    public class SubCategoriaBussnies : ISubCategoriaBussnies
    {
        ///INYECCIÓN DE DEPENDECIAS/
        #region DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE
        private readonly ISubCategoriaRepository _SubCategoriaRepository;
        private readonly IMapper _mapper;
        public SubCategoriaBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _SubCategoriaRepository = new SubCategoriaRepository();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE

        #region START CRUD METHODS
        public List<SubCategoriaResponse> GetAll()
        {
            List<SubCategoria> SubCategorias = _SubCategoriaRepository.GetAll();
            List<SubCategoriaResponse> lstResponse = _mapper.Map<List<SubCategoriaResponse>>(SubCategorias);
            return lstResponse;
        }

        public SubCategoriaResponse GetById(int id)
        {
            SubCategoria SubCategoria = _SubCategoriaRepository.GetById(id);
            SubCategoriaResponse resul = _mapper.Map<SubCategoriaResponse>(SubCategoria);
            return resul;
        }

        public SubCategoriaResponse Create(SubCategoriaRequest entity)
        {
            SubCategoria SubCategoria = _mapper.Map<SubCategoria>(entity);
            SubCategoria = _SubCategoriaRepository.Create(SubCategoria);
            SubCategoriaResponse result = _mapper.Map<SubCategoriaResponse>(SubCategoria);
            return result;
        }
        public List<SubCategoriaResponse> CreateMultiple(List<SubCategoriaRequest> lista)
        {
            List<SubCategoria> SubCategorias = _mapper.Map<List<SubCategoria>>(lista);
            SubCategorias = _SubCategoriaRepository.CreateMultiple(SubCategorias);
            List<SubCategoriaResponse> result = _mapper.Map<List<SubCategoriaResponse>>(SubCategorias);
            return result;
        }

        public SubCategoriaResponse Update(SubCategoriaRequest entity)
        {
            SubCategoria SubCategoria = _mapper.Map<SubCategoria>(entity);
            SubCategoria = _SubCategoriaRepository.Update(SubCategoria);
            SubCategoriaResponse result = _mapper.Map<SubCategoriaResponse>(SubCategoria);
            return result;
        }

        public List<SubCategoriaResponse> UpdateMultiple(List<SubCategoriaRequest> lista)
        {
            List<SubCategoria> SubCategorias = _mapper.Map<List<SubCategoria>>(lista);
            SubCategorias = _SubCategoriaRepository.UpdateMultiple(SubCategorias);
            List<SubCategoriaResponse> result = _mapper.Map<List<SubCategoriaResponse>>(SubCategorias);
            return result;
        }

        public int Delete(int id)
        {
            int cantidad = _SubCategoriaRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<SubCategoriaRequest> lista)
        {
            List<SubCategoria> SubCategorias = _mapper.Map<List<SubCategoria>>(lista);
            int cantidad = _SubCategoriaRepository.DeleteMultipleItems(SubCategorias);
            return cantidad;
        }

        public GenericFilterResponse<SubCategoriaResponse> GetByFilter(GenericFilterRequest request)
        {

            GenericFilterResponse<SubCategoriaResponse> result = _mapper.Map<GenericFilterResponse<SubCategoriaResponse>>(_SubCategoriaRepository.GetByFilter(request));

            return result;
        }
        #endregion END CRUD METHODS
    }
}
