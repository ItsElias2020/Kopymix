using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BDKopymixModel;

[Table("persona_tipo_documentos")]
public partial class PersonaTipoDocumento
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("codi")]
    [StringLength(3)]
    [Unicode(false)]
    public string? Codi { get; set; }

    [Column("descripcion")]
    [StringLength(80)]
    [Unicode(false)]
    public string? Descripcion { get; set; }

    [Column("id_estado")]
    public bool IdEstado { get; set; }

    [InverseProperty("IdPersonaTipoDocumentoNavigation")]
    public virtual ICollection<Persona> Personas { get; set; } = new List<Persona>();
}
