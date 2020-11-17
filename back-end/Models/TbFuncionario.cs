using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Back_End.Models
{
    [Table("tb_funcionario")]
    public partial class TbFuncionario
    {
        public TbFuncionario()
        {
            TbPermissao = new HashSet<TbPermissao>();
        }

        [Key]
        [Column("id_funcionario")]
        public int IdFuncionario { get; set; }
        [Column("nm_funcionario", TypeName = "varchar(100)")]
        public string NmFuncionario { get; set; }
        [Column("dt_nascimento", TypeName = "date")]
        public DateTime? DtNascimento { get; set; }
        [Column("nr_rg")]
        public int? NrRg { get; set; }
        [Column("nr_cpf")]
        public int? NrCpf { get; set; }
        [Column("nr_telefone")]
        public int? NrTelefone { get; set; }
        [Column("ds_endereco", TypeName = "varchar(100)")]
        public string DsEndereco { get; set; }
        [Column("ds_email", TypeName = "varchar(100)")]
        public string DsEmail { get; set; }
        [Column("dt_ultimo_acesso", TypeName = "date")]
        public DateTime? DtUltimoAcesso { get; set; }

        [InverseProperty("IdFuncionarioNavigation")]
        public virtual ICollection<TbPermissao> TbPermissao { get; set; }
    }
}
