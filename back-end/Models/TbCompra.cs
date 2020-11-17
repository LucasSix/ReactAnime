using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Back_End.Models
{
    [Table("tb_compra")]
    public partial class TbCompra
    {
        public TbCompra()
        {
            TbCompraManga = new HashSet<TbCompraManga>();
        }

        [Key]
        [Column("id_compra")]
        public int IdCompra { get; set; }
        [Column("id_cliente")]
        public int? IdCliente { get; set; }
        [Column("bt_pago")]
        public bool? BtPago { get; set; }
        [Column("bt_cartao")]
        public bool? BtCartao { get; set; }
        [Column("bt_pay_pal")]
        public bool? BtPayPal { get; set; }
        [Column("bt_pague_seguro")]
        public bool? BtPagueSeguro { get; set; }
        [Column("dt_dia_compra", TypeName = "date")]
        public DateTime? DtDiaCompra { get; set; }

        [ForeignKey(nameof(IdCliente))]
        [InverseProperty(nameof(TbCliente.TbCompra))]
        public virtual TbCliente IdClienteNavigation { get; set; }
        [InverseProperty("IdCompraNavigation")]
        public virtual ICollection<TbCompraManga> TbCompraManga { get; set; }
    }
}
