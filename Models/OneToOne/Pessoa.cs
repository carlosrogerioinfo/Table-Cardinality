using App.EFCore.Test.Enumerators;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.EFCore.Test.Models.OneToOne
{
    [Table("efcore_pessoa")]
    public class Pessoa: Entity
    {
        public Pessoa()
        {

        }

        public string Nome { get; set; }
        public TipoPessoa TipoPessoa { get; set; }
        public EnderecoPessoa EnderecoPessoa { get; set; }

    }
}
