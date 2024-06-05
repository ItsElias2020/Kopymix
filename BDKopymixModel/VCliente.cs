using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BDKopymixModel;

[Keyless]
public partial class VCliente
{
    [Column("idcliente")]
    public int Idcliente { get; set; }

    [Column("nombre")]
    [StringLength(30)]
    [Unicode(false)]
    public string Nombre { get; set; } = null!;

    [Column("apPaterno")]
    [StringLength(30)]
    [Unicode(false)]
    public string ApPaterno { get; set; } = null!;

    [Column("apMaterno")]
    [StringLength(30)]
    [Unicode(false)]
    public string ApMaterno { get; set; } = null!;

    [Column("correo")]
    [StringLength(30)]
    [Unicode(false)]
    public string Correo { get; set; } = null!;

    [Column("password")]
    [StringLength(30)]
    [Unicode(false)]
    public string Password { get; set; } = null!;

    [Column("nroCelular")]
    [StringLength(30)]
    [Unicode(false)]
    public string NroCelular { get; set; } = null!;

    [Column("idTipoDocumento")]
    public int IdTipoDocumento { get; set; }

    [Column("descripcion")]
    [StringLength(30)]
    [Unicode(false)]
    public string Descripcion { get; set; } = null!;

    [Column("numero")]
    [StringLength(20)]
    [Unicode(false)]
    public string Numero { get; set; } = null!;

    [Column("usuario_crea")]
    public int? UsuarioCrea { get; set; }

    [Column("usuario_actualiza")]
    public int UsuarioActualiza { get; set; }

    [Column("fecha_crea")]
    [Precision(6)]
    public DateTime FechaCrea { get; set; }

    [Column("fecha_actualiza")]
    [Precision(6)]
    public DateTime FechaActualiza { get; set; }
}
