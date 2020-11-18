using App.EFCore.Test.Models.OneToOne;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.EFCore.Test.Mapping
{
    public class EnderecoPessoaMap: IEntityTypeConfiguration<EnderecoPessoa>
    {
        public void Configure(EntityTypeBuilder<EnderecoPessoa> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .IsRequired();

            builder.Property(x => x.Endereco)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnType("varchar");

            builder
                .HasOne<Pessoa>(p => p.Pessoa)
                .WithOne(ep => ep.EnderecoPessoa)
                .HasForeignKey<EnderecoPessoa>(ep => ep.PessoaId);
        }

    }
}
