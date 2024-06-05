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
    public class RoleBussnies : IRoleBussnies
    {
        ///INYECCIÓN DE DEPENDECIAS/
        #region DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE
        private readonly IRoleRepository _RoleRepository;
        private readonly IMapper _mapper;
        public RoleBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _RoleRepository = new RoleRepository();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE

        #region START CRUD METHODS
        public List<RoleResponse> GetAll()
        {
            List<Role> Roles = _RoleRepository.GetAll();
            List<RoleResponse> lstResponse = _mapper.Map<List<RoleResponse>>(Roles);
            return lstResponse;
        }

        public RoleResponse GetById(int id)
        {
            Role Role = _RoleRepository.GetById(id);
            RoleResponse resul = _mapper.Map<RoleResponse>(Role);
            return resul;
        }

        public RoleResponse Create(RoleRequest entity)
        {
            Role Role = _mapper.Map<Role>(entity);
            Role = _RoleRepository.Create(Role);
            RoleResponse result = _mapper.Map<RoleResponse>(Role);
            return result;
        }
        public List<RoleResponse> CreateMultiple(List<RoleRequest> lista)
        {
            List<Role> Roles = _mapper.Map<List<Role>>(lista);
            Roles = _RoleRepository.CreateMultiple(Roles);
            List<RoleResponse> result = _mapper.Map<List<RoleResponse>>(Roles);
            return result;
        }

        public RoleResponse Update(RoleRequest entity)
        {
            Role Role = _mapper.Map<Role>(entity);
            Role = _RoleRepository.Update(Role);
            RoleResponse result = _mapper.Map<RoleResponse>(Role);
            return result;
        }

        public List<RoleResponse> UpdateMultiple(List<RoleRequest> lista)
        {
            List<Role> Roles = _mapper.Map<List<Role>>(lista);
            Roles = _RoleRepository.UpdateMultiple(Roles);
            List<RoleResponse> result = _mapper.Map<List<RoleResponse>>(Roles);
            return result;
        }

        public int Delete(int id)
        {
            int cantidad = _RoleRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<RoleRequest> lista)
        {
            List<Role> Roles = _mapper.Map<List<Role>>(lista);
            int cantidad = _RoleRepository.DeleteMultipleItems(Roles);
            return cantidad;
        }

        public GenericFilterResponse<RoleResponse> GetByFilter(GenericFilterRequest request)
        {

            GenericFilterResponse<RoleResponse> result = _mapper.Map<GenericFilterResponse<RoleResponse>>(_RoleRepository.GetByFilter(request));

            return result;
        }
        #endregion END CRUD METHODS
    }
}
