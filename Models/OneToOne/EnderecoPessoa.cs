using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.EFCore.Test.Models.OneToOne
{
    [Table("efcore_pessoa_endereco")]
    public class EnderecoPessoa: Entity
    {
        public EnderecoPessoa()
        {

        }

        public string Endereco { get; set; }
        public Guid PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }

    }
}
