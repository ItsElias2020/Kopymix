using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BDKopymixModel;

public partial class Direccione
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("departamento")]
    [StringLength(30)]
    [Unicode(false)]
    public string Departamento { get; set; } = null!;

    [Column("provincia")]
    [StringLength(30)]
    [Unicode(false)]
    public string Provincia { get; set; } = null!;

    [Column("distrito")]
    [StringLength(30)]
    [Unicode(false)]
    public string Distrito { get; set; } = null!;

    [InverseProperty("IdDireccionNavigation")]
    public virtual ICollection<ClienteDireccione> ClienteDirecciones { get; set; } = new List<ClienteDireccione>();

    [InverseProperty("IdDireccionNavigation")]
    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
