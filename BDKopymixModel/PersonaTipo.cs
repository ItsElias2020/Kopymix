using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BDKopymixModel;

[Table("persona_tipos")]
public partial class PersonaTipo
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("descripcion")]
    [StringLength(25)]
    [Unicode(false)]
    public string? Descripcion { get; set; }

    [InverseProperty("IdPersonaTipoNavigation")]
    public virtual ICollection<Persona> Personas { get; set; } = new List<Persona>();
}
