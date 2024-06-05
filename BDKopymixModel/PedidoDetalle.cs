using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BDKopymixModel;

public partial class PedidoDetalle
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("idProducto")]
    public int? IdProducto { get; set; }

    [Column("idPedido")]
    public int? IdPedido { get; set; }

    [Column("cantidad", TypeName = "decimal(18, 0)")]
    public decimal Cantidad { get; set; }

    [Column("precioUnitario", TypeName = "decimal(18, 0)")]
    public decimal PrecioUnitario { get; set; }

    [Column("subTotal", TypeName = "decimal(18, 0)")]
    public decimal SubTotal { get; set; }

    [Column("estado")]
    public bool Estado { get; set; }

    [ForeignKey("IdPedido")]
    [InverseProperty("PedidoDetalles")]
    public virtual Pedido? IdPedidoNavigation { get; set; }

    [ForeignKey("IdProducto")]
    [InverseProperty("PedidoDetalles")]
    public virtual Producto? IdProductoNavigation { get; set; }
}
