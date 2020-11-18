using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.EFCore.Test.Models.ManyToMany
{
    [Table("efcore_livro_autor")]
    public class LivroAutor
    {

        public LivroAutor()
        {

        }

        public Guid LivroId { get; set; }
        public Guid AutorId { get; set; }
        public Autor Autor { get; set; }
        public Livro Livro { get; set; }

    }
}
