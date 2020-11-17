using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Back_End.Models
{
    [Table("tb_permissao")]
    public partial class TbPermissao
    {
        [Key]
        [Column("id_permissao")]
        public int IdPermissao { get; set; }
        [Column("id_funcionario")]
        public int? IdFuncionario { get; set; }
        [Column("id_anime")]
        public int? IdAnime { get; set; }
        [Column("id_manga")]
        public int? IdManga { get; set; }
        [Column("bt_alterar_anime")]
        public bool? BtAlterarAnime { get; set; }
        [Column("bt_add_anime")]
        public bool? BtAddAnime { get; set; }
        [Column("bt_alterar_manga")]
        public bool? BtAlterarManga { get; set; }
        [Column("bt_visualizar")]
        public bool? BtVisualizar { get; set; }

        [ForeignKey(nameof(IdAnime))]
        [InverseProperty(nameof(TbAnime.TbPermissao))]
        public virtual TbAnime IdAnimeNavigation { get; set; }
        [ForeignKey(nameof(IdFuncionario))]
        [InverseProperty(nameof(TbFuncionario.TbPermissao))]
        public virtual TbFuncionario IdFuncionarioNavigation { get; set; }
        [ForeignKey(nameof(IdManga))]
        [InverseProperty(nameof(TbManga.TbPermissao))]
        public virtual TbManga IdMangaNavigation { get; set; }
    }
}
