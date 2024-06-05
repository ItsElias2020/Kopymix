using AutoMapper;
using BDKopymixModel;
using RequestResponseModel;

namespace UtilAutomapper
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {

            CreateMap<TipoDocumento, TipoDocumentoRequest>().ReverseMap();
            CreateMap<TipoDocumento, TipoDocumentoResponse>().ReverseMap();
            CreateMap<TipoDocumentoRequest, TipoDocumentoResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<TipoDocumentoResponse>, GenericFilterResponse<TipoDocumento>>().ReverseMap();

            CreateMap<Persona, PersonaRequest>().ReverseMap();
            CreateMap<Persona, PersonaResponse>().ReverseMap();
            CreateMap<PersonaRequest, PersonaResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<PersonaResponse>, GenericFilterResponse<Persona>>().ReverseMap();

            CreateMap<Usuario, UsuarioRequest>().ReverseMap();
            CreateMap<Usuario, UsuarioResponse>().ReverseMap();
            CreateMap<UsuarioRequest, UsuarioResponse>().ReverseMap();

            CreateMap<Categoria, CategoriaRequest>().ReverseMap();
            CreateMap<Categoria, CategoriaResponse>().ReverseMap();
            CreateMap<CategoriaRequest, CategoriaResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<CategoriaResponse>, GenericFilterResponse<Categoria>>().ReverseMap();

            CreateMap<ComprobantePago, ComprobantePagoRequest>().ReverseMap();
            CreateMap<ComprobantePago, ComprobantePagoResponse>().ReverseMap();
            CreateMap<ComprobantePagoRequest, ComprobantePagoResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<ComprobantePagoResponse>, GenericFilterResponse<ComprobantePago>>().ReverseMap();

            CreateMap<EstadoPedido, EstadoPedidoRequest>().ReverseMap();
            CreateMap<EstadoPedido, EstadoPedidoResponse>().ReverseMap();
            CreateMap<EstadoPedidoRequest, EstadoPedidoResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<EstadoPedidoResponse>, GenericFilterResponse<EstadoPedido>>().ReverseMap();

            CreateMap<Pedido, PedidoRequest>().ReverseMap();
            CreateMap<Pedido, PedidoResponse>().ReverseMap();
            CreateMap<PedidoRequest, PedidoResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<PedidoResponse>, GenericFilterResponse<Pedido>>().ReverseMap();

            CreateMap<PedidoDetallePago, PedidoDetallePagoRequest>().ReverseMap();
            CreateMap<PedidoDetallePago, PedidoDetallePagoResponse>().ReverseMap();
            CreateMap<PedidoDetallePagoRequest, PedidoDetallePagoResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<PedidoDetallePagoResponse>, GenericFilterResponse<PedidoDetallePago>>().ReverseMap();

            CreateMap<Role, RoleRequest>().ReverseMap();
            CreateMap<Role, RoleResponse>().ReverseMap();
            CreateMap<RoleRequest, RoleResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<RoleResponse>, GenericFilterResponse<Role>>().ReverseMap();

            CreateMap<SubCategoria, SubCategoriaRequest>().ReverseMap();
            CreateMap<SubCategoria, SubCategoriaResponse>().ReverseMap();
            CreateMap<SubCategoriaRequest, SubCategoriaResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<SubCategoriaResponse>, GenericFilterResponse<SubCategoria>>().ReverseMap();

            CreateMap<Empresa, EmpresaRequest>().ReverseMap();
            CreateMap<Empresa, EmpresaResponse>().ReverseMap();
            CreateMap<EmpresaRequest, EmpresaResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<EmpresaResponse>, GenericFilterResponse<Empresa>>().ReverseMap();


            CreateMap<MedioPago, MedioPagoRequest>().ReverseMap();
            CreateMap<MedioPago, MedioPagoResponse>().ReverseMap();
            CreateMap<MedioPagoRequest, MedioPagoResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<MedioPagoResponse>, GenericFilterResponse<MedioPago>>().ReverseMap();

            CreateMap<Cliente, ClienteRequest>().ReverseMap();
            CreateMap<Cliente, ClienteResponse>().ReverseMap();
            CreateMap<ClienteRequest, ClienteResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<ClienteResponse>, GenericFilterResponse<Cliente>>().ReverseMap();

            CreateMap<ClienteDireccione, ClienteDireccioneRequest>().ReverseMap();
            CreateMap<ClienteDireccione, ClienteDireccioneResponse>().ReverseMap();
            CreateMap<ClienteDireccioneRequest, ClienteDireccioneResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<ClienteDireccioneResponse>, GenericFilterResponse<ClienteDireccione>>().ReverseMap();

            CreateMap<Direccione, DireccioneRequest>().ReverseMap();
            CreateMap<Direccione, DireccioneResponse>().ReverseMap();
            CreateMap<DireccioneRequest, DireccioneResponse>().ReverseMap();

            CreateMap<IngresoSalidaProducto, IngresoSalidaProductoRequest>().ReverseMap();
            CreateMap<IngresoSalidaProducto, IngresoSalidaProductoResponse>().ReverseMap();
            CreateMap<IngresoSalidaProductoRequest, IngresoSalidaProductoResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<IngresoSalidaProductoResponse>, GenericFilterResponse<IngresoSalidaProducto>>().ReverseMap();

            CreateMap<PedidoDetalle, PedidoDetalleRequest>().ReverseMap();
            CreateMap<PedidoDetalle, PedidoDetalleResponse>().ReverseMap();
            CreateMap<PedidoDetalleRequest, PedidoDetalleResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<PedidoDetalleResponse>, GenericFilterResponse<PedidoDetalle>>().ReverseMap();

            CreateMap<Producto, ProductoRequest>().ReverseMap();
            CreateMap<Producto, ProductoResponse>().ReverseMap();
            CreateMap<ProductoRequest, ProductoResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<ProductoResponse>, GenericFilterResponse<Producto>>().ReverseMap();

            CreateMap<ProductoEmpresa, ProductoEmpresaRequest>().ReverseMap();
            CreateMap<ProductoEmpresa, ProductoEmpresaResponse>().ReverseMap();
            CreateMap<ProductoEmpresaRequest, ProductoEmpresaResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<ProductoEmpresaResponse>, GenericFilterResponse<ProductoEmpresa>>().ReverseMap();
        }

    }
}