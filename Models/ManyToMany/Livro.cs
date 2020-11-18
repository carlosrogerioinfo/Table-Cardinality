using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.EFCore.Test.Models.ManyToMany
{
    [Table("efcore_livro")]
    public class Livro: Entity
    {
        protected Livro() {}

        public string Titulo { get; private set; }
        public int AnoLancamento { get; private set; }
        public ICollection<LivroAutor> LivrosAutores { get; private set; }

    }
}
