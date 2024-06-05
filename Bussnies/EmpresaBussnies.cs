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
    public class EmpresaBussnies : IEmpresaBussnies
    {
        ///INYECCIÓN DE DEPENDECIAS/
        #region DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE
        private readonly IEmpresaRepository _EmpresaRepository;
        private readonly IMapper _mapper;
        public EmpresaBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _EmpresaRepository = new EmpresaRepository();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE

        #region START CRUD METHODS
        public List<EmpresaResponse> GetAll()
        {
            List<Empresa> Empresas = _EmpresaRepository.GetAll();
            List<EmpresaResponse> lstResponse = _mapper.Map<List<EmpresaResponse>>(Empresas);
            return lstResponse;
        }

        public EmpresaResponse GetById(int id)
        {
            Empresa Empresa = _EmpresaRepository.GetById(id);
            EmpresaResponse resul = _mapper.Map<EmpresaResponse>(Empresa);
            return resul;
        }

        public EmpresaResponse Create(EmpresaRequest entity)
        {
            Empresa Empresa = _mapper.Map<Empresa>(entity);
            Empresa = _EmpresaRepository.Create(Empresa);
            EmpresaResponse result = _mapper.Map<EmpresaResponse>(Empresa);
            return result;
        }
        public List<EmpresaResponse> CreateMultiple(List<EmpresaRequest> lista)
        {
            List<Empresa> Empresas = _mapper.Map<List<Empresa>>(lista);
            Empresas = _EmpresaRepository.CreateMultiple(Empresas);
            List<EmpresaResponse> result = _mapper.Map<List<EmpresaResponse>>(Empresas);
            return result;
        }

        public EmpresaResponse Update(EmpresaRequest entity)
        {
            Empresa Empresa = _mapper.Map<Empresa>(entity);
            Empresa = _EmpresaRepository.Update(Empresa);
            EmpresaResponse result = _mapper.Map<EmpresaResponse>(Empresa);
            return result;
        }

        public List<EmpresaResponse> UpdateMultiple(List<EmpresaRequest> lista)
        {
            List<Empresa> Empresas = _mapper.Map<List<Empresa>>(lista);
            Empresas = _EmpresaRepository.UpdateMultiple(Empresas);
            List<EmpresaResponse> result = _mapper.Map<List<EmpresaResponse>>(Empresas);
            return result;
        }

        public int Delete(int id)
        {
            int cantidad = _EmpresaRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<EmpresaRequest> lista)
        {
            List<Empresa> Empresas = _mapper.Map<List<Empresa>>(lista);
            int cantidad = _EmpresaRepository.DeleteMultipleItems(Empresas);
            return cantidad;
        }

        public GenericFilterResponse<EmpresaResponse> GetByFilter(GenericFilterRequest request)
        {

            GenericFilterResponse<EmpresaResponse> result = _mapper.Map<GenericFilterResponse<EmpresaResponse>>(_EmpresaRepository.GetByFilter(request));

            return result;
        }
        #endregion END CRUD METHODS
    }
}
