using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.EFCore.Test.Models.OneToMany
{
    [Table("efcore_aluno")]
    public class Aluno: Entity
    {
        public Aluno()
        {

        }

        public string Nome { get; set; }
        public string Matricula { get; set; }
        public Guid CursoId { get; set; }
        public Curso Curso { get; set; }


    }
}
