using App.EFCore.Test.Enumerators;
using App.EFCore.Test.Models.OneToOne;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.EFCore.Test.Mapping
{
    public class PessoaMap: IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .IsRequired();

            builder.Property(x => x.Nome)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("varchar");

            builder.Property(x => x.TipoPessoa)
                .IsRequired()
                .HasColumnName("TipoPessoa")
                .HasConversion(x => (char)x, x => (TipoPessoa)x);

            builder
                .HasOne<PessoaEndereco>(ep => ep.PessoaEndereco)
                .WithOne(p => p.Pessoa)
                .HasForeignKey<PessoaEndereco>(ep => ep.PessoaId);
        }

    }
}