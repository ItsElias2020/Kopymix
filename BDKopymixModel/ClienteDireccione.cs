using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BDKopymixModel;

public partial class ClienteDireccione
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("idCliente")]
    public int? IdCliente { get; set; }

    [Column("idDireccion")]
    public int? IdDireccion { get; set; }

    [Column("calle")]
    [StringLength(30)]
    [Unicode(false)]
    public string Calle { get; set; } = null!;

    [Column("nro")]
    [StringLength(5)]
    [Unicode(false)]
    public string Nro { get; set; } = null!;

    [Column("referencia")]
    [StringLength(100)]
    [Unicode(false)]
    public string Referencia { get; set; } = null!;

    [ForeignKey("IdCliente")]
    [InverseProperty("ClienteDirecciones")]
    public virtual Cliente? IdClienteNavigation { get; set; }

    [ForeignKey("IdDireccion")]
    [InverseProperty("ClienteDirecciones")]
    public virtual Direccione? IdDireccionNavigation { get; set; }
}
