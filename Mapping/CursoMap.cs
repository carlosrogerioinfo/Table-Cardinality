using App.EFCore.Test.Models.OneToMany;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.EFCore.Test.Mapping
{
    public class CursoMap: IEntityTypeConfiguration<Curso>
    {
        public void Configure(EntityTypeBuilder<Curso> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .IsRequired();

            builder.Property(x => x.Nome)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("varchar");

            builder.Property(x => x.Duracao)
                .IsRequired()
                .HasColumnType("int");

            builder
                .HasMany<Aluno>(a => a.Alunos)
                .WithOne(c => c.Curso)
                .HasForeignKey(c => c.CursoId)
                .OnDelete(DeleteBehavior.Cascade);

        }

    }
}
