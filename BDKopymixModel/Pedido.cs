using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BDKopymixModel;

public partial class Pedido
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("fecha", TypeName = "date")]
    public DateTime Fecha { get; set; }

    [Column("estadoPagado")]
    public bool EstadoPagado { get; set; }

    [Column("montoTotal", TypeName = "decimal(18, 0)")]
    public decimal MontoTotal { get; set; }

    [Column("montoPagado", TypeName = "decimal(18, 0)")]
    public decimal MontoPagado { get; set; }

    [Column("montoPorPagar", TypeName = "decimal(18, 0)")]
    public decimal MontoPorPagar { get; set; }

    [Column("nroSerie")]
    [StringLength(7)]
    [Unicode(false)]
    public string NroSerie { get; set; } = null!;

    [Column("igv", TypeName = "decimal(18, 0)")]
    public decimal Igv { get; set; }

    [Column("idCliente")]
    public int? IdCliente { get; set; }

    [Column("idEstadoPedido")]
    public int? IdEstadoPedido { get; set; }

    [Column("idDireccion")]
    public int? IdDireccion { get; set; }

    [Column("idComprobantePago")]
    public int? IdComprobantePago { get; set; }

    [Column("idUsuario")]
    public int? IdUsuario { get; set; }

    [ForeignKey("IdCliente")]
    [InverseProperty("Pedidos")]
    public virtual Cliente? IdClienteNavigation { get; set; }

    [ForeignKey("IdComprobantePago")]
    [InverseProperty("Pedidos")]
    public virtual ComprobantePago? IdComprobantePagoNavigation { get; set; }

    [ForeignKey("IdDireccion")]
    [InverseProperty("Pedidos")]
    public virtual Direccione? IdDireccionNavigation { get; set; }

    [ForeignKey("IdEstadoPedido")]
    [InverseProperty("Pedidos")]
    public virtual EstadoPedido? IdEstadoPedidoNavigation { get; set; }

    [ForeignKey("IdUsuario")]
    [InverseProperty("Pedidos")]
    public virtual Usuario? IdUsuarioNavigation { get; set; }

    [InverseProperty("IdPedidoNavigation")]
    public virtual ICollection<PedidoDetallePago> PedidoDetallePagos { get; set; } = new List<PedidoDetallePago>();

    [InverseProperty("IdPedidoNavigation")]
    public virtual ICollection<PedidoDetalle> PedidoDetalles { get; set; } = new List<PedidoDetalle>();
}
