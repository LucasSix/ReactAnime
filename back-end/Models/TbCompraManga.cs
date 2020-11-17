using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Back_End.Models
{
    [Table("tb_compra_manga")]
    public partial class TbCompraManga
    {
        [Key]
        [Column("id_compra_manga")]
        public int IdCompraManga { get; set; }
        [Column("id_compra")]
        public int? IdCompra { get; set; }
        [Column("id_manga")]
        public int? IdManga { get; set; }
        [Column("vl_total", TypeName = "decimal(15,5)")]
        public decimal? VlTotal { get; set; }
        [Column("qt_manga")]
        public int? QtManga { get; set; }

        [ForeignKey(nameof(IdCompra))]
        [InverseProperty(nameof(TbCompra.TbCompraManga))]
        public virtual TbCompra IdCompraNavigation { get; set; }
        [ForeignKey(nameof(IdManga))]
        [InverseProperty(nameof(TbManga.TbCompraManga))]
        public virtual TbManga IdMangaNavigation { get; set; }
    }
}
