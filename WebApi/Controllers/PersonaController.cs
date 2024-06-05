using AutoMapper;
using BDKopymixModel;
using Bussnies;
using CommonModel;
using IBussnies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RequestResponseModel;
using System.Net;
using WebApi.Midleware;

namespace ApiWeb.Controllers
{
    /// <summary>
    /// controller para la tabla/vista persona
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class PersonaController : ControllerBase
    {

        /*INYECCIÓN DE DEPENDECIAS*/
        #region DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE
        private readonly IPersonaBussnies _PersonaBussnies;
        private readonly IMapper _mapper;
        private readonly IHelperHttpContext _helperHttpContext = null;
        /// <summary>
        /// coonstructor
        /// </summary>
        /// <param name="mapper"></param>
        public PersonaController(IMapper mapper)
        {
            _mapper = mapper;
            _PersonaBussnies = new PersonaBussnies(mapper);
            _helperHttpContext = new HelperHttpContext();
        }

        #endregion DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE


        /// <summary>
        /// obtiene la lista de personas con ubigeo
        /// </summary>
        /// <returns></returns>
        [HttpGet("ubigeo")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(List<VPersonaUbigeo>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(GenericResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(GenericResponse))]
        public IActionResult GetWithUbigeo()
        {
            List<VPersonaUbigeo> lis = new List<VPersonaUbigeo>();
            lis = _PersonaBussnies.ObtenerTodosConUbigeo();
            return Ok(lis);

        }


        /// <summary>
        /// retorna los datos de una persona en base al DNI
        /// </summary>
        /// <returns></returns>
        [HttpGet("/{tipDocumento}/{nroDocumento}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(List<VPersonaUbigeo>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(GenericResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(GenericResponse))]
        public IActionResult GetWithDni(string tipDocumento, string nroDocumento)
        {
            VPersona persona = new VPersona();
            persona = _PersonaBussnies.GetByTipoNroDocumento(tipDocumento, nroDocumento);
            return Ok(persona);

        }


        /// <summary>
        /// obtiene la lista de personas con ubigeo
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(List<PersonaResponse>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(GenericResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(GenericResponse))]
        public IActionResult Create([FromBody] PersonaRequest request)
        {
            InfoRequest info = _helperHttpContext.GetInfoRequest(HttpContext);

            request.UsuarioCrea = info.Claims.UserId;
            request.UsuarioActualiza = info.Claims.UserId;
            request.FechaCrea = DateTime.Now;

            PersonaResponse resulado = _PersonaBussnies.Create(request);

            return Ok(resulado);

        }

        /// <summary>
        /// obtiene la lista de personas con ubigeo
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(List<PersonaResponse>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(GenericResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(GenericResponse))]
        public IActionResult Actualizar([FromBody] PersonaRequest request)
        {
            InfoRequest info = _helperHttpContext.GetInfoRequest(HttpContext);

            request.UsuarioActualiza = info.Claims.UserId;
            request.FechaActualiza = DateTime.Now;

            PersonaResponse resulado = _PersonaBussnies.Update(request);

            return Ok(resulado);

        }





    }
}
