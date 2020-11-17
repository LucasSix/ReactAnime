using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Back_End.Models
{
    [Table("tb_anime")]
    public partial class TbAnime
    {
        public TbAnime()
        {
            TbPermissao = new HashSet<TbPermissao>();
        }

        [Key]
        [Column("id_anime")]
        public int IdAnime { get; set; }
        [Column("nm_anime", TypeName = "varchar(100)")]
        public string NmAnime { get; set; }
        [Column("vl_duracao", TypeName = "decimal(15,5)")]
        public decimal? VlDuracao { get; set; }
        [Column("nr_classificacao_idade")]
        public int? NrClassificacaoIdade { get; set; }
        [Column("dt_lancamento", TypeName = "date")]
        public DateTime? DtLancamento { get; set; }
        [Column("vl_avaliacao", TypeName = "decimal(15,5)")]
        public decimal? VlAvaliacao { get; set; }
        [Column("nm_autor", TypeName = "varchar(100)")]
        public string NmAutor { get; set; }
        [Column("ds_genero", TypeName = "varchar(100)")]
        public string DsGenero { get; set; }
        [Column("img_capa", TypeName = "varchar(100)")]
        public string ImgCapa { get; set; }

        [InverseProperty("IdAnimeNavigation")]
        public virtual ICollection<TbPermissao> TbPermissao { get; set; }
    }
}
