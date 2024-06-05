using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BDKopymixModel;

[Table("Error")]
public partial class Error
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("url")]
    [Unicode(false)]
    public string? Url { get; set; }

    [Column("controller")]
    [StringLength(200)]
    public string? Controller { get; set; }

    [Column("ip")]
    [StringLength(100)]
    public string? Ip { get; set; }

    [Column("method")]
    [StringLength(20)]
    public string? Method { get; set; }

    [Column("user_agent")]
    [StringLength(150)]
    public string? UserAgent { get; set; }

    [Column("host")]
    public string? Host { get; set; }

    [Column("class_component")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ClassComponent { get; set; }

    [Column("function_name")]
    [StringLength(100)]
    [Unicode(false)]
    public string? FunctionName { get; set; }

    [Column("line_number")]
    public int LineNumber { get; set; }

    [Column("error")]
    public string? Error1 { get; set; }

    public string? StackTrace { get; set; }

    [Column("status")]
    public short Status { get; set; }

    [Column("request")]
    public string? Request { get; set; }

    [Column("error_code")]
    public int ErrorCode { get; set; }

    [Column("id_persona")]
    public int? IdPersona { get; set; }

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
