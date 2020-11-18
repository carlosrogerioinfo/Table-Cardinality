using App.EFCore.Test.Models.ManyToMany;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.EFCore.Test.Mapping
{
    public class LivroAutorMap : IEntityTypeConfiguration<LivroAutor>
    {
        public void Configure(EntityTypeBuilder<LivroAutor> builder)
        {

            //Definição da chave

            builder.HasKey(x => new { x.AutorId, x.LivroId });

            //Definição do relacionamento N:N - Muitos para Muitos

            builder
                .HasOne<Autor>(a => a.Autor)
                .WithMany(la => la.LivrosAutores)
                .HasForeignKey(a => a.AutorId);

            builder
                .HasOne<Livro>(l => l.Livro)
                .WithMany(la => la.LivrosAutores)
                .HasForeignKey(l => l.LivroId);

        }

    }
}
