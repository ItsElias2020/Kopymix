using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BDKopymixModel;

[Table("persona_generos")]
public partial class PersonaGenero
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("codi")]
    [StringLength(3)]
    [Unicode(false)]
    public string? Codi { get; set; }

    [Column("nombre")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Nombre { get; set; }

    [InverseProperty("IdGeneroNavigation")]
    public virtual ICollection<Persona> Personas { get; set; } = new List<Persona>();
}
