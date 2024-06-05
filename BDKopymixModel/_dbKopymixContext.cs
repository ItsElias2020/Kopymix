using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BDKopymixModel;

public partial class _dbKopymixContext : DbContext
{
    public _dbKopymixContext()
    {
    }

    public _dbKopymixContext(DbContextOptions<_dbKopymixContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Categoria> Categorias { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<ClienteDireccione> ClienteDirecciones { get; set; }

    public virtual DbSet<ComprobantePago> ComprobantePagos { get; set; }

    public virtual DbSet<Direccione> Direcciones { get; set; }

    public virtual DbSet<Empresa> Empresas { get; set; }

    public virtual DbSet<EstadoPedido> EstadoPedidos { get; set; }

    public virtual DbSet<IngresoSalidaProducto> IngresoSalidaProductos { get; set; }

    public virtual DbSet<MedioPago> MedioPagos { get; set; }

    public virtual DbSet<Pedido> Pedidos { get; set; }

    public virtual DbSet<PedidoDetalle> PedidoDetalles { get; set; }

    public virtual DbSet<PedidoDetallePago> PedidoDetallePagos { get; set; }

    public virtual DbSet<Persona> Personas { get; set; }

    public virtual DbSet<PersonaGenero> PersonaGeneros { get; set; }

    public virtual DbSet<PersonaTipo> PersonaTipos { get; set; }

    public virtual DbSet<PersonaTipoDocumento> PersonaTipoDocumentos { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<ProductoEmpresa> ProductoEmpresas { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<SubCategoria> SubCategorias { get; set; }

    public virtual DbSet<TipoDocumento> TipoDocumentos { get; set; }

    public virtual DbSet<Ubigeo> Ubigeos { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<VPersona> VPersonas { get; set; }

    public virtual DbSet<VPersonaUbigeo> VPersonaUbigeos { get; set; }

    public virtual DbSet<VUsuario> VUsuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=KopymixBack.mssql.somee.com;Initial Catalog=KopymixBack;user id=Elibaucal_SQLLogin_3;pwd=t7rz28t7yy; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categoria>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Categori__3213E83F761BC2CE");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Clientes__3213E83F770EBC87");

            entity.HasOne(d => d.IdTipoDocumentoNavigation).WithMany(p => p.Clientes).HasConstraintName("FK__Clientes__idTipo__36B12243");
        });

        modelBuilder.Entity<ClienteDireccione>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ClienteD__3213E83F7B7C8AD7");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.ClienteDirecciones).HasConstraintName("FK__ClienteDi__idCli__398D8EEE");

            entity.HasOne(d => d.IdDireccionNavigation).WithMany(p => p.ClienteDirecciones).HasConstraintName("FK__ClienteDi__idDir__3A81B327");
        });

        modelBuilder.Entity<ComprobantePago>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Comproba__3213E83F6D9106AD");
        });

        modelBuilder.Entity<Direccione>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Direccio__3213E83F80DA8E02");
        });

        modelBuilder.Entity<Empresa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Empresas__3213E83F500C6168");
        });

        modelBuilder.Entity<EstadoPedido>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EstadoPe__3213E83FB91649ED");
        });

        modelBuilder.Entity<IngresoSalidaProducto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__IngresoS__3213E83FB5DD1E64");

            entity.HasOne(d => d.IdComprobantePagoNavigation).WithMany(p => p.IngresoSalidaProductos).HasConstraintName("FK__IngresoSa__idCom__59063A47");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.IngresoSalidaProductos).HasConstraintName("FK__IngresoSa__idEmp__5812160E");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.IngresoSalidaProductos).HasConstraintName("FK__IngresoSa__idPro__571DF1D5");
        });

        modelBuilder.Entity<MedioPago>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MedioPag__3213E83F52B6951B");
        });

        modelBuilder.Entity<Pedido>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Pedidos__3213E83F4C899379");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Pedidos).HasConstraintName("FK__Pedidos__idClien__412EB0B6");

            entity.HasOne(d => d.IdComprobantePagoNavigation).WithMany(p => p.Pedidos).HasConstraintName("FK__Pedidos__idCompr__440B1D61");

            entity.HasOne(d => d.IdDireccionNavigation).WithMany(p => p.Pedidos).HasConstraintName("FK__Pedidos__idDirec__4316F928");

            entity.HasOne(d => d.IdEstadoPedidoNavigation).WithMany(p => p.Pedidos).HasConstraintName("FK__Pedidos__idEstad__4222D4EF");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Pedidos).HasConstraintName("FK__Pedidos__idUsuar__44FF419A");
        });

        modelBuilder.Entity<PedidoDetalle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PedidoDe__3213E83F5AF8A6A7");

            entity.HasOne(d => d.IdPedidoNavigation).WithMany(p => p.PedidoDetalles).HasConstraintName("FK__PedidoDet__idPed__5070F446");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.PedidoDetalles).HasConstraintName("FK__PedidoDet__idPro__4F7CD00D");
        });

        modelBuilder.Entity<PedidoDetallePago>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PedidoDe__3213E83F5F4974FF");

            entity.HasOne(d => d.IdMedioPagoNavigation).WithMany(p => p.PedidoDetallePagos).HasConstraintName("FK__PedidoDet__idMed__48CFD27E");

            entity.HasOne(d => d.IdPedidoNavigation).WithMany(p => p.PedidoDetallePagos).HasConstraintName("FK__PedidoDet__idPed__47DBAE45");
        });

        modelBuilder.Entity<Persona>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__personas__3213E83F1762CD5D");

            entity.HasOne(d => d.IdGeneroNavigation).WithMany(p => p.Personas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__personas__id_gen__656C112C");

            entity.HasOne(d => d.IdPersonaTipoNavigation).WithMany(p => p.Personas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__personas__id_per__6477ECF3");

            entity.HasOne(d => d.IdPersonaTipoDocumentoNavigation).WithMany(p => p.Personas).HasConstraintName("FK__personas__id_per__6383C8BA");

            entity.HasOne(d => d.IdUbigeoNavigation).WithMany(p => p.Personas).HasConstraintName("FK__personas__id_ubi__66603565");
        });

        modelBuilder.Entity<PersonaGenero>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__persona___3213E83F8065BAF8");
        });

        modelBuilder.Entity<PersonaTipo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__persona___3213E83FE130692F");
        });

        modelBuilder.Entity<PersonaTipoDocumento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__persona___3213E83F8603A8C6");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Producto__3213E83F8862B117");

            entity.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.Productos).HasConstraintName("FK__Productos__idCat__4BAC3F29");

            entity.HasOne(d => d.IdSubCategoriaNavigation).WithMany(p => p.Productos).HasConstraintName("FK__Productos__idSub__4CA06362");
        });

        modelBuilder.Entity<ProductoEmpresa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Producto__3213E83F9F9AEE44");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.ProductoEmpresas).HasConstraintName("FK__ProductoE__idEmp__5441852A");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.ProductoEmpresas).HasConstraintName("FK__ProductoE__idPro__534D60F1");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Roles__3213E83F5689347C");
        });

        modelBuilder.Entity<SubCategoria>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SubCateg__3213E83FC07CBF2A");

            entity.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.SubCategoria).HasConstraintName("FK__SubCatego__idCat__2E1BDC42");
        });

        modelBuilder.Entity<TipoDocumento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TipoDocu__3213E83FDDB62AFC");
        });

        modelBuilder.Entity<Ubigeo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ubigeos__3213E83FFA4B9F1F");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Usuarios__3213E83F3DD40A23");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Usuarios).HasConstraintName("FK__Usuarios__idClie__3D5E1FD2");

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.Usuarios).HasConstraintName("FK__Usuarios__idRol__3E52440B");
        });

        modelBuilder.Entity<VPersona>(entity =>
        {
            entity.ToView("V_Persona");
        });

        modelBuilder.Entity<VPersonaUbigeo>(entity =>
        {
            entity.ToView("V_PersonaUbigeo");
        });

        modelBuilder.Entity<VUsuario>(entity =>
        {
            entity.ToView("V_Usuario");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
