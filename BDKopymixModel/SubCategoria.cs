using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BDKopymixModel;

public partial class SubCategoria
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("descripcion")]
    [StringLength(50)]
    [Unicode(false)]
    public string Descripcion { get; set; } = null!;

    [Column("idCategoria")]
    public int? IdCategoria { get; set; }

    [ForeignKey("IdCategoria")]
    [InverseProperty("SubCategoria")]
    public virtual Categoria? IdCategoriaNavigation { get; set; }

    [InverseProperty("IdSubCategoriaNavigation")]
    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
