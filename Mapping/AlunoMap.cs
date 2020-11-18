using App.EFCore.Test.Models.OneToMany;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.EFCore.Test.Mapping
{
    public class AlunoMap: IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .IsRequired();

            builder.Property(x => x.Nome)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("varchar");

            builder.Property(x => x.Matricula)
                .IsRequired()
                .HasMaxLength(5)
                .HasColumnType("varchar");

            builder
                .HasOne<Curso>(c => c.Curso)
                .WithMany(a => a.Alunos)
                .HasForeignKey(c => c.CursoId);

        }

    }
}
