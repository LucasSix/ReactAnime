using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Back_End.Models
{
    [Table("tb_manga")]
    public partial class TbManga
    {
        public TbManga()
        {
            TbCompraManga = new HashSet<TbCompraManga>();
            TbPermissao = new HashSet<TbPermissao>();
        }

        [Key]
        [Column("id_manga")]
        public int IdManga { get; set; }
        [Column("nm_manga", TypeName = "varchar(100)")]
        public string NmManga { get; set; }
        [Column("vl_preco", TypeName = "decimal(15,5)")]
        public decimal? VlPreco { get; set; }
        [Column("dt_lancamento", TypeName = "date")]
        public DateTime? DtLancamento { get; set; }
        [Column("nm_autor", TypeName = "varchar(100)")]
        public string NmAutor { get; set; }
        [Column("ds_genero", TypeName = "varchar(100)")]
        public string DsGenero { get; set; }
        [Column("nr_classificacao_idade")]
        public int? NrClassificacaoIdade { get; set; }
        [Column("vl_avaliacao", TypeName = "decimal(15,5)")]
        public decimal? VlAvaliacao { get; set; }
        [Column("qt_pagina")]
        public int? QtPagina { get; set; }
        [Column("bt_disponivel")]
        public bool? BtDisponivel { get; set; }
        [Column("img_capa", TypeName = "varchar(100)")]
        public string ImgCapa { get; set; }

        [InverseProperty("IdMangaNavigation")]
        public virtual ICollection<TbCompraManga> TbCompraManga { get; set; }
        [InverseProperty("IdMangaNavigation")]
        public virtual ICollection<TbPermissao> TbPermissao { get; set; }
    }
}
