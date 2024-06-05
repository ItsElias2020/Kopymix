using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BDKopymixModel;

public partial class PedidoDetallePago
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("idPedido")]
    public int? IdPedido { get; set; }

    [Column("idMedioPago")]
    public int? IdMedioPago { get; set; }

    [Column("montoPago")]
    public int MontoPago { get; set; }

    [ForeignKey("IdMedioPago")]
    [InverseProperty("PedidoDetallePagos")]
    public virtual MedioPago? IdMedioPagoNavigation { get; set; }

    [ForeignKey("IdPedido")]
    [InverseProperty("PedidoDetallePagos")]
    public virtual Pedido? IdPedidoNavigation { get; set; }
}
