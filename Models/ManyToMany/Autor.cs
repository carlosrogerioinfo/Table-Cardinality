using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.EFCore.Test.Models.ManyToMany
{
    [Table("efcore_autor")]
    public class Autor: Entity
    {
        protected Autor() {}

        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public ICollection<LivroAutor> LivrosAutores { get; set; }

    }
}
