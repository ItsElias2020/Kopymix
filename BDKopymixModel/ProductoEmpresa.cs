using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BDKopymixModel;

public partial class ProductoEmpresa
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("idProducto")]
    public int? IdProducto { get; set; }

    [Column("idEmpresa")]
    public int? IdEmpresa { get; set; }

    [ForeignKey("IdEmpresa")]
    [InverseProperty("ProductoEmpresas")]
    public virtual Empresa? IdEmpresaNavigation { get; set; }

    [ForeignKey("IdProducto")]
    [InverseProperty("ProductoEmpresas")]
    public virtual Producto? IdProductoNavigation { get; set; }
}
