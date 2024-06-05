using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BDKopymixModel;

[Table("ubigeos")]
public partial class Ubigeo
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("ubigeo")]
    [StringLength(6)]
    [Unicode(false)]
    public string? Ubigeo1 { get; set; }

    [Column("distrito")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Distrito { get; set; }

    [Column("provincia")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Provincia { get; set; }

    [Column("departamento")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Departamento { get; set; }

    [Column("superficie")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Superficie { get; set; }

    [Column("y")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Y { get; set; }

    [Column("x")]
    [StringLength(50)]
    [Unicode(false)]
    public string? X { get; set; }

    [Column("ubicacion")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Ubicacion { get; set; }

    [InverseProperty("IdUbigeoNavigation")]
    public virtual ICollection<Persona> Personas { get; set; } = new List<Persona>();
}
