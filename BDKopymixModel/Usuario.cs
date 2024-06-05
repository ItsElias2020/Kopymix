using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BDKopymixModel;

public partial class Usuario
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("username")]
    [StringLength(20)]
    [Unicode(false)]
    public string Username { get; set; } = null!;

    [Column("password")]
    [StringLength(300)]
    [Unicode(false)]
    public string Password { get; set; } = null!;

    [Column("usuario_crea")]
    public int UsuarioCrea { get; set; }

    [Column("usuario_actualiza")]
    public int UsuarioActualiza { get; set; }

    [Column("fecha_crea")]
    [Precision(6)]
    public DateTime FechaCrea { get; set; }

    [Column("fecha_actualiza")]
    [Precision(6)]
    public DateTime FechaActualiza { get; set; }

    [Column("idRol")]
    public int? IdRol { get; set; }

    [Column("idCliente")]
    public int? IdCliente { get; set; }

    [ForeignKey("IdCliente")]
    [InverseProperty("Usuarios")]
    public virtual Cliente? IdClienteNavigation { get; set; }

    [ForeignKey("IdRol")]
    [InverseProperty("Usuarios")]
    public virtual Role? IdRolNavigation { get; set; }

    [InverseProperty("IdUsuarioNavigation")]
    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
