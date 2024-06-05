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
    public class DireccioneBussnies : IDireccioneBussnies
    {
        ///INYECCIÓN DE DEPENDECIAS/
        #region DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE
        private readonly IDireccioneRepository _DireccioneRepository;
        private readonly IMapper _mapper;
        public DireccioneBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _DireccioneRepository = new DireccioneRepository();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE

        #region START CRUD METHODS
        public List<DireccioneResponse> GetAll()
        {
            List<Direccione> Direcciones = _DireccioneRepository.GetAll();
            List<DireccioneResponse> lstResponse = _mapper.Map<List<DireccioneResponse>>(Direcciones);
            return lstResponse;
        }

        public DireccioneResponse GetById(int id)
        {
            Direccione Direccione = _DireccioneRepository.GetById(id);
            DireccioneResponse resul = _mapper.Map<DireccioneResponse>(Direccione);
            return resul;
        }

        public DireccioneResponse Create(DireccioneRequest entity)
        {
            Direccione Direccione = _mapper.Map<Direccione>(entity);
            Direccione = _DireccioneRepository.Create(Direccione);
            DireccioneResponse result = _mapper.Map<DireccioneResponse>(Direccione);
            return result;
        }
        public List<DireccioneResponse> CreateMultiple(List<DireccioneRequest> lista)
        {
            List<Direccione> Direcciones = _mapper.Map<List<Direccione>>(lista);
            Direcciones = _DireccioneRepository.CreateMultiple(Direcciones);
            List<DireccioneResponse> result = _mapper.Map<List<DireccioneResponse>>(Direcciones);
            return result;
        }

        public DireccioneResponse Update(DireccioneRequest entity)
        {
            Direccione Direccione = _mapper.Map<Direccione>(entity);
            Direccione = _DireccioneRepository.Update(Direccione);
            DireccioneResponse result = _mapper.Map<DireccioneResponse>(Direccione);
            return result;
        }

        public List<DireccioneResponse> UpdateMultiple(List<DireccioneRequest> lista)
        {
            List<Direccione> Direcciones = _mapper.Map<List<Direccione>>(lista);
            Direcciones = _DireccioneRepository.UpdateMultiple(Direcciones);
            List<DireccioneResponse> result = _mapper.Map<List<DireccioneResponse>>(Direcciones);
            return result;
        }

        public int Delete(int id)
        {
            int cantidad = _DireccioneRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<DireccioneRequest> lista)
        {
            List<Direccione> Direcciones = _mapper.Map<List<Direccione>>(lista);
            int cantidad = _DireccioneRepository.DeleteMultipleItems(Direcciones);
            return cantidad;
        }

        GenericFilterResponse<DireccioneResponse> ICRUDBussnies<DireccioneRequest, DireccioneResponse>.GetByFilter(GenericFilterRequest request)
        {
            throw new NotImplementedException();
        }
        #endregion END CRUD METHODS
    }
}
