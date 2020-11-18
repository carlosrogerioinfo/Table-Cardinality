using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.EFCore.Test.Models.OneToMany
{
    [Table("efcore_curso")]
    public class Curso: Entity
    {
        public Curso()
        {

        }

        public string Nome { get; set; }
        public int Duracao { get; set; }
        public ICollection<Aluno> Alunos { get; set; }

    }
}
