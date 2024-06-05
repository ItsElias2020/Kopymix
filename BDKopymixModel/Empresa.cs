using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BDKopymixModel;

public partial class Empresa
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("ruc")]
    [StringLength(11)]
    [Unicode(false)]
    public string Ruc { get; set; } = null!;

    [Column("razonSocial")]
    [StringLength(50)]
    [Unicode(false)]
    public string RazonSocial { get; set; } = null!;

    [Column("telefono")]
    [StringLength(13)]
    [Unicode(false)]
    public string Telefono { get; set; } = null!;

    [Column("contacto")]
    [StringLength(150)]
    [Unicode(false)]
    public string Contacto { get; set; } = null!;

    [Column("email")]
    [StringLength(50)]
    [Unicode(false)]
    public string Email { get; set; } = null!;

    [InverseProperty("IdEmpresaNavigation")]
    public virtual ICollection<IngresoSalidaProducto> IngresoSalidaProductos { get; set; } = new List<IngresoSalidaProducto>();

    [InverseProperty("IdEmpresaNavigation")]
    public virtual ICollection<ProductoEmpresa> ProductoEmpresas { get; set; } = new List<ProductoEmpresa>();
}
