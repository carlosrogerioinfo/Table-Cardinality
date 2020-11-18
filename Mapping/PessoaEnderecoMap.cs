using App.EFCore.Test.Models.OneToOne;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.EFCore.Test.Mapping
{
    public class PessoaEnderecoMap: IEntityTypeConfiguration<PessoaEndereco>
    {
        public void Configure(EntityTypeBuilder<PessoaEndereco> builder)
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
                .WithOne(ep => ep.PessoaEndereco)
                .HasForeignKey<PessoaEndereco>(ep => ep.PessoaId);
        }

    }
}
